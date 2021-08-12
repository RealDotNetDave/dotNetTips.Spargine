## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
; 			var channel = new ChannelQueue<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people = this.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var token = CancellationToken.None;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var tasks = new List<Task>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(AddToQueue(channel, people, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(ListenToQueue(channel, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Task.WaitAll(tasks.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(channel.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+160]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,21DDFEB2DC0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rdi
       xor       edx,edx
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9EA1F9A88
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       mov       [rsp+40],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+48],r8
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, dotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M02_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M02_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 110
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, dotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       jne       short M04_L00
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M04_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 105
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
       jne       short M05_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FF9EA21F958
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FF9EA21F948
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
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L30
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L31
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L00
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+28],2
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L33
M06_L00:
       xor       ecx,ecx
       mov       [rsp+70],rcx
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       mov       r12d,1
       mov       r13d,[rsi+8]
       lea       eax,[r13+0FFFF]
       test      eax,eax
       jl        near ptr M06_L17
M06_L01:
       cmp       eax,r13d
       jae       near ptr M06_L35
       mov       [rsp+6C],eax
       movsxd    rcx,eax
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        near ptr M06_L32
       mov       [rsp+28],rdx
       mov       ecx,[rdx+34]
       test      ecx,1600000
       setne     r8b
       movzx     r8d,r8b
       mov       [rsp+68],r8d
       test      r8d,r8d
       jne       near ptr M06_L11
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L05
M06_L02:
       mov       [rsp+34],r13d
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+34]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
M06_L03:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L04
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M06_L11
M06_L04:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L11
M06_L05:
       mov       rdx,[rsp+28]
       mov       [rsp+28],rdx
       mov       rcx,rdx
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L06
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       mov       rax,[rsp+28]
       jmp       short M06_L07
M06_L06:
       mov       rax,[rsp+28]
       xor       ecx,ecx
M06_L07:
       movzx     r8d,cl
       mov       edx,r8d
       mov       [rsp+68],edx
       test      edx,edx
       jne       short M06_L09
       mov       [rsp+30],r13d
       test      rbx,rbx
       jne       short M06_L08
       mov       [rsp+28],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rsp+28]
M06_L08:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L10
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       [rsp+28],rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L11
M06_L09:
       mov       [rsp+28],rax
       jmp       short M06_L11
M06_L10:
       mov       [rsp+28],rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L11:
       cmp       dword ptr [rsp+68],0
       je        near ptr M06_L16
       mov       rdx,[rsp+28]
       test      dword ptr [rdx+34],200000
       je        short M06_L12
       mov       r14d,1
       jmp       short M06_L13
M06_L12:
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L13
       mov       r15d,1
M06_L13:
       mov       [rsp+28],rdx
       test      dword ptr [rdx+34],10000000
       je        short M06_L16
       test      rbp,rbp
       jne       short M06_L14
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L14:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L15
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L16
M06_L15:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L16:
       mov       eax,[rsp+6C]
       dec       eax
       test      eax,eax
       jge       near ptr M06_L01
M06_L17:
       test      rbx,rbx
       je        near ptr M06_L24
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M06_L24
       mov       ecx,[rbx+14]
       mov       [rsp+50],rbx
       xor       edx,edx
       mov       [rsp+58],rdx
       mov       [rsp+60],edx
       mov       [rsp+64],ecx
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M06_L24
M06_L18:
       mov       rdi,[rsp+58]
       test      dword ptr [rdi+34],200000
       je        short M06_L19
       mov       r14d,1
       jmp       short M06_L20
M06_L19:
       mov       ecx,[rdi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L20
       mov       r15d,1
M06_L20:
       test      dword ptr [rdi+34],10000000
       je        short M06_L23
       test      rbp,rbp
       jne       short M06_L21
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L21:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L22
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L23
M06_L22:
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L23:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M06_L18
M06_L24:
       test      r12d,r12d
       je        short M06_L26
       test      rbp,rbp
       je        short M06_L26
       mov       ecx,[rbp+14]
       mov       [rsp+38],rbp
       xor       edx,edx
       mov       [rsp+40],rdx
       mov       [rsp+48],edx
       mov       [rsp+4C],ecx
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M06_L26
M06_L25:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L26
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L25
M06_L26:
       test      r12d,r12d
       je        short M06_L29
       or        r15d,r14d
       je        short M06_L29
       test      r14d,r14d
       jne       short M06_L27
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L27
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+28],2
       setge     al
       movzx     eax,al
       test      eax,eax
       jne       short M06_L33
M06_L27:
       xor       edi,edi
       test      r13d,r13d
       jle       short M06_L34
M06_L28:
       cmp       edi,r13d
       jae       short M06_L35
       movsxd    rcx,edi
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rsp+70]
       call      System.Threading.Tasks.Task.AddExceptionsForCompletedTask(System.Collections.Generic.List`1<System.Exception> ByRef, System.Threading.Tasks.Task)
       inc       edi
       cmp       r13d,edi
       jle       short M06_L34
       jmp       short M06_L28
M06_L29:
       mov       eax,r12d
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
M06_L30:
       mov       ecx,32
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L31:
       mov       ecx,3B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L32:
       mov       ecx,2C
       mov       edx,32
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L33:
       lea       rcx,[rsp+0D0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L34:
       mov       rcx,[rsp+70]
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1279
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+10]
       mov       [rbp+0FFE0],rdx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498C7C60
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
       call      qword ptr [rax+30]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498CA910
M07_L04:
       mov       eax,edi
       lea       rsp,[rbp+0FFF0]
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
       call      00007FFA498CA910
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 178
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
; 			var channel = new ChannelQueue<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people = this.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var token = CancellationToken.None;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var tasks = new List<Task>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(AddToQueue(channel, people, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(ListenToQueue(channel, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Task.WaitAll(tasks.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(channel.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+160]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1BE535E2DC0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rdi
       xor       edx,edx
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9EA1E9F20
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       mov       [rsp+40],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+48],r8
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, dotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M02_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M02_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 110
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, dotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       jne       short M04_L00
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M04_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 105
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
       jne       short M05_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FF9EA20FDC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FF9EA20FDB8
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
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L30
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L31
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L00
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+28],2
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L33
M06_L00:
       xor       ecx,ecx
       mov       [rsp+70],rcx
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       mov       r12d,1
       mov       r13d,[rsi+8]
       lea       eax,[r13+0FFFF]
       test      eax,eax
       jl        near ptr M06_L17
M06_L01:
       cmp       eax,r13d
       jae       near ptr M06_L35
       mov       [rsp+6C],eax
       movsxd    rcx,eax
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        near ptr M06_L32
       mov       [rsp+28],rdx
       mov       ecx,[rdx+34]
       test      ecx,1600000
       setne     r8b
       movzx     r8d,r8b
       mov       [rsp+68],r8d
       test      r8d,r8d
       jne       near ptr M06_L11
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L05
M06_L02:
       mov       [rsp+34],r13d
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+34]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
M06_L03:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L04
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M06_L11
M06_L04:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L11
M06_L05:
       mov       rdx,[rsp+28]
       mov       [rsp+28],rdx
       mov       rcx,rdx
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L06
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       mov       rax,[rsp+28]
       jmp       short M06_L07
M06_L06:
       mov       rax,[rsp+28]
       xor       ecx,ecx
M06_L07:
       movzx     r8d,cl
       mov       edx,r8d
       mov       [rsp+68],edx
       test      edx,edx
       jne       short M06_L09
       mov       [rsp+30],r13d
       test      rbx,rbx
       jne       short M06_L08
       mov       [rsp+28],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rsp+28]
M06_L08:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L10
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       [rsp+28],rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L11
M06_L09:
       mov       [rsp+28],rax
       jmp       short M06_L11
M06_L10:
       mov       [rsp+28],rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L11:
       cmp       dword ptr [rsp+68],0
       je        near ptr M06_L16
       mov       rdx,[rsp+28]
       test      dword ptr [rdx+34],200000
       je        short M06_L12
       mov       r14d,1
       jmp       short M06_L13
M06_L12:
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L13
       mov       r15d,1
M06_L13:
       mov       [rsp+28],rdx
       test      dword ptr [rdx+34],10000000
       je        short M06_L16
       test      rbp,rbp
       jne       short M06_L14
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L14:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L15
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L16
M06_L15:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L16:
       mov       eax,[rsp+6C]
       dec       eax
       test      eax,eax
       jge       near ptr M06_L01
M06_L17:
       test      rbx,rbx
       je        near ptr M06_L24
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M06_L24
       mov       ecx,[rbx+14]
       mov       [rsp+50],rbx
       xor       edx,edx
       mov       [rsp+58],rdx
       mov       [rsp+60],edx
       mov       [rsp+64],ecx
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M06_L24
M06_L18:
       mov       rdi,[rsp+58]
       test      dword ptr [rdi+34],200000
       je        short M06_L19
       mov       r14d,1
       jmp       short M06_L20
M06_L19:
       mov       ecx,[rdi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L20
       mov       r15d,1
M06_L20:
       test      dword ptr [rdi+34],10000000
       je        short M06_L23
       test      rbp,rbp
       jne       short M06_L21
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L21:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L22
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L23
M06_L22:
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L23:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M06_L18
M06_L24:
       test      r12d,r12d
       je        short M06_L26
       test      rbp,rbp
       je        short M06_L26
       mov       ecx,[rbp+14]
       mov       [rsp+38],rbp
       xor       edx,edx
       mov       [rsp+40],rdx
       mov       [rsp+48],edx
       mov       [rsp+4C],ecx
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M06_L26
M06_L25:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L26
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L25
M06_L26:
       test      r12d,r12d
       je        short M06_L29
       or        r15d,r14d
       je        short M06_L29
       test      r14d,r14d
       jne       short M06_L27
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L27
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+28],2
       setge     al
       movzx     eax,al
       test      eax,eax
       jne       short M06_L33
M06_L27:
       xor       edi,edi
       test      r13d,r13d
       jle       short M06_L34
M06_L28:
       cmp       edi,r13d
       jae       short M06_L35
       movsxd    rcx,edi
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rsp+70]
       call      System.Threading.Tasks.Task.AddExceptionsForCompletedTask(System.Collections.Generic.List`1<System.Exception> ByRef, System.Threading.Tasks.Task)
       inc       edi
       cmp       r13d,edi
       jle       short M06_L34
       jmp       short M06_L28
M06_L29:
       mov       eax,r12d
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
M06_L30:
       mov       ecx,32
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L31:
       mov       ecx,3B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L32:
       mov       ecx,2C
       mov       edx,32
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L33:
       lea       rcx,[rsp+0D0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L34:
       mov       rcx,[rsp+70]
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1279
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+10]
       mov       [rbp+0FFE0],rdx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498C7C60
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
       call      qword ptr [rax+30]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498CA910
M07_L04:
       mov       eax,edi
       lea       rsp,[rbp+0FFF0]
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
       call      00007FFA498CA910
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 178
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
; 			var channel = new ChannelQueue<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people = this.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var token = CancellationToken.None;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var tasks = new List<Task>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(AddToQueue(channel, people, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(ListenToQueue(channel, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Task.WaitAll(tasks.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(channel.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+160]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,20CE3D52DC0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rdi
       xor       edx,edx
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9EA1CA120
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       mov       [rsp+40],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+48],r8
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, dotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M02_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M02_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 110
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, dotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       jne       short M04_L00
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M04_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 105
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
       jne       short M05_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FF9EA210070
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FF9EA210060
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
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L30
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L31
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L00
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+28],2
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L33
M06_L00:
       xor       ecx,ecx
       mov       [rsp+70],rcx
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       mov       r12d,1
       mov       r13d,[rsi+8]
       lea       eax,[r13+0FFFF]
       test      eax,eax
       jl        near ptr M06_L17
M06_L01:
       cmp       eax,r13d
       jae       near ptr M06_L35
       mov       [rsp+6C],eax
       movsxd    rcx,eax
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        near ptr M06_L32
       mov       [rsp+28],rdx
       mov       ecx,[rdx+34]
       test      ecx,1600000
       setne     r8b
       movzx     r8d,r8b
       mov       [rsp+68],r8d
       test      r8d,r8d
       jne       near ptr M06_L11
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L05
M06_L02:
       mov       [rsp+34],r13d
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+34]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
M06_L03:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L04
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M06_L11
M06_L04:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L11
M06_L05:
       mov       rdx,[rsp+28]
       mov       [rsp+28],rdx
       mov       rcx,rdx
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L06
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       mov       rax,[rsp+28]
       jmp       short M06_L07
M06_L06:
       mov       rax,[rsp+28]
       xor       ecx,ecx
M06_L07:
       movzx     r8d,cl
       mov       edx,r8d
       mov       [rsp+68],edx
       test      edx,edx
       jne       short M06_L09
       mov       [rsp+30],r13d
       test      rbx,rbx
       jne       short M06_L08
       mov       [rsp+28],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rsp+28]
M06_L08:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L10
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       [rsp+28],rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L11
M06_L09:
       mov       [rsp+28],rax
       jmp       short M06_L11
M06_L10:
       mov       [rsp+28],rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L11:
       cmp       dword ptr [rsp+68],0
       je        near ptr M06_L16
       mov       rdx,[rsp+28]
       test      dword ptr [rdx+34],200000
       je        short M06_L12
       mov       r14d,1
       jmp       short M06_L13
M06_L12:
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L13
       mov       r15d,1
M06_L13:
       mov       [rsp+28],rdx
       test      dword ptr [rdx+34],10000000
       je        short M06_L16
       test      rbp,rbp
       jne       short M06_L14
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L14:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L15
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L16
M06_L15:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L16:
       mov       eax,[rsp+6C]
       dec       eax
       test      eax,eax
       jge       near ptr M06_L01
M06_L17:
       test      rbx,rbx
       je        near ptr M06_L24
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M06_L24
       mov       ecx,[rbx+14]
       mov       [rsp+50],rbx
       xor       edx,edx
       mov       [rsp+58],rdx
       mov       [rsp+60],edx
       mov       [rsp+64],ecx
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M06_L24
M06_L18:
       mov       rdi,[rsp+58]
       test      dword ptr [rdi+34],200000
       je        short M06_L19
       mov       r14d,1
       jmp       short M06_L20
M06_L19:
       mov       ecx,[rdi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L20
       mov       r15d,1
M06_L20:
       test      dword ptr [rdi+34],10000000
       je        short M06_L23
       test      rbp,rbp
       jne       short M06_L21
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L21:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L22
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L23
M06_L22:
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L23:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M06_L18
M06_L24:
       test      r12d,r12d
       je        short M06_L26
       test      rbp,rbp
       je        short M06_L26
       mov       ecx,[rbp+14]
       mov       [rsp+38],rbp
       xor       edx,edx
       mov       [rsp+40],rdx
       mov       [rsp+48],edx
       mov       [rsp+4C],ecx
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M06_L26
M06_L25:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L26
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L25
M06_L26:
       test      r12d,r12d
       je        short M06_L29
       or        r15d,r14d
       je        short M06_L29
       test      r14d,r14d
       jne       short M06_L27
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L27
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+28],2
       setge     al
       movzx     eax,al
       test      eax,eax
       jne       short M06_L33
M06_L27:
       xor       edi,edi
       test      r13d,r13d
       jle       short M06_L34
M06_L28:
       cmp       edi,r13d
       jae       short M06_L35
       movsxd    rcx,edi
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rsp+70]
       call      System.Threading.Tasks.Task.AddExceptionsForCompletedTask(System.Collections.Generic.List`1<System.Exception> ByRef, System.Threading.Tasks.Task)
       inc       edi
       cmp       r13d,edi
       jle       short M06_L34
       jmp       short M06_L28
M06_L29:
       mov       eax,r12d
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
M06_L30:
       mov       ecx,32
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L31:
       mov       ecx,3B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L32:
       mov       ecx,2C
       mov       edx,32
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L33:
       lea       rcx,[rsp+0D0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L34:
       mov       rcx,[rsp+70]
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1279
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+10]
       mov       [rbp+0FFE0],rdx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498C7C60
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
       call      qword ptr [rax+30]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498CA910
M07_L04:
       mov       eax,edi
       lea       rsp,[rbp+0FFF0]
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
       call      00007FFA498CA910
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 178
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
; 			var channel = new ChannelQueue<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people = this.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var token = CancellationToken.None;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var tasks = new List<Task>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(AddToQueue(channel, people, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(ListenToQueue(channel, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Task.WaitAll(tasks.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(channel.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+160]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1C932DB2DC0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rdi
       xor       edx,edx
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9EA1FA120
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       mov       [rsp+40],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+48],r8
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, dotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M02_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M02_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 110
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, dotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       jne       short M04_L00
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M04_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 105
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
       jne       short M05_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FF9EA240020
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FF9EA21FFE8
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
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L30
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L31
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L00
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+28],2
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L33
M06_L00:
       xor       ecx,ecx
       mov       [rsp+70],rcx
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       mov       r12d,1
       mov       r13d,[rsi+8]
       lea       eax,[r13+0FFFF]
       test      eax,eax
       jl        near ptr M06_L17
M06_L01:
       cmp       eax,r13d
       jae       near ptr M06_L35
       mov       [rsp+6C],eax
       movsxd    rcx,eax
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        near ptr M06_L32
       mov       [rsp+28],rdx
       mov       ecx,[rdx+34]
       test      ecx,1600000
       setne     r8b
       movzx     r8d,r8b
       mov       [rsp+68],r8d
       test      r8d,r8d
       jne       near ptr M06_L11
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L05
M06_L02:
       mov       [rsp+34],r13d
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+34]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
M06_L03:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L04
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M06_L11
M06_L04:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L11
M06_L05:
       mov       rdx,[rsp+28]
       mov       [rsp+28],rdx
       mov       rcx,rdx
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L06
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       mov       rax,[rsp+28]
       jmp       short M06_L07
M06_L06:
       mov       rax,[rsp+28]
       xor       ecx,ecx
M06_L07:
       movzx     r8d,cl
       mov       edx,r8d
       mov       [rsp+68],edx
       test      edx,edx
       jne       short M06_L09
       mov       [rsp+30],r13d
       test      rbx,rbx
       jne       short M06_L08
       mov       [rsp+28],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rsp+28]
M06_L08:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L10
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       [rsp+28],rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L11
M06_L09:
       mov       [rsp+28],rax
       jmp       short M06_L11
M06_L10:
       mov       [rsp+28],rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L11:
       cmp       dword ptr [rsp+68],0
       je        near ptr M06_L16
       mov       rdx,[rsp+28]
       test      dword ptr [rdx+34],200000
       je        short M06_L12
       mov       r14d,1
       jmp       short M06_L13
M06_L12:
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L13
       mov       r15d,1
M06_L13:
       mov       [rsp+28],rdx
       test      dword ptr [rdx+34],10000000
       je        short M06_L16
       test      rbp,rbp
       jne       short M06_L14
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L14:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L15
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L16
M06_L15:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L16:
       mov       eax,[rsp+6C]
       dec       eax
       test      eax,eax
       jge       near ptr M06_L01
M06_L17:
       test      rbx,rbx
       je        near ptr M06_L24
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M06_L24
       mov       ecx,[rbx+14]
       mov       [rsp+50],rbx
       xor       edx,edx
       mov       [rsp+58],rdx
       mov       [rsp+60],edx
       mov       [rsp+64],ecx
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M06_L24
M06_L18:
       mov       rdi,[rsp+58]
       test      dword ptr [rdi+34],200000
       je        short M06_L19
       mov       r14d,1
       jmp       short M06_L20
M06_L19:
       mov       ecx,[rdi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L20
       mov       r15d,1
M06_L20:
       test      dword ptr [rdi+34],10000000
       je        short M06_L23
       test      rbp,rbp
       jne       short M06_L21
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L21:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L22
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L23
M06_L22:
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L23:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M06_L18
M06_L24:
       test      r12d,r12d
       je        short M06_L26
       test      rbp,rbp
       je        short M06_L26
       mov       ecx,[rbp+14]
       mov       [rsp+38],rbp
       xor       edx,edx
       mov       [rsp+40],rdx
       mov       [rsp+48],edx
       mov       [rsp+4C],ecx
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M06_L26
M06_L25:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L26
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L25
M06_L26:
       test      r12d,r12d
       je        short M06_L29
       or        r15d,r14d
       je        short M06_L29
       test      r14d,r14d
       jne       short M06_L27
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L27
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+28],2
       setge     al
       movzx     eax,al
       test      eax,eax
       jne       short M06_L33
M06_L27:
       xor       edi,edi
       test      r13d,r13d
       jle       short M06_L34
M06_L28:
       cmp       edi,r13d
       jae       short M06_L35
       movsxd    rcx,edi
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rsp+70]
       call      System.Threading.Tasks.Task.AddExceptionsForCompletedTask(System.Collections.Generic.List`1<System.Exception> ByRef, System.Threading.Tasks.Task)
       inc       edi
       cmp       r13d,edi
       jle       short M06_L34
       jmp       short M06_L28
M06_L29:
       mov       eax,r12d
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
M06_L30:
       mov       ecx,32
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L31:
       mov       ecx,3B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L32:
       mov       ecx,2C
       mov       edx,32
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L33:
       lea       rcx,[rsp+0D0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L34:
       mov       rcx,[rsp+70]
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1279
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+10]
       mov       [rbp+0FFE0],rdx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498C7C60
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
       call      qword ptr [rax+30]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498CA910
M07_L04:
       mov       eax,edi
       lea       rsp,[rbp+0FFF0]
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
       call      00007FFA498CA910
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 178
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
; 			var channel = new ChannelQueue<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people = this.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var token = CancellationToken.None;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var tasks = new List<Task>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(AddToQueue(channel, people, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(ListenToQueue(channel, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Task.WaitAll(tasks.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(channel.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+160]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1ED380C2DC0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rdi
       xor       edx,edx
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9EA1D9F20
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       mov       [rsp+40],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+48],r8
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, dotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M02_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M02_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 110
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, dotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       jne       short M04_L00
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M04_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 105
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
       jne       short M05_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FF9EA1FFDB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FF9EA1FFDA8
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
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L30
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L31
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L00
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+28],2
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L33
M06_L00:
       xor       ecx,ecx
       mov       [rsp+70],rcx
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       mov       r12d,1
       mov       r13d,[rsi+8]
       lea       eax,[r13+0FFFF]
       test      eax,eax
       jl        near ptr M06_L17
M06_L01:
       cmp       eax,r13d
       jae       near ptr M06_L35
       mov       [rsp+6C],eax
       movsxd    rcx,eax
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        near ptr M06_L32
       mov       [rsp+28],rdx
       mov       ecx,[rdx+34]
       test      ecx,1600000
       setne     r8b
       movzx     r8d,r8b
       mov       [rsp+68],r8d
       test      r8d,r8d
       jne       near ptr M06_L11
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L05
M06_L02:
       mov       [rsp+34],r13d
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+34]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
M06_L03:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L04
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M06_L11
M06_L04:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L11
M06_L05:
       mov       rdx,[rsp+28]
       mov       [rsp+28],rdx
       mov       rcx,rdx
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L06
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       mov       rax,[rsp+28]
       jmp       short M06_L07
M06_L06:
       mov       rax,[rsp+28]
       xor       ecx,ecx
M06_L07:
       movzx     r8d,cl
       mov       edx,r8d
       mov       [rsp+68],edx
       test      edx,edx
       jne       short M06_L09
       mov       [rsp+30],r13d
       test      rbx,rbx
       jne       short M06_L08
       mov       [rsp+28],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rsp+28]
M06_L08:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L10
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       [rsp+28],rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L11
M06_L09:
       mov       [rsp+28],rax
       jmp       short M06_L11
M06_L10:
       mov       [rsp+28],rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L11:
       cmp       dword ptr [rsp+68],0
       je        near ptr M06_L16
       mov       rdx,[rsp+28]
       test      dword ptr [rdx+34],200000
       je        short M06_L12
       mov       r14d,1
       jmp       short M06_L13
M06_L12:
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L13
       mov       r15d,1
M06_L13:
       mov       [rsp+28],rdx
       test      dword ptr [rdx+34],10000000
       je        short M06_L16
       test      rbp,rbp
       jne       short M06_L14
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L14:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L15
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L16
M06_L15:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L16:
       mov       eax,[rsp+6C]
       dec       eax
       test      eax,eax
       jge       near ptr M06_L01
M06_L17:
       test      rbx,rbx
       je        near ptr M06_L24
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M06_L24
       mov       ecx,[rbx+14]
       mov       [rsp+50],rbx
       xor       edx,edx
       mov       [rsp+58],rdx
       mov       [rsp+60],edx
       mov       [rsp+64],ecx
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M06_L24
M06_L18:
       mov       rdi,[rsp+58]
       test      dword ptr [rdi+34],200000
       je        short M06_L19
       mov       r14d,1
       jmp       short M06_L20
M06_L19:
       mov       ecx,[rdi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L20
       mov       r15d,1
M06_L20:
       test      dword ptr [rdi+34],10000000
       je        short M06_L23
       test      rbp,rbp
       jne       short M06_L21
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L21:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L22
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L23
M06_L22:
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L23:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M06_L18
M06_L24:
       test      r12d,r12d
       je        short M06_L26
       test      rbp,rbp
       je        short M06_L26
       mov       ecx,[rbp+14]
       mov       [rsp+38],rbp
       xor       edx,edx
       mov       [rsp+40],rdx
       mov       [rsp+48],edx
       mov       [rsp+4C],ecx
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M06_L26
M06_L25:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L26
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L25
M06_L26:
       test      r12d,r12d
       je        short M06_L29
       or        r15d,r14d
       je        short M06_L29
       test      r14d,r14d
       jne       short M06_L27
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L27
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+28],2
       setge     al
       movzx     eax,al
       test      eax,eax
       jne       short M06_L33
M06_L27:
       xor       edi,edi
       test      r13d,r13d
       jle       short M06_L34
M06_L28:
       cmp       edi,r13d
       jae       short M06_L35
       movsxd    rcx,edi
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rsp+70]
       call      System.Threading.Tasks.Task.AddExceptionsForCompletedTask(System.Collections.Generic.List`1<System.Exception> ByRef, System.Threading.Tasks.Task)
       inc       edi
       cmp       r13d,edi
       jle       short M06_L34
       jmp       short M06_L28
M06_L29:
       mov       eax,r12d
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
M06_L30:
       mov       ecx,32
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L31:
       mov       ecx,3B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L32:
       mov       ecx,2C
       mov       edx,32
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L33:
       lea       rcx,[rsp+0D0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L34:
       mov       rcx,[rsp+70]
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1279
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+10]
       mov       [rbp+0FFE0],rdx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498C7C60
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
       call      qword ptr [rax+30]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498CA910
M07_L04:
       mov       eax,edi
       lea       rsp,[rbp+0FFF0]
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
       call      00007FFA498CA910
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 178
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
; 			var channel = new ChannelQueue<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people = this.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var token = CancellationToken.None;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var tasks = new List<Task>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(AddToQueue(channel, people, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(ListenToQueue(channel, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Task.WaitAll(tasks.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(channel.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+160]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2206C642DC0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rdi
       xor       edx,edx
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9EA1D9EB0
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       mov       [rsp+40],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+48],r8
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, dotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M02_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M02_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 110
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, dotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       jne       short M04_L00
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M04_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 105
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
       jne       short M05_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FF9EA1FFD30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FF9EA1FFD20
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
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L30
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L31
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L00
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+28],2
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L33
M06_L00:
       xor       ecx,ecx
       mov       [rsp+70],rcx
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       mov       r12d,1
       mov       r13d,[rsi+8]
       lea       eax,[r13+0FFFF]
       test      eax,eax
       jl        near ptr M06_L17
M06_L01:
       cmp       eax,r13d
       jae       near ptr M06_L35
       mov       [rsp+6C],eax
       movsxd    rcx,eax
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        near ptr M06_L32
       mov       [rsp+28],rdx
       mov       ecx,[rdx+34]
       test      ecx,1600000
       setne     r8b
       movzx     r8d,r8b
       mov       [rsp+68],r8d
       test      r8d,r8d
       jne       near ptr M06_L11
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L05
M06_L02:
       mov       [rsp+34],r13d
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+34]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
M06_L03:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L04
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M06_L11
M06_L04:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L11
M06_L05:
       mov       rdx,[rsp+28]
       mov       [rsp+28],rdx
       mov       rcx,rdx
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L06
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       mov       rax,[rsp+28]
       jmp       short M06_L07
M06_L06:
       mov       rax,[rsp+28]
       xor       ecx,ecx
M06_L07:
       movzx     r8d,cl
       mov       edx,r8d
       mov       [rsp+68],edx
       test      edx,edx
       jne       short M06_L09
       mov       [rsp+30],r13d
       test      rbx,rbx
       jne       short M06_L08
       mov       [rsp+28],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rsp+28]
M06_L08:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L10
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       [rsp+28],rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L11
M06_L09:
       mov       [rsp+28],rax
       jmp       short M06_L11
M06_L10:
       mov       [rsp+28],rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L11:
       cmp       dword ptr [rsp+68],0
       je        near ptr M06_L16
       mov       rdx,[rsp+28]
       test      dword ptr [rdx+34],200000
       je        short M06_L12
       mov       r14d,1
       jmp       short M06_L13
M06_L12:
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L13
       mov       r15d,1
M06_L13:
       mov       [rsp+28],rdx
       test      dword ptr [rdx+34],10000000
       je        short M06_L16
       test      rbp,rbp
       jne       short M06_L14
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L14:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L15
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L16
M06_L15:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L16:
       mov       eax,[rsp+6C]
       dec       eax
       test      eax,eax
       jge       near ptr M06_L01
M06_L17:
       test      rbx,rbx
       je        near ptr M06_L24
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M06_L24
       mov       ecx,[rbx+14]
       mov       [rsp+50],rbx
       xor       edx,edx
       mov       [rsp+58],rdx
       mov       [rsp+60],edx
       mov       [rsp+64],ecx
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M06_L24
M06_L18:
       mov       rdi,[rsp+58]
       test      dword ptr [rdi+34],200000
       je        short M06_L19
       mov       r14d,1
       jmp       short M06_L20
M06_L19:
       mov       ecx,[rdi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L20
       mov       r15d,1
M06_L20:
       test      dword ptr [rdi+34],10000000
       je        short M06_L23
       test      rbp,rbp
       jne       short M06_L21
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L21:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L22
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L23
M06_L22:
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L23:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M06_L18
M06_L24:
       test      r12d,r12d
       je        short M06_L26
       test      rbp,rbp
       je        short M06_L26
       mov       ecx,[rbp+14]
       mov       [rsp+38],rbp
       xor       edx,edx
       mov       [rsp+40],rdx
       mov       [rsp+48],edx
       mov       [rsp+4C],ecx
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M06_L26
M06_L25:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L26
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L25
M06_L26:
       test      r12d,r12d
       je        short M06_L29
       or        r15d,r14d
       je        short M06_L29
       test      r14d,r14d
       jne       short M06_L27
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L27
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+28],2
       setge     al
       movzx     eax,al
       test      eax,eax
       jne       short M06_L33
M06_L27:
       xor       edi,edi
       test      r13d,r13d
       jle       short M06_L34
M06_L28:
       cmp       edi,r13d
       jae       short M06_L35
       movsxd    rcx,edi
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rsp+70]
       call      System.Threading.Tasks.Task.AddExceptionsForCompletedTask(System.Collections.Generic.List`1<System.Exception> ByRef, System.Threading.Tasks.Task)
       inc       edi
       cmp       r13d,edi
       jle       short M06_L34
       jmp       short M06_L28
M06_L29:
       mov       eax,r12d
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
M06_L30:
       mov       ecx,32
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L31:
       mov       ecx,3B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L32:
       mov       ecx,2C
       mov       edx,32
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L33:
       lea       rcx,[rsp+0D0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L34:
       mov       rcx,[rsp+70]
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1279
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+10]
       mov       [rbp+0FFE0],rdx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498C7C60
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
       call      qword ptr [rax+30]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498CA910
M07_L04:
       mov       eax,edi
       lea       rsp,[rbp+0FFF0]
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
       call      00007FFA498CA910
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 178
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenTest01()
; 			var channel = new ChannelQueue<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people = this.PersonProperList;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var token = CancellationToken.None;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var tasks = new List<Task>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(AddToQueue(channel, people, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tasks.Add(ListenToQueue(channel, token));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Task.WaitAll(tasks.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(channel.Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rbx,[rsi+160]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,169F37E2DC0
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rdi
       xor       edx,edx
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9EA1FA120
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Collections.Generic.List`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       mov       [rsp+40],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+48],r8
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueue>d__5, dotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueue>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M02_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M02_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 110
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
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
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
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueue(dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<dotNetTips.Spargine.Tester.Models.PersonProper>, System.Threading.CancellationToken)
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueue>d__6, dotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueue>d__6 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       jne       short M04_L00
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M04_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 105
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
       jne       short M05_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FF9EA240020
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M05_L03
       mov       [rsp+20],rdx
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FF9EA21FFE8
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
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        near ptr M06_L30
       cmp       edi,0FFFFFFFF
       jl        near ptr M06_L31
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L00
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+28],2
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M06_L33
M06_L00:
       xor       ecx,ecx
       mov       [rsp+70],rcx
       xor       ebx,ebx
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       mov       r12d,1
       mov       r13d,[rsi+8]
       lea       eax,[r13+0FFFF]
       test      eax,eax
       jl        near ptr M06_L17
M06_L01:
       cmp       eax,r13d
       jae       near ptr M06_L35
       mov       [rsp+6C],eax
       movsxd    rcx,eax
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        near ptr M06_L32
       mov       [rsp+28],rdx
       mov       ecx,[rdx+34]
       test      ecx,1600000
       setne     r8b
       movzx     r8d,r8b
       mov       [rsp+68],r8d
       test      r8d,r8d
       jne       near ptr M06_L11
       cmp       edi,0FFFFFFFF
       jne       short M06_L02
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L05
M06_L02:
       mov       [rsp+34],r13d
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+34]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
M06_L03:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r9,[rcx+8]
       mov       r10d,[rcx+10]
       cmp       [r9+8],r10d
       jbe       short M06_L04
       lea       r11d,[r10+1]
       mov       [rcx+10],r11d
       mov       rcx,r9
       mov       edx,r10d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M06_L11
M06_L04:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L11
M06_L05:
       mov       rdx,[rsp+28]
       mov       [rsp+28],rdx
       mov       rcx,rdx
       call      System.Threading.Tasks.Task.WrappedTryRunInline()
       test      eax,eax
       je        short M06_L06
       mov       rax,[rsp+28]
       mov       ecx,[rax+34]
       test      ecx,1600000
       setne     cl
       movzx     ecx,cl
       mov       rax,[rsp+28]
       jmp       short M06_L07
M06_L06:
       mov       rax,[rsp+28]
       xor       ecx,ecx
M06_L07:
       movzx     r8d,cl
       mov       edx,r8d
       mov       [rsp+68],edx
       test      edx,edx
       jne       short M06_L09
       mov       [rsp+30],r13d
       test      rbx,rbx
       jne       short M06_L08
       mov       [rsp+28],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rsp+28]
M06_L08:
       mov       rcx,rbx
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L10
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       [rsp+28],rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L11
M06_L09:
       mov       [rsp+28],rax
       jmp       short M06_L11
M06_L10:
       mov       [rsp+28],rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L11:
       cmp       dword ptr [rsp+68],0
       je        near ptr M06_L16
       mov       rdx,[rsp+28]
       test      dword ptr [rdx+34],200000
       je        short M06_L12
       mov       r14d,1
       jmp       short M06_L13
M06_L12:
       mov       ecx,[rdx+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L13
       mov       r15d,1
M06_L13:
       mov       [rsp+28],rdx
       test      dword ptr [rdx+34],10000000
       je        short M06_L16
       test      rbp,rbp
       jne       short M06_L14
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L14:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       r9d,[rcx+10]
       cmp       [r8+8],r9d
       jbe       short M06_L15
       lea       r10d,[r9+1]
       mov       [rcx+10],r10d
       mov       rcx,r8
       mov       edx,r9d
       mov       r8,[rsp+28]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L16
M06_L15:
       mov       rdx,[rsp+28]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L16:
       mov       eax,[rsp+6C]
       dec       eax
       test      eax,eax
       jge       near ptr M06_L01
M06_L17:
       test      rbx,rbx
       je        near ptr M06_L24
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,[rsp+0D0]
       call      System.Threading.Tasks.Task.WaitAllBlockingCore(System.Collections.Generic.List`1<System.Threading.Tasks.Task>, Int32, System.Threading.CancellationToken)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M06_L24
       mov       ecx,[rbx+14]
       mov       [rsp+50],rbx
       xor       edx,edx
       mov       [rsp+58],rdx
       mov       [rsp+60],edx
       mov       [rsp+64],ecx
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M06_L24
M06_L18:
       mov       rdi,[rsp+58]
       test      dword ptr [rdi+34],200000
       je        short M06_L19
       mov       r14d,1
       jmp       short M06_L20
M06_L19:
       mov       ecx,[rdi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M06_L20
       mov       r15d,1
M06_L20:
       test      dword ptr [rdi+34],10000000
       je        short M06_L23
       test      rbp,rbp
       jne       short M06_L21
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L21:
       mov       rcx,rbp
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M06_L22
       lea       eax,[r8+1]
       mov       [rcx+10],eax
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L23
M06_L22:
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M06_L23:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M06_L18
M06_L24:
       test      r12d,r12d
       je        short M06_L26
       test      rbp,rbp
       je        short M06_L26
       mov       ecx,[rbp+14]
       mov       [rsp+38],rbp
       xor       edx,edx
       mov       [rsp+40],rdx
       mov       [rsp+48],edx
       mov       [rsp+4C],ecx
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M06_L26
M06_L25:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       test      eax,eax
       jne       short M06_L26
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L25
M06_L26:
       test      r12d,r12d
       je        short M06_L29
       or        r15d,r14d
       je        short M06_L29
       test      r14d,r14d
       jne       short M06_L27
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L27
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+28],2
       setge     al
       movzx     eax,al
       test      eax,eax
       jne       short M06_L33
M06_L27:
       xor       edi,edi
       test      r13d,r13d
       jle       short M06_L34
M06_L28:
       cmp       edi,r13d
       jae       short M06_L35
       movsxd    rcx,edi
       mov       rdx,[rsi+rcx*8+10]
       lea       rcx,[rsp+70]
       call      System.Threading.Tasks.Task.AddExceptionsForCompletedTask(System.Collections.Generic.List`1<System.Exception> ByRef, System.Threading.Tasks.Task)
       inc       edi
       cmp       r13d,edi
       jle       short M06_L34
       jmp       short M06_L28
M06_L29:
       mov       eax,r12d
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
M06_L30:
       mov       ecx,32
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M06_L31:
       mov       ecx,3B
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M06_L32:
       mov       ecx,2C
       mov       edx,32
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M06_L33:
       lea       rcx,[rsp+0D0]
       call      System.Threading.CancellationToken.ThrowOperationCanceledException()
       int       3
M06_L34:
       mov       rcx,[rsp+70]
       call      System.ThrowHelper.ThrowAggregateException(System.Collections.Generic.List`1<System.Exception>)
       int       3
M06_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1279
```
```assembly
; dotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdx,[rsi+10]
       mov       [rbp+0FFE0],rdx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M07_L01
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498C7C60
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
       call      qword ptr [rax+30]
       mov       edi,eax
       jmp       short M07_L00
M07_L03:
       cmp       byte ptr [rbp+0FFE8],0
       je        short M07_L04
       mov       rcx,[rbp+0FFE0]
       call      00007FFA498CA910
M07_L04:
       mov       eax,edi
       lea       rsp,[rbp+0FFF0]
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
       call      00007FFA498CA910
M07_L05:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 178
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,68
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DF0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,68
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E00020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,68
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,68
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,68
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,68
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DF0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,68
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync02>d__4 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E00020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync02>d__4.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 100
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E00020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 100
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 100
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 100
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E00020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 100
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 100
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       mov       rax,[rsp+50]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+50]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,78
       ret
; Total bytes of code 100
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync01>d__3 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync01>d__3.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
; Total bytes of code 88
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
; Total bytes of code 88
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
; Total bytes of code 88
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DF0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
; Total bytes of code 88
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DF0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
; Total bytes of code 88
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DF0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
; Total bytes of code 88
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync02()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
; Total bytes of code 88
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync02>d__1 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync02>d__1.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E00020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DF0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E00020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9DE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E00020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync01()
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,58
       ret
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
       je        short M02_L00
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0, dotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync01>d__0 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9E9E10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync01>d__0.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 224
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

