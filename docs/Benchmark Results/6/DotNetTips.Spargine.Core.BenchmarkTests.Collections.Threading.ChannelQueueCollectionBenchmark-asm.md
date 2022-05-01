## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+100]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,19AF9802FD8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rsi+40],eax
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
       mov       rdx,7FFF28F8BAD8
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
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
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FFF28ED5A30
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
       mov       rdx,7FFF28ED5A28
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
       lea       edx,[rax+0FFFF]
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
       mov       rdx,19AF9802FD8
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
       mov       rdx,19AF9802FD8
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
       mov       rcx,7FFF28AA4928
       mov       edx,46
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,19AF9802FE0
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
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L05
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+100]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,28079452FD8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rsi+40],eax
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
       mov       rdx,7FFF28F6BAD8
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
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
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FFF28EB5BB0
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
       mov       rdx,7FFF28EB5BA8
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
       lea       edx,[rax+0FFFF]
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
       mov       rdx,28079452FD8
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
       mov       rdx,28079452FD8
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
       mov       rcx,7FFF28A84928
       mov       edx,46
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,28079452FE0
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
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L05
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+100]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2189C5C2FD8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rsi+40],eax
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
       mov       rdx,7FFF28F8BAD8
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
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
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FFF28ED5BB0
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
       mov       rdx,7FFF28ED5BA8
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
       lea       edx,[rax+0FFFF]
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
       mov       rdx,2189C5C2FD8
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
       mov       rdx,2189C5C2FD8
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
       mov       rcx,7FFF28AA4928
       mov       edx,46
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2189C5C2FE0
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
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L05
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+100]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1C060CB2FD8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rsi+40],eax
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
       mov       rdx,7FFF28F9BAD8
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
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
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FFF28EE48A0
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
       mov       rdx,7FFF28EE4898
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
       lea       edx,[rax+0FFFF]
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
       mov       rdx,1C060CB2FD8
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
       mov       rdx,1C060CB2FD8
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
       mov       rcx,7FFF28AB4928
       mov       edx,46
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1C060CB2FE0
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
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L05
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+100]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,267D3CA2FD8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rsi+40],eax
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
       mov       rdx,7FFF28F6BAD8
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
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
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FFF28EB5BB0
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
       mov       rdx,7FFF28EB5BA8
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
       lea       edx,[rax+0FFFF]
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
       mov       rdx,267D3CA2FD8
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
       mov       rdx,267D3CA2FD8
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
       mov       rcx,7FFF28A84928
       mov       edx,46
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,267D3CA2FE0
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
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L05
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+100]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D1BF572FD8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rsi+40],eax
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
       mov       rdx,7FFF28F7B660
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
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
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FFF28F9A4C8
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
       mov       rdx,7FFF28F9A4C0
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
       lea       edx,[rax+0FFFF]
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
       mov       rdx,1D1BF572FD8
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
       mov       rdx,1D1BF572FD8
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
       mov       rcx,7FFF28A94928
       mov       edx,46
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1D1BF572FE0
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
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L05
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+100]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,215D0E72FD8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rsi+40],eax
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
       mov       rdx,7FFF28F8BAD8
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
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
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FFF28ED5BB0
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
       mov       rdx,7FFF28ED5BA8
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
       lea       edx,[rax+0FFFF]
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
       mov       rdx,215D0E72FD8
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
       mov       rdx,215D0E72FD8
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
       mov       rcx,7FFF28AA4928
       mov       edx,46
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,215D0E72FE0
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
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L05
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+100]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2299CC62FD8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rsi+40],eax
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
       mov       rdx,7FFF28F7BAD8
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
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
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FFF28EC5BB0
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
       mov       rdx,7FFF28EC5BA8
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
       lea       edx,[rax+0FFFF]
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
       mov       rdx,2299CC62FD8
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
       mov       rdx,2299CC62FD8
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
       mov       rcx,7FFF28A94928
       mov       edx,46
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2299CC62FE0
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
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+10]
       mov       [rbp+0FFE0],rcx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L05
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AB4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AC4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AA4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+48],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,78
       ret
M00_L01:
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 101
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AC4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+48],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,78
       ret
M00_L01:
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 101
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+48],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,78
       ret
M00_L01:
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 101
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+48],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,78
       ret
M00_L01:
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 101
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AA4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+48],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,78
       ret
M00_L01:
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 101
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AA4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+48],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,78
       ret
M00_L01:
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 101
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AB4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+48],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,78
       ret
M00_L01:
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 101
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AB4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+48],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,78
       ret
M00_L01:
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 101
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AA4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AB4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AB4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AB4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AC4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AC4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AA4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AB4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AC4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AB4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A84928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28AC4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A94928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF28A84928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
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
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

