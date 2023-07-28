## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFADF38D8D8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-80],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       mov       rcx,19641781568
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       vmovsd    xmm0,qword ptr [7FFADF38DAE0]
       vmovsd    qword ptr [rdi+8],xmm0
       xor       ecx,ecx
       mov       r8,19641781380
       mov       r8,[r8]
       vmovsd    xmm6,qword ptr [rbp+10]
       vucomisd  xmm6,xmm0
       setae     bl
       movzx     ebx,bl
       mov       [rbp-58],rdi
       mov       [rbp-50],rcx
       mov       [rbp-48],rcx
       mov       [rbp-40],r8
       mov       rcx,rsi
       lea       r8,[rbp-58]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       and       ebx,1
       jne       short M01_L00
       vxorps    xmm6,xmm6,xmm6
M01_L00:
       vmulsd    xmm0,xmm6,qword ptr [7FFADF38DAE8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,19641787E48
       mov       rcx,[rdx]
       mov       [rbp-70],rcx
       xor       edx,edx
       mov       [rbp-38],edx
       cmp       byte ptr [rbp-38],0
       jne       short M01_L01
       lea       rdx,[rbp-38]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,7FFADF094D48
       mov       edx,7
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax]
       mov       [rbp-68],rsi
       mov       [rbp-60],edi
       lea       rdx,[rbp-68]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       nop
       cmp       byte ptr [rbp-38],0
       je        short M01_L03
       mov       rcx,[rbp-70]
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
       vmovaps   xmm6,[rsp+70]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,19641782F38
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0A0]
       cmp       byte ptr [rbp-38],0
       je        short M01_L06
       mov       rcx,[rbp-70]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       vmovaps   xmm6,[rsp+30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 463
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFADFB87C38]
       call      qword ptr [7FFADFF6B1F8]; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01B3DE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       vmovaps   [rsp+60],xmm6
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-70],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       mov       rcx,21494400528
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFADFF971F8]; DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rdi+8],1
       mov       [rbp-40],rdi
       lea       rcx,[rbp-40]
       vmovsd    xmm6,qword ptr [rbp+10]
       mov       [rbp-50],rcx
       mov       dword ptr [rbp-48],1
       mov       rcx,rsi
       lea       r8,[rbp-50]
       call      qword ptr [7FFADFBD1DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       xor       eax,eax
       vucomisd  xmm6,qword ptr [7FFADFB87E28]
       setae     al
       test      eax,eax
       jne       short M01_L00
       vxorps    xmm6,xmm6,xmm6
M01_L00:
       vmulsd    xmm0,xmm6,qword ptr [7FFADFB87E30]
       call      qword ptr [7FFADFE3BD38]; System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,21498402A48
       mov       rcx,[rdx]
       mov       [rbp-68],rcx
       xor       edx,edx
       mov       [rbp-38],edx
       cmp       byte ptr [rbp-38],0
       jne       short M01_L01
       lea       rdx,[rbp-38]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFADFBD9030]
       int       3
M01_L02:
       mov       rcx,7FFADFDE6990
       mov       edx,7
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax]
       mov       [rbp-60],rsi
       mov       [rbp-58],edi
       lea       rdx,[rbp-60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       nop
       cmp       byte ptr [rbp-38],0
       je        short M01_L03
       mov       rcx,[rbp-68]
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
       call      qword ptr [7FFADFC199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       vmovaps   xmm6,[rsp+60]
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rdx,21494401F70
       mov       rax,[rdx]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       byte ptr [rbp-38],0
       je        short M01_L06
       mov       rcx,[rbp-68]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       vmovaps   xmm6,[rsp+30]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 441
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       ecx,41
       mov       edx,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       ecx,eax
       mov       [rsp+28],cx
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Char, System.Private.CoreLib]](Char ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       edi,edx
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       mov       edx,esi
       add       edx,1
       jo        short M01_L07
       cmp       edi,edx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,edx
M01_L03:
       mov       rdx,212C3747E48
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L04
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L04:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 183
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Char, System.Private.CoreLib]](Char ByRef)
       movzx     eax,word ptr [rdx]
       mov       [rcx+48],ax
       ret
; Total bytes of code 8
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       ecx,41
       mov       edx,7A
       call      qword ptr [7FFADFF39348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       ecx,eax
       mov       [rsp+28],cx
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01AF888]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Char, System.Private.CoreLib]](Char ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       edi,edx
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       mov       edx,esi
       add       edx,1
       jo        short M01_L07
       cmp       edi,edx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,edx
M01_L03:
       mov       rdx,2196E402A48
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L04
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFADFBB9030]
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      qword ptr [7FFADFF65750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 185
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Char, System.Private.CoreLib]](Char ByRef)
       movzx     eax,word ptr [rdx]
       mov       [rcx+48],ax
       ret
; Total bytes of code 8
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rsp+20],eax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rsp+24],eax
       mov       rax,[rsp+20]
       add       rsp,28
       ret
; Total bytes of code 59
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       call      qword ptr [7FFADFF49D38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01BBFC0]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFADFF49348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rsp+20],eax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFADFF49348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rsp+24],eax
       mov       rax,[rsp+20]
       add       rsp,28
       ret
; Total bytes of code 61
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      qword ptr [7FFAE01BD000]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 19
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      rsi
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       rsi,rcx
       mov       rdx,2C593411058
       mov       rdx,[rdx]
       add       rdx,8
       mov       r8d,[rdx]
       mov       ecx,[rdx+4]
       mov       rdx,[rdx+8]
       mov       r9d,3E8
       xor       eax,eax
       mov       [rsp+30],r8d
       mov       [rsp+34],ecx
       mov       [rsp+38],rdx
       mov       [rsp+20],eax
       mov       [rsp+24],eax
       mov       [rsp+28],r9
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       lea       rcx,[rsp+50]
       mov       r9d,2
       call      DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       vmovupd   xmm0,[rsp+50]
       vmovupd   [rsp+40],xmm0
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      r9d,r9d
       jl        short M01_L00
       cmp       r9d,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,203
       mov       rdx,7FFADF0446B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       test      r9d,r9d
       jl        near ptr M01_L05
       xor       edx,edx
M01_L03:
       mov       ecx,r9d
       xor       eax,eax
       mov       r8d,0A
       xor       r9d,r9d
       mov       [rsp+0A8],edx
       mov       [rsp+0AC],eax
       mov       [rsp+0B0],rcx
       mov       [rsp+98],r9d
       mov       [rsp+9C],r9d
       mov       [rsp+0A0],r8
       lea       rcx,[rsp+0A8]
       lea       rdx,[rsp+98]
       call      System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ebp,[rsp+0A8]
       mov       r14d,[rsp+0AC]
       mov       r15,[rsp+0B0]
       vmovupd   xmm0,[rsi]
       vmovupd   [rsp+88],xmm0
       mov       [rsp+78],ebp
       mov       [rsp+7C],r14d
       mov       [rsp+80],r15
       lea       rcx,[rsp+88]
       lea       rdx,[rsp+78]
       call      System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ecx,[rsp+88]
       mov       eax,[rsp+8C]
       mov       rdx,[rsp+90]
       mov       [rsp+28],ecx
       mov       [rsp+2C],eax
       mov       [rsp+30],rdx
       lea       rcx,[rsp+28]
       call      System.Decimal.ToInt32(System.Decimal)
       mov       esi,eax
       vmovupd   xmm0,[rdi]
       vmovupd   [rsp+68],xmm0
       mov       [rsp+58],ebp
       mov       [rsp+5C],r14d
       mov       [rsp+60],r15
       lea       rcx,[rsp+68]
       lea       rdx,[rsp+58]
       call      System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ecx,[rsp+68]
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+70]
       mov       [rsp+28],ecx
       mov       [rsp+2C],eax
       mov       [rsp+30],rdx
       lea       rcx,[rsp+28]
       call      System.Decimal.ToInt32(System.Decimal)
       mov       edx,eax
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jl        short M01_L06
       xor       edx,edx
M01_L04:
       mov       ecx,eax
       xor       eax,eax
       mov       [rsp+48],edx
       mov       [rsp+4C],eax
       mov       [rsp+50],rcx
       mov       [rsp+38],ebp
       mov       [rsp+3C],r14d
       mov       [rsp+40],r15
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rbx],xmm0
       mov       rax,rbx
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L05:
       mov       edx,80000000
       neg       r9d
       jmp       near ptr M01_L03
M01_L06:
       mov       edx,80000000
       neg       eax
       jmp       short M01_L04
; Total bytes of code 490
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      rsi
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       rsi,rcx
       mov       rdx,2D16D400060
       mov       rdx,[rdx]
       add       rdx,8
       mov       r8d,[rdx]
       mov       ecx,[rdx+4]
       mov       rdx,[rdx+8]
       mov       [rsp+30],r8d
       mov       [rsp+34],ecx
       mov       [rsp+38],rdx
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       qword ptr [rsp+28],3E8
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       lea       rcx,[rsp+50]
       mov       r9d,2
       call      qword ptr [7FFADFF592A0]; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       vmovupd   xmm0,[rsp+50]
       vmovupd   [rsp+40],xmm0
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01CDD50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      r9d,r9d
       jl        short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFADFFE1318]
       mov       rbp,rax
       mov       rcx,2D177400D70
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFADFFE1450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF8F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFADFFE1090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFADFD65750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       test      r9d,r9d
       jl        near ptr M01_L06
       xor       ecx,ecx
M01_L04:
       mov       edx,r9d
       mov       [rsp+0A8],ecx
       xor       ecx,ecx
       mov       [rsp+0AC],ecx
       mov       [rsp+0B0],rdx
       mov       [rsp+98],ecx
       mov       [rsp+9C],ecx
       mov       qword ptr [rsp+0A0],0A
       lea       rcx,[rsp+0A8]
       lea       rdx,[rsp+98]
       call      qword ptr [7FFAE01CDB58]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ebp,[rsp+0A8]
       mov       r14d,[rsp+0AC]
       mov       r15,[rsp+0B0]
       vmovupd   xmm0,[rsi]
       vmovupd   [rsp+88],xmm0
       mov       [rsp+78],ebp
       mov       [rsp+7C],r14d
       mov       [rsp+80],r15
       lea       rcx,[rsp+88]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFAE01CDB58]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ecx,[rsp+88]
       mov       eax,[rsp+8C]
       mov       rdx,[rsp+90]
       mov       [rsp+28],ecx
       mov       [rsp+2C],eax
       mov       [rsp+30],rdx
       lea       rcx,[rsp+28]
       call      qword ptr [7FFADFC4B960]; System.Decimal.ToInt32(System.Decimal)
       mov       esi,eax
       vmovupd   xmm0,[rdi]
       vmovupd   [rsp+68],xmm0
       mov       [rsp+58],ebp
       mov       [rsp+5C],r14d
       mov       [rsp+60],r15
       lea       rcx,[rsp+68]
       lea       rdx,[rsp+58]
       call      qword ptr [7FFAE01CDB58]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ecx,[rsp+68]
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+70]
       mov       [rsp+28],ecx
       mov       [rsp+2C],eax
       mov       [rsp+30],rdx
       lea       rcx,[rsp+28]
       call      qword ptr [7FFADFC4B960]; System.Decimal.ToInt32(System.Decimal)
       mov       edx,eax
       mov       ecx,esi
       call      qword ptr [7FFADFF59348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jl        short M01_L07
       xor       ecx,ecx
M01_L05:
       mov       edx,eax
       mov       [rsp+48],ecx
       xor       ecx,ecx
       mov       [rsp+4C],ecx
       mov       [rsp+50],rdx
       mov       [rsp+38],ebp
       mov       [rsp+3C],r14d
       mov       [rsp+40],r15
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FFAE01CDBE8]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rbx],xmm0
       mov       rax,rbx
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       ecx,80000000
       neg       r9d
       jmp       near ptr M01_L04
M01_L07:
       mov       ecx,80000000
       neg       eax
       jmp       short M01_L05
; Total bytes of code 705
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      qword ptr [7FFAE01CDD80]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 19
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,1CA92337E40
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rdi,[rcx+18]
M00_L00:
       mov       ebx,[rdi+8]
       mov       edx,ebx
       sub       edx,1
       jo        short M00_L02
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,ebx
       jae       short M00_L03
       movsxd    rcx,eax
       mov       rcx,[rdi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 132
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       edi,edx
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       mov       edx,esi
       add       edx,1
       jo        short M01_L07
       cmp       edi,edx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,edx
M01_L03:
       mov       rdx,1CA92337E48
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L04
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L04:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 183
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
System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,1D7A8006E48
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rdi,[rcx+18]
M00_L00:
       mov       ebx,[rdi+8]
       mov       edx,ebx
       sub       edx,1
       jo        short M00_L02
       xor       ecx,ecx
       call      qword ptr [7FFADFF69348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,ebx
       jae       short M00_L03
       mov       ecx,eax
       mov       rcx,[rdi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01DF330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FFADFF93F18]
       mov       rdi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       edi,edx
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       mov       edx,esi
       add       edx,1
       jo        short M01_L07
       cmp       edi,edx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,edx
M01_L03:
       mov       rdx,1D7A8006E50
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L04
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFADFBE9030]
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      qword ptr [7FFADFF95750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 185
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEmailAddress()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
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
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       push      rdi
       push      rsi
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rcx,26AC9352EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFADF06FF88]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       rsi,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L14
       lea       r10,[rax+10]
       mov       edi,[rax+8]
M01_L00:
       add       rsi,18
       mov       [rsi],r10
       mov       [rsi+8],edi
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       mov       ecx,5
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L03
       test      rdi,rdi
       je        near ptr M01_L03
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L16
       mov       rcx,[rsp+38]
       mov       edx,[rsp+40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rdi+8]
       cmp       r8d,edx
       ja        near ptr M01_L03
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rdi+8]
       mov       [rsp+30],ecx
M01_L01:
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       r8d,[rsp+30]
       cmp       r8d,ecx
       jae       near ptr M01_L15
       movsxd    rcx,r8d
       mov       word ptr [rdx+rcx*2],40
       inc       r8d
       mov       [rsp+30],r8d
M01_L02:
       mov       ecx,5
       mov       edx,0F
       mov       r8d,61
       mov       r9d,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L11
       test      rsi,rsi
       je        near ptr M01_L11
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L16
       mov       rcx,[rsp+38]
       mov       edx,[rsp+40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        near ptr M01_L11
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L01
M01_L04:
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L05:
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       mov       edx,[rsp+30]
       cmp       edx,ecx
       jae       near ptr M01_L17
       movsxd    rcx,edx
       mov       word ptr [rax+rcx*2],2E
       inc       edx
       mov       [rsp+30],edx
M01_L06:
       mov       rcx,26AC9357E40
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L08
       mov       rsi,[rcx+18]
M01_L07:
       mov       edx,[rsi+8]
       sub       edx,1
       jo        near ptr M01_L13
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,[rsi+8]
       jae       near ptr M01_L18
       movsxd    r8,eax
       mov       rsi,[rsi+r8*8+10]
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L12
       test      rsi,rsi
       je        short M01_L12
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L16
       mov       rcx,[rsp+38]
       mov       edx,[rsp+40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short M01_L12
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L09
M01_L08:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L07
M01_L09:
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L10:
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L11:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L05
M01_L12:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       short M01_L10
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       xor       r10d,r10d
       xor       edi,edi
       jmp       near ptr M01_L00
M01_L15:
       mov       rdx,26AB93518C8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L02
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rdx,26AC9353120
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 743
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEmailAddress()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFADFF392D0]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01AD8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       push      rdi
       push      rsi
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rcx,1E2CE001ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFADFDB1D68]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L12
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L00:
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       mov       ecx,5
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFADFF39570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L08
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L13
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L08
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFADFBF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L01:
       mov       ecx,[rsp+30]
       mov       rdx,[rsp+38]
       mov       r8d,[rsp+40]
       cmp       ecx,r8d
       jae       near ptr M01_L14
       mov       r8d,ecx
       mov       word ptr [rdx+r8*2],40
       inc       ecx
       mov       [rsp+30],ecx
M01_L02:
       mov       ecx,5
       mov       edx,0F
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFADFF39570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L09
       test      rdi,rdi
       je        near ptr M01_L09
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L13
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L09
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFADFBF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rdi+8]
       mov       [rsp+30],ecx
M01_L03:
       mov       ecx,[rsp+30]
       mov       rax,[rsp+38]
       mov       edx,[rsp+40]
       cmp       ecx,edx
       jae       near ptr M01_L15
       mov       edx,ecx
       mov       word ptr [rax+rdx*2],2E
       inc       ecx
       mov       [rsp+30],ecx
M01_L04:
       mov       rcx,1E2CE006E48
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L07
       mov       rsi,[rcx+18]
M01_L05:
       mov       edx,[rsi+8]
       sub       edx,1
       jo        near ptr M01_L11
       xor       ecx,ecx
       call      qword ptr [7FFADFF39348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,[rsi+8]
       jae       near ptr M01_L16
       mov       r8d,eax
       mov       rsi,[rsi+r8*8+10]
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L10
       test      rsi,rsi
       je        near ptr M01_L10
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L13
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        short M01_L10
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFADFBF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L06:
       lea       rcx,[rsp+20]
       call      qword ptr [7FFADFC2D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L07:
       call      qword ptr [7FFADFF63F18]
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L08:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      qword ptr [7FFADFC2DA50]
       jmp       near ptr M01_L01
M01_L09:
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       call      qword ptr [7FFADFC2DA50]
       jmp       near ptr M01_L03
M01_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      qword ptr [7FFADFC2DA50]
       jmp       short M01_L06
M01_L11:
       call      CORINFO_HELP_OVERFLOW
M01_L12:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L00
M01_L13:
       call      qword ptr [7FFADFD77498]
       int       3
M01_L14:
       mov       rdx,1E2D0000928
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFADFC2DAF8]
       jmp       near ptr M01_L02
M01_L15:
       mov       rdx,1E2CE002188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFADFC2DAF8]
       jmp       near ptr M01_L04
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 739
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFile()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,1CA52F21D38
       mov       rdx,[rdx]
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rcx,rax
       mov       edx,400
       call      DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 88
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       test      rcx,rcx
       je        near ptr M01_L17
       test      rdx,rdx
       je        near ptr M01_L16
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L14
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M01_L13
       lea       rax,[rdx+0C]
       mov       r8d,esi
       test      r8d,r8d
       jle       short M01_L00
       movzx     r9d,word ptr [rax]
       cmp       r9d,5C
       je        near ptr M01_L07
       cmp       r9d,2F
       sete      r9b
       movzx     r9d,r9b
       test      r9d,r9d
       jne       near ptr M01_L07
M01_L00:
       cmp       r8d,2
       jl        short M01_L06
       movzx     r8d,word ptr [rax]
       cmp       r8d,41
       jl        short M01_L02
       cmp       r8d,5A
       jg        short M01_L02
M01_L01:
       cmp       word ptr [rax+2],3A
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L06
       jmp       near ptr M01_L07
M01_L02:
       cmp       r8d,61
       jl        short M01_L06
       cmp       r8d,7A
       setle     r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L06
       jmp       short M01_L01
M01_L03:
       mov       [rsp+38],rdi
       mov       [rsp+40],ebx
       mov       [rsp+28],rbp
       mov       [rsp+30],esi
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       jmp       short M01_L05
M01_L04:
       mov       rax,r15
M01_L05:
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
M01_L06:
       lea       rdi,[rcx+0C]
       mov       ebx,[rcx+8]
       add       rdx,0C
       mov       rbp,rdx
       lea       eax,[rbx-1]
       cmp       eax,ebx
       jae       near ptr M01_L21
       movsxd    rax,eax
       movzx     eax,word ptr [rdi+rax*2]
       cmp       eax,5C
       je        short M01_L08
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L08
       jmp       near ptr M01_L10
M01_L07:
       mov       rax,rdx
       jmp       short M01_L05
M01_L08:
       mov       r8d,1
M01_L09:
       movzx     ecx,r8b
       test      ecx,ecx
       jne       near ptr M01_L03
       mov       rcx,1C9C2F29858
       mov       r14,[rcx]
       add       r14,0C
       mov       ecx,ebx
       add       ecx,1
       jo        near ptr M01_L15
       add       ecx,esi
       jo        near ptr M01_L15
       test      ecx,ecx
       je        near ptr M01_L19
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       lea       r12,[r15+0C]
       mov       r13d,[r15+8]
       cmp       ebx,r13d
       ja        near ptr M01_L20
       mov       eax,ebx
       add       rax,rax
       mov       [rsp+20],rax
       mov       r8,rax
       mov       rcx,r12
       mov       rdx,rdi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       sub       r13d,ebx
       add       r12,[rsp+20]
       cmp       r13d,1
       jb        near ptr M01_L20
       mov       r8d,2
       mov       rcx,r12
       mov       rdx,r14
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,r13d
       sub       r8d,1
       add       r12,2
       mov       rcx,r12
       cmp       esi,r8d
       ja        near ptr M01_L20
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbp
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L10:
       test      esi,esi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbp]
       cmp       ecx,5C
       je        short M01_L12
       cmp       ecx,2F
       sete      r8b
       movzx     r8d,r8b
M01_L11:
       jmp       near ptr M01_L09
M01_L12:
       mov       r8d,1
       jmp       short M01_L11
M01_L13:
       mov       rax,rcx
       jmp       near ptr M01_L05
M01_L14:
       mov       rax,rdx
       jmp       near ptr M01_L05
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rcx,1C9C2F29848
       mov       rsi,[rcx]
       jmp       short M01_L18
M01_L17:
       mov       rcx,1C9C2F29850
       mov       rsi,[rcx]
M01_L18:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rax,1C9C2F23020
       mov       rax,[rax]
       jmp       near ptr M01_L05
M01_L20:
       call      System.ThrowHelper.ThrowArgumentException_DestinationTooShort()
       int       3
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 654
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,rsi
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,21F
       mov       rdx,7FFADF0746B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       edx,edi
       test      edx,edx
       jle       short M02_L03
       cmp       edx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M02_L04
M02_L02:
       mov       eax,1
       jmp       short M02_L00
M02_L03:
       xor       eax,eax
M02_L04:
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,231
       mov       rdx,7FFADF0746B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L05:
       mov       rcx,rsi
       call      DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFile()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,[rsi+190]
       test      rdi,rdi
       je        near ptr M00_L07
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M00_L06
       mov       rcx,1B415C00D70
       mov       rbp,[rcx]
       add       rbp,0C
       mov       rcx,rbp
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],0D
       lea       rcx,[rsp+40]
       call      qword ptr [7FFADFE53510]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M00_L05
       add       rdi,0C
       lea       ecx,[rbx-1]
       cmp       ecx,ebx
       jae       near ptr M00_L08
       mov       ecx,ecx
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        near ptr M00_L03
       cmp       ecx,2F
       je        near ptr M00_L03
       movzx     ecx,word ptr [rbp]
       cmp       ecx,5C
       je        near ptr M00_L02
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M00_L00:
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L04
       mov       rcx,1B403C08870
       mov       rcx,[rcx]
       add       rcx,0C
       mov       [rsp+40],rdi
       mov       [rsp+48],ebx
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],1
       mov       [rsp+20],rbp
       mov       dword ptr [rsp+28],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       call      qword ptr [7FFADFBD1CC0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
M00_L01:
       mov       edx,400
       call      qword ptr [7FFADFF592E8]; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       mov       [rsp+50],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+50]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01CD8B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,1
       jmp       near ptr M00_L00
M00_L03:
       mov       ecx,1
       jmp       near ptr M00_L00
M00_L04:
       mov       [rsp+40],rdi
       mov       [rsp+48],ebx
       mov       [rsp+30],rbp
       mov       dword ptr [rsp+38],0D
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FFADFBD1CA8]
       mov       rcx,rax
       jmp       short M00_L01
M00_L05:
       mov       rcx,1B415C00D70
       mov       rcx,[rcx]
       jmp       near ptr M00_L01
M00_L06:
       mov       rcx,1B415C00D70
       mov       rcx,[rcx]
       jmp       near ptr M00_L01
M00_L07:
       mov       ecx,1A9EC
       mov       rdx,7FFADF984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFADFD3FF90]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 455
```
```assembly
; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       ecx,eax
       test      ecx,ecx
       jle       short M01_L00
       movzx     ecx,word ptr [rdx]
       cmp       ecx,5C
       je        short M01_L01
       cmp       ecx,2F
       je        short M01_L01
M01_L00:
       cmp       eax,2
       jl        short M01_L02
       movzx     eax,word ptr [rdx]
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        short M01_L02
       xor       eax,eax
       cmp       word ptr [rdx+2],3A
       sete      al
       ret
M01_L01:
       mov       eax,1
       ret
M01_L02:
       xor       eax,eax
       ret
; Total bytes of code 64
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,[r8]
       mov       edi,[r8+8]
       mov       rbx,[rdx]
       mov       ebp,[rdx+8]
       mov       r14,[rcx]
       mov       r15d,[rcx+8]
       mov       ecx,r15d
       add       ecx,ebp
       jo        near ptr M02_L00
       add       ecx,edi
       jo        near ptr M02_L00
       test      ecx,ecx
       je        near ptr M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       lea       r13,[r12+0C]
       mov       eax,[r12+8]
       mov       [rsp+24],eax
       cmp       r15d,eax
       ja        near ptr M02_L02
       mov       r8d,r15d
       add       r8,r8
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FFADFC199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,r15d
       lea       r13,[r13+r8*2]
       mov       r14d,[rsp+24]
       sub       r14d,r15d
       cmp       ebp,r14d
       ja        short M02_L02
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FFADFC199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,ebp
       lea       r13,[r13+r8*2]
       mov       r8d,r14d
       sub       r8d,ebp
       cmp       edi,r8d
       ja        short M02_L02
       mov       r8d,edi
       add       r8,r8
       mov       rcx,r13
       mov       rdx,rsi
       call      qword ptr [7FFADFC199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
M02_L01:
       mov       rax,1B403C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       call      qword ptr [7FFADFD974B0]
       int       3
; Total bytes of code 250
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,rsi
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
       call      qword ptr [7FFADFFE1450]
       mov       rsi,rax
       mov       ecx,21F
       mov       rdx,7FFADFDD6320
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF8F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       edx,edi
       test      edx,edx
       jle       short M03_L03
       mov       eax,1
       jmp       short M03_L04
M03_L03:
       xor       eax,eax
M03_L04:
       test      eax,eax
       jne       near ptr M03_L06
       call      qword ptr [7FFADFFE1318]
       mov       rdi,rax
       mov       rcx,1B415C00D80
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M03_L05
       call      qword ptr [7FFADFFE1450]
       mov       rdi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF8F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFADFD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L05:
       mov       edx,3
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFADFD65750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       rcx,rsi
       call      qword ptr [7FFADFF591C8]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 534
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFiles()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       edx,2
       mov       r8d,400
       call      DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,283
       mov       rdx,7FFADF0646B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       test      esi,esi
       jle       short M01_L03
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFADF0646B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L05:
       test      ebx,ebx
       jle       short M01_L06
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L07
M01_L06:
       xor       eax,eax
M01_L07:
       test      eax,eax
       jne       short M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,231
       mov       rdx,7FFADF0646B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L08:
       mov       rcx,rdi
       call      System.IO.Directory.CreateDirectory(System.String)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L12
M01_L09:
       mov       r8,27ACA951D38
       mov       r8,[r8]
       mov       rcx,rdi
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       r15,rax
       mov       rcx,r15
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L10
       lea       r8d,[rdx+1]
       mov       [rbp+10],r8d
       mov       r8,r15
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L11:
       add       r14d,1
       jo        short M01_L14
       cmp       r14d,esi
       jl        short M01_L09
M01_L12:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFADF372900]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L13
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L13:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 441
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFiles()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       edx,2
       mov       r8d,400
       call      qword ptr [7FFADFF59318]; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01CF918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFADFFE1450]
       mov       rdi,rax
       mov       ecx,283
       mov       rdx,7FFADFDD6320
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF8F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFADFD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       test      esi,esi
       jle       short M01_L03
       mov       eax,1
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FFADFFE1318]
       mov       rbp,rax
       mov       rax,1BC78404978
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFADFFE1450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF8F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFADFFE1090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFADFD65750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      ebx,ebx
       jle       short M01_L07
       mov       eax,1
       jmp       short M01_L08
M01_L07:
       xor       eax,eax
M01_L08:
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFADFFE1318]
       mov       r14,rax
       mov       rcx,1BC80400D70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L09
       call      qword ptr [7FFADFFE1450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF8F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       mov       edx,3
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFADFFE1090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFADFD65750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rdi
       call      qword ptr [7FFADFF1F798]; System.IO.Directory.CreateDirectory(System.String)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFADFC47918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L14
M01_L11:
       mov       r8,1BC80400D78
       mov       r8,[r8]
       mov       rcx,rdi
       mov       edx,0A
       call      qword ptr [7FFADFF59438]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       r15,rax
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFADFF591C8]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L12
       lea       r8d,[rdx+1]
       mov       [rbp+10],r8d
       movsxd    rdx,edx
       mov       r8,r15
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L13
M01_L12:
       mov       rcx,rbp
       mov       rdx,r15
       call      qword ptr [7FFADFC47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L13:
       add       r14d,1
       jo        short M01_L16
       cmp       r14d,esi
       jl        short M01_L11
M01_L14:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFADFB98378]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L15
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      qword ptr [7FFADFC47960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L15:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1012
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       edi,edx
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       mov       edx,esi
       add       edx,1
       jo        short M01_L07
       cmp       edi,edx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,edx
M01_L03:
       mov       rdx,1D454197E48
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L04
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L04:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 183
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFADFF59348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01CDFC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 52
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       edi,edx
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       mov       edx,esi
       add       edx,1
       jo        short M01_L07
       cmp       edi,edx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,edx
M01_L03:
       mov       rdx,29D3A806E50
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L04
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFADFBD9030]
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      qword ptr [7FFADFF85750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 185
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
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
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      System.Guid.NewGuid()
       mov       rdx,25F0B8F2600
       mov       rdx,[rdx]
       mov       r8,25F0B8E1568
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       call      System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFAE019D240]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01DFFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFADFC2DAC8]; System.Guid.NewGuid()
       mov       rdx,18ADF411660
       mov       rdx,[rdx]
       mov       r8,18ADF400528
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFADFC2D9A8]; System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 70
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp-40],rsp
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,28D
       mov       rdx,7FFADF0846B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,26792E83A50
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFADF41C678]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-28],rax
       mov       rdx,26792E83A40
       mov       rcx,[rdx]
       mov       [rbp-30],rcx
       xor       edx,edx
       mov       [rbp-20],edx
       cmp       byte ptr [rbp-20],0
       jne       short M01_L04
       lea       rdx,[rbp-20]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L05:
       xor       ebx,ebx
       jmp       short M01_L07
M01_L06:
       xor       ecx,ecx
       mov       edx,9
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       edx,eax
       mov       rax,[rbp-28]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       add       ebx,1
       jo        short M01_L03
M01_L07:
       cmp       ebx,esi
       jl        short M01_L06
       cmp       byte ptr [rbp-20],0
       je        short M01_L08
       mov       rcx,[rbp-30]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFADF07ABE8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
M01_L10:
       mov       rcx,rdi
       mov       rdx,[rbp-28]
       call      qword ptr [7FFADF41C680]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       byte ptr [rbp-20],0
       je        short M01_L11
       mov       rcx,[rbp-30]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,26792E83A50
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-28]
       call      qword ptr [7FFADF41C680]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 415
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,0A
       call      qword ptr [7FFADFF59390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01CD8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp-38],rsp
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFADFFE1318]
       mov       rdi,rax
       mov       rcx,2A381808590
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFADFFE1450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF8F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFADFD65750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,2A381806E60
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFAE0192D78]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-28],rax
       mov       rdx,2A381806E50
       mov       rcx,[rdx]
       mov       [rbp-30],rcx
       xor       edx,edx
       mov       [rbp-20],edx
       cmp       byte ptr [rbp-20],0
       jne       short M01_L05
       lea       rdx,[rbp-20]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L06
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      qword ptr [7FFADFBD9030]
       int       3
M01_L06:
       xor       edi,edi
       jmp       short M01_L08
M01_L07:
       xor       ecx,ecx
       mov       edx,9
       call      qword ptr [7FFADFF85750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       edx,eax
       mov       rax,[rbp-28]
       cmp       [rax],al
       mov       rcx,rax
       call      qword ptr [7FFAE0185A68]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       add       edi,1
       jo        short M01_L04
M01_L08:
       cmp       edi,esi
       jl        short M01_L07
       cmp       byte ptr [rbp-20],0
       je        short M01_L09
       mov       rcx,[rbp-30]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L09:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFADFDAD678]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFF81780]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       cmp       [rsi],sil
       mov       rcx,rsi
       mov       edx,2
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
M01_L11:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      qword ptr [7FFAE0192D80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+60]
       cmp       byte ptr [rbp-20],0
       je        short M01_L12
       mov       rcx,[rbp-30]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L12:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+60]
       mov       rcx,2A381806E60
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      qword ptr [7FFAE0192D80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 638
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePhoneNumberUSA()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
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
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       push      rdi
       push      rsi
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rcx,261B5E32EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFADF06FF88]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       rsi,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L11
       lea       rdx,[rax+10]
       mov       edi,[rax+8]
M01_L00:
       add       rsi,18
       mov       [rsi],rdx
       mov       [rsi+8],edi
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       mov       ecx,3
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L03
       test      rdi,rdi
       je        near ptr M01_L03
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L13
       mov       rcx,[rsp+38]
       mov       edx,[rsp+40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rdi+8]
       cmp       r8d,edx
       ja        near ptr M01_L03
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rdi+8]
       mov       [rsp+30],ecx
M01_L01:
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       mov       edx,[rsp+30]
       cmp       edx,ecx
       jae       near ptr M01_L12
       movsxd    rcx,edx
       mov       word ptr [rax+rcx*2],2D
       inc       edx
       mov       [rsp+30],edx
M01_L02:
       mov       ecx,3
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rsi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L07
       test      rsi,rsi
       je        near ptr M01_L07
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L13
       mov       rcx,[rsp+38]
       mov       edx,[rsp+40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        near ptr M01_L07
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L04
M01_L03:
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L01
M01_L04:
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L05:
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       mov       edx,[rsp+30]
       cmp       edx,ecx
       jae       near ptr M01_L14
       movsxd    rcx,edx
       mov       word ptr [rax+rcx*2],2D
       inc       edx
       mov       [rsp+30],edx
M01_L06:
       mov       ecx,4
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rsi,rax
       cmp       byte ptr [rsp+34],0
       jne       short M01_L10
       test      rsi,rsi
       je        short M01_L10
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L13
       mov       rcx,[rsp+38]
       mov       edx,[rsp+40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short M01_L10
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L08
M01_L07:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L05
M01_L08:
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L09:
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       short M01_L09
M01_L11:
       xor       edx,edx
       xor       edi,edi
       jmp       near ptr M01_L00
M01_L12:
       mov       rdx,261B5E33188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L02
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L14:
       mov       rdx,261B5E33188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
; Total bytes of code 632
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePhoneNumberUSA()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFADFF49408]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01BFFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       push      rdi
       push      rsi
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rcx,1BB9E801ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFADFDC1D68]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L09
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L00:
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       mov       ecx,3
       call      qword ptr [7FFADFF49390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rsi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L06
       test      rsi,rsi
       je        near ptr M01_L06
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L10
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L06
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFADFC099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L01:
       mov       ecx,[rsp+30]
       mov       rax,[rsp+38]
       mov       edx,[rsp+40]
       cmp       ecx,edx
       jae       near ptr M01_L11
       mov       edx,ecx
       mov       word ptr [rax+rdx*2],2D
       inc       ecx
       mov       [rsp+30],ecx
M01_L02:
       mov       ecx,3
       call      qword ptr [7FFADFF49390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L07
       test      rdi,rdi
       je        near ptr M01_L07
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L10
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L07
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFADFC099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rdi+8]
       mov       [rsp+30],ecx
M01_L03:
       mov       ecx,[rsp+30]
       mov       rax,[rsp+38]
       mov       edx,[rsp+40]
       cmp       ecx,edx
       jae       near ptr M01_L12
       mov       edx,ecx
       mov       word ptr [rax+rdx*2],2D
       inc       ecx
       mov       [rsp+30],ecx
M01_L04:
       mov       ecx,4
       call      qword ptr [7FFADFF49390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rsi,rax
       cmp       byte ptr [rsp+34],0
       jne       near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L08
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        near ptr M01_L10
       mov       rcx,[rsp+38]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        short M01_L08
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFADFC099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L05:
       lea       rcx,[rsp+20]
       call      qword ptr [7FFADFC3D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L06:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      qword ptr [7FFADFC3DA50]
       jmp       near ptr M01_L01
M01_L07:
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       call      qword ptr [7FFADFC3DA50]
       jmp       near ptr M01_L03
M01_L08:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      qword ptr [7FFADFC3DA50]
       jmp       short M01_L05
M01_L09:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FFADFD87498]
       int       3
M01_L11:
       mov       rdx,1BB9E802180
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFADFC3DAF8]
       jmp       near ptr M01_L02
M01_L12:
       mov       rdx,1BB9E802180
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFADFC3DAF8]
       jmp       near ptr M01_L04
; Total bytes of code 625
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       r8,29FCA181D38
       mov       r8,[r8]
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
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
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       test      edi,edi
       jle       short M01_L00
       cmp       edi,100
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       ecx,29F
       mov       rdx,7FFADF0746B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L04
       cmp       dword ptr [rcx+8],0
       je        short M01_L04
       xor       edx,edx
M01_L03:
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       short M01_L05
       mov       rcx,29FCA181D38
       mov       rcx,[rcx]
       jmp       short M01_L05
M01_L04:
       mov       edx,1
       jmp       short M01_L03
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,29F5A182EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFADF06FF88]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       rbp,[rsp+28]
       mov       [rsp+30],rax
       test      rax,rax
       je        near ptr M01_L12
       lea       r9,[rax+10]
       mov       r14d,[rax+8]
M01_L06:
       add       rbp,18
       mov       [rbp],r9
       mov       [rbp+8],r14d
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       byte ptr [rsp+3C],0
       mov       ecx,edi
       mov       edx,41
       mov       r8d,5A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r14,rax
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M01_L08
       test      r14,r14
       je        near ptr M01_L08
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M01_L13
       mov       rcx,[rsp+40]
       mov       edx,[rsp+48]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[r14+8]
       cmp       r8d,edx
       ja        short M01_L08
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+38]
       add       ecx,[r14+8]
       mov       [rsp+38],ecx
M01_L07:
       lea       rcx,[rsp+28]
       mov       edx,2E
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+3C],0
       jne       near ptr M01_L11
       test      rsi,rsi
       je        short M01_L11
       mov       r8d,[rsp+38]
       cmp       r8d,[rsp+48]
       ja        near ptr M01_L13
       mov       rcx,[rsp+40]
       mov       edx,[rsp+48]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short M01_L11
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rsp+28]
       mov       rdx,r14
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       short M01_L07
M01_L09:
       mov       ecx,[rsp+38]
       add       ecx,[rsi+8]
       mov       [rsp+38],ecx
M01_L10:
       lea       rcx,[rsp+28]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      System.IO.Path.Combine(System.String, System.String)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       lea       rcx,[rsp+28]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       short M01_L10
M01_L12:
       xor       r9d,r9d
       xor       r14d,r14d
       jmp       near ptr M01_L06
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 548
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       r8,20A5F411900
       mov       r8,[r8]
       mov       edx,0A
       call      qword ptr [7FFADFF69438]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01DF8B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       test      edi,edi
       jle       short M01_L00
       xor       eax,eax
       cmp       edi,100
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFADFFF1318]
       mov       rbp,rax
       mov       rcx,20A5F411908
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFADFFF1450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF9F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFF1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFF1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD4FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFADFBE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFADFFF1090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFADFFF1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFADFD75750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       test      edx,edx
       jne       near ptr M01_L05
       call      qword ptr [7FFADFFF1450]
       mov       r14,rax
       mov       ecx,2BD
       mov       rdx,7FFADFDE6320
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,32C
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,r15
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF9F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFF1078]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFADFFF1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD4FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,20A5F411900
       mov       rcx,[rcx]
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFADFBE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,20A5F401ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFADFDE1D68]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr M01_L11
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M01_L06:
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       xor       ecx,ecx
       mov       [rsp+40],ecx
       mov       byte ptr [rsp+44],0
       mov       ecx,edi
       mov       edx,41
       mov       r8d,5A
       call      qword ptr [7FFADFF69558]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbp,rax
       cmp       byte ptr [rsp+44],0
       jne       near ptr M01_L09
       test      rbp,rbp
       je        near ptr M01_L09
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M01_L12
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rbp+8],edx
       ja        near ptr M01_L09
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       add       r8,r8
       call      qword ptr [7FFADFC299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[rbp+8]
       mov       [rsp+40],ecx
M01_L07:
       lea       rcx,[rsp+30]
       mov       edx,2E
       call      qword ptr [7FFAE01DF8A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       byte ptr [rsp+44],0
       jne       near ptr M01_L10
       test      rsi,rsi
       je        near ptr M01_L10
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        near ptr M01_L12
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        short M01_L10
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFADFC299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[rsi+8]
       mov       [rsp+40],ecx
M01_L08:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFADFC5D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFADFE63180]; System.IO.Path.Combine(System.String, System.String)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L09:
       lea       rcx,[rsp+30]
       mov       rdx,rbp
       call      qword ptr [7FFADFC5DA50]
       jmp       near ptr M01_L07
M01_L10:
       lea       rcx,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFADFC5DA50]
       jmp       short M01_L08
M01_L11:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L06
M01_L12:
       call      qword ptr [7FFADFDA7498]
       int       3
; Total bytes of code 949
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRefPerson()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rdi
       push      rsi
       sub       rsp,0A8
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       mov       [rsp+0A0],rcx
       mov       rsi,rcx
       mov       edi,edx
       lea       rcx,[rsp+98]
       lea       rdx,[rsp+90]
       lea       r8,[rsp+88]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       lea       rdx,[rsp+68]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+60]
       mov       [rsp+28],rdx
       lea       rdx,[rsp+50]
       mov       [rsp+30],rdx
       lea       rdx,[rsp+80]
       lea       r8,[rsp+78]
       lea       r9,[rsp+70]
       mov       rcx,[rsp+98]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomPersonData(DotNetTips.Spargine.Tester.Data.Country, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.DateTimeOffset ByRef)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFADF20DFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+48],rax
       mov       rsi,[rsp+48]
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFADEDD0698
       call      qword ptr [7FFADEDD0698]
       mov       rsi,[rsp+48]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFADEDD06A0
       call      qword ptr [7FFADEDD06A0]
       mov       rsi,[rsp+48]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFADEDD06A8
       call      qword ptr [7FFADEDD06A8]
       mov       rcx,[rsp+48]
       vmovupd   xmm0,[rsp+50]
       vmovupd   [rsp+38],xmm0
       lea       rdx,[rsp+38]
       mov       r11,7FFADEDD06B0
       call      qword ptr [7FFADEDD06B0]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+68]
       mov       r11,7FFADEDD06B8
       call      qword ptr [7FFADEDD06B8]
       lea       rcx,[rsp+48]
       cmp       qword ptr [rsp+88],0
       je        short M01_L02
       mov       rdx,[rsp+88]
       mov       rdx,[rdx+18]
       jmp       short M01_L03
M01_L02:
       mov       rdx,147B3B83020
       mov       rdx,[rdx]
M01_L03:
       mov       rcx,[rcx]
       mov       r11,7FFADEDD06C0
       call      qword ptr [7FFADEDD06C0]
       mov       rdx,[rsp+98]
       mov       rdx,[rdx+58]
       mov       rcx,[rsp+48]
       mov       r11,7FFADEDD06C8
       call      qword ptr [7FFADEDD06C8]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+60]
       mov       r11,7FFADEDD06D0
       call      qword ptr [7FFADEDD06D0]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+80]
       mov       r11,7FFADEDD06D8
       call      qword ptr [7FFADEDD06D8]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+70]
       mov       r11,7FFADEDD06E0
       call      qword ptr [7FFADEDD06E0]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+78]
       mov       r11,7FFADEDD06E8
       call      qword ptr [7FFADEDD06E8]
       mov       rsi,[rsp+48]
       mov       rcx,[rsp+98]
       mov       rdx,[rsp+88]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFADEDD06F0
       call      qword ptr [7FFADEDD06F0]
       mov       rdx,[rsp+90]
       mov       rdx,[rdx+20]
       mov       rcx,[rsp+48]
       mov       r11,7FFADEDD06F8
       call      qword ptr [7FFADEDD06F8]
       mov       rax,[rsp+48]
       add       rsp,0A8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 673
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRefPerson()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       edx,19
       call      qword ptr [7FFADFF39720]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01AFBA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rdi
       push      rsi
       sub       rsp,0A8
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       mov       [rsp+0A0],rcx
       mov       rsi,rcx
       mov       edi,edx
       lea       rcx,[rsp+98]
       lea       rdx,[rsp+90]
       lea       r8,[rsp+88]
       call      qword ptr [7FFADFF39150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       lea       rdx,[rsp+68]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+60]
       mov       [rsp+28],rdx
       lea       rdx,[rsp+50]
       mov       [rsp+30],rdx
       lea       rdx,[rsp+80]
       lea       r8,[rsp+78]
       lea       r9,[rsp+70]
       mov       rcx,[rsp+98]
       call      qword ptr [7FFADFF39168]; DotNetTips.Spargine.Tester.RandomData.GetRandomPersonData(DotNetTips.Spargine.Tester.Data.Country, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.DateTimeOffset ByRef)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFADFF4FE98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      qword ptr [7FFADFEFBF90]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+48],rax
       mov       rsi,[rsp+48]
       call      qword ptr [7FFAE016B978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFADF970640
       call      qword ptr [r11]
       mov       rsi,[rsp+48]
       mov       ecx,edi
       call      qword ptr [7FFADFF39528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFADF970648
       call      qword ptr [r11]
       mov       rsi,[rsp+48]
       mov       ecx,edi
       call      qword ptr [7FFADFF39528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFADF970650
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       vmovupd   xmm0,[rsp+50]
       vmovupd   [rsp+38],xmm0
       lea       rdx,[rsp+38]
       mov       r11,7FFADF970658
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+68]
       mov       r11,7FFADF970660
       call      qword ptr [r11]
       lea       rcx,[rsp+48]
       cmp       qword ptr [rsp+88],0
       je        short M01_L02
       mov       rdx,[rsp+88]
       mov       rdx,[rdx+18]
       jmp       short M01_L03
M01_L02:
       mov       rdx,20501802028
       mov       rdx,[rdx]
M01_L03:
       mov       rcx,[rcx]
       mov       r11,7FFADF970668
       call      qword ptr [r11]
       mov       rdx,[rsp+98]
       mov       rdx,[rdx+58]
       mov       rcx,[rsp+48]
       mov       r11,7FFADF970670
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+60]
       mov       r11,7FFADF970678
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+80]
       mov       r11,7FFADF970680
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+70]
       mov       r11,7FFADF970688
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+78]
       mov       r11,7FFADF970690
       call      qword ptr [r11]
       mov       rsi,[rsp+48]
       mov       rcx,[rsp+98]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFADFF39138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFADF970698
       call      qword ptr [r11]
       mov       rdx,[rsp+90]
       mov       rdx,[rdx+20]
       mov       rcx,[rsp+48]
       mov       r11,7FFADF9706A0
       call      qword ptr [r11]
       mov       rax,[rsp+48]
       add       rsp,0A8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 641
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rcx,21967DF7E58
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      qword ptr [7FFADF3FC678]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       xor       edi,edi
       mov       ecx,1
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       short M01_L01
M01_L00:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       rdx,rax
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L03
       mov       ecx,1
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jg        short M01_L00
M01_L01:
       mov       rcx,[rbp-18]
       mov       ecx,[rcx+18]
       mov       rdx,[rbp-18]
       mov       rdx,[rdx+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L04
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],2F
       mov       rcx,[rbp-18]
       inc       dword ptr [rcx+18]
M01_L02:
       mov       rcx,[rbp-18]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       call      qword ptr [7FFADF05ABE8]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,2F
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFADF3FC680]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rdi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,21967DF7E58
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFADF3FC680]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 272
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFADFF59468]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01F18A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rcx,2B073806E60
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      qword ptr [7FFAE01958E8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       xor       edi,edi
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFADFF59348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       short M01_L02
M01_L00:
       call      qword ptr [7FFADFF594F8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       rdx,rax
       mov       rcx,[rbp-18]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M01_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-18]
       call      qword ptr [7FFADFDCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       add       edi,1
       jo        short M01_L04
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFADFF59348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jg        short M01_L00
M01_L02:
       mov       rcx,[rbp-18]
       mov       ecx,[rcx+18]
       mov       rdx,[rbp-18]
       mov       rdx,[rdx+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L05
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],2F
       mov       rcx,[rbp-18]
       inc       dword ptr [rcx+18]
M01_L03:
       mov       rcx,[rbp-18]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       call      qword ptr [7FFADFDAD678]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L06
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,[rbp-18]
       mov       edx,2F
       mov       r8d,1
       call      qword ptr [7FFADFDCB258]
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFAE01958F0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rdi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,2B073806E60
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFAE01958F0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,400
       call      DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,400
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,231
       mov       rdx,7FFADF0746B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rdx,2166FF71D40
       mov       rdx,[rdx]
       mov       ecx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(Int32, System.String)
       mov       rdi,rax
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.IO.File.WriteAllText(System.String, System.String)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 139
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,400
       call      qword ptr [7FFADFF59480]; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01CDD38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,400
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFADFFE1318]
       mov       rdi,rax
       mov       rdx,1B55E800D70
       mov       rcx,[rdx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L03
       call      qword ptr [7FFADFFE1450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDD7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF8F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFADFBD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFE1090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFADFFE1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFADFD65750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rdx,1B55E800D78
       mov       rdx,[rdx]
       mov       ecx,0A
       call      qword ptr [7FFADFF59420]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(Int32, System.String)
       mov       rdi,rax
       mov       ecx,esi
       call      qword ptr [7FFADFF59528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rsi,rax
       call      qword ptr [7FFADFEA9000]; System.IO.File.get_UTF8NoBOM()
       mov       rbx,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFADFEA9978]; System.IO.File.Validate(System.String, System.Text.Encoding)
       mov       rcx,rdi
       mov       r9,rbx
       mov       r8,rsi
       mov       edx,2
       call      qword ptr [7FFADFEA99A8]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.String, System.Text.Encoding)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 395
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrl()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       mov       rdi,rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rdx,rax
       mov       rcx,rdi
       call      System.String.Concat(System.String, System.String)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       push      rsi
       sub       rsp,20
       mov       rax,274A6749CD0
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Concat(System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rcx,274C6747E58
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      qword ptr [7FFADF3FC678]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       xor       edi,edi
       mov       ecx,1
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       short M02_L01
M02_L00:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       rdx,rax
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M02_L03
       mov       ecx,1
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jg        short M02_L00
M02_L01:
       mov       rcx,[rbp-18]
       mov       ecx,[rcx+18]
       mov       rdx,[rbp-18]
       mov       rdx,[rdx+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L04
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],2F
       mov       rcx,[rbp-18]
       inc       dword ptr [rcx+18]
M02_L02:
       mov       rcx,[rbp-18]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       call      qword ptr [7FFADF05ABE8]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M02_L05
M02_L03:
       call      CORINFO_HELP_OVERFLOW
M02_L04:
       mov       rcx,[rbp-18]
       mov       edx,2F
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L02
M02_L05:
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFADF3FC680]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rdi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,274C6747E58
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFADF3FC680]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 272
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M03_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M03_L00
       test      rsi,rsi
       je        near ptr M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M03_L02
       jmp       short M03_L01
M03_L00:
       test      rsi,rsi
       je        near ptr M03_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M03_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       mov       ebx,[rdi+8]
       mov       r14d,ebx
       mov       ebp,[rsi+8]
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M03_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M03_L04
       lea       r8,[r15+0C]
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,274C6743020
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 303
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrl()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       call      qword ptr [7FFADFF594C8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,260AEC00D70
       mov       rcx,[rcx]
       call      qword ptr [7FFADFBD1C60]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       call      qword ptr [7FFADFF59468]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFADFBD1C60]; System.String.Concat(System.String, System.String)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01F1330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFADFF59570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,260A2C06E48
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdi,[rcx+18]
M01_L00:
       mov       rdx,260AEC00D78
       mov       rbx,[rdx]
       mov       rdx,260A2C02188
       mov       rbp,[rdx]
       mov       r14d,[rdi+8]
       mov       edx,r14d
       sub       edx,1
       jo        short M01_L02
       xor       ecx,ecx
       call      qword ptr [7FFADFF59348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,r14d
       jae       short M01_L03
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFADFBD1C90]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      qword ptr [7FFADFF83F18]
       mov       rdi,rax
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 172
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFADFC199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFADFC199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,260A2C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFD61C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFD61C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rcx,260A2C06E60
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      qword ptr [7FFAE01958E8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       xor       edi,edi
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFADFF59348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       call      qword ptr [7FFADFF594F8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       rdx,rax
       mov       rcx,[rbp-18]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M03_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-18]
       call      qword ptr [7FFADFDCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M03_L01:
       add       edi,1
       jo        short M03_L04
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFADFF59348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jg        short M03_L00
M03_L02:
       mov       rcx,[rbp-18]
       mov       ecx,[rcx+18]
       mov       rdx,[rbp-18]
       mov       rdx,[rdx+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L05
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],2F
       mov       rcx,[rbp-18]
       inc       dword ptr [rcx+18]
M03_L03:
       mov       rcx,[rbp-18]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       call      qword ptr [7FFADFDAD678]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M03_L06
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       mov       rcx,[rbp-18]
       mov       edx,2F
       mov       r8d,1
       call      qword ptr [7FFADFDCB258]
       jmp       short M03_L03
M03_L06:
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFAE01958F0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rdi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,260A2C06E60
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFAE01958F0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostName()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
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
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       push      rsi
       sub       rsp,20
       mov       rax,25B2C371D38
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Concat(System.String, System.String)
; Total bytes of code 39
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostName()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFADFF594C8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,1952F400D70
       mov       rcx,[rcx]
       call      qword ptr [7FFADFBD1C60]; System.String.Concat(System.String, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01CDBA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFADFF59570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,19525402A40
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdi,[rcx+18]
M01_L00:
       mov       rdx,1952F400D78
       mov       rbx,[rdx]
       mov       rdx,19529402188
       mov       rbp,[rdx]
       mov       r14d,[rdi+8]
       mov       edx,r14d
       sub       edx,1
       jo        short M01_L02
       xor       ecx,ecx
       call      qword ptr [7FFADFF59348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,r14d
       jae       short M01_L03
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFADFBD1C90]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      qword ptr [7FFADFF83F18]
       mov       rdi,rax
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 172
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFADFC199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFADFC199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,19529402028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFD61C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFD61C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoProtocol()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
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
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,258EDC73A38
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdi,[rcx+18]
M01_L00:
       mov       rdx,2597DC71D38
       mov       rbx,[rdx]
       mov       rdx,2592DC73120
       mov       rbp,[rdx]
       mov       r14d,[rdi+8]
       mov       edx,r14d
       sub       edx,1
       jo        short M01_L02
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,r14d
       jae       short M01_L03
       movsxd    r9,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 168
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoProtocol()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFADFF494C8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01BD330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFADFF49570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,2CA30C06E48
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdi,[rcx+18]
M01_L00:
       mov       rdx,2CA40C00D70
       mov       rbx,[rdx]
       mov       rdx,2CA30C02188
       mov       rbp,[rdx]
       mov       r14d,[rdi+8]
       mov       edx,r14d
       sub       edx,1
       jo        short M01_L02
       xor       ecx,ecx
       call      qword ptr [7FFADFF49348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,r14d
       jae       short M01_L03
       mov       r9d,eax
       mov       r9,[rdi+r9*8+10]
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFADFBC1C90]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      qword ptr [7FFADFF73F18]
       mov       rdi,rax
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 172
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,1FD18A33A38
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rdi,[rcx+18]
M00_L00:
       mov       ebx,[rdi+8]
       mov       edx,ebx
       sub       edx,1
       jo        short M00_L02
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,ebx
       jae       short M00_L03
       movsxd    rcx,eax
       mov       rcx,[rdi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 132
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       edi,edx
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       mov       edx,esi
       add       edx,1
       jo        short M01_L07
       cmp       edi,edx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,edx
M01_L03:
       mov       rdx,1FD18A33A40
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L04
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L04:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 183
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
System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,1C154006E48
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rdi,[rcx+18]
M00_L00:
       mov       ebx,[rdi+8]
       mov       edx,ebx
       sub       edx,1
       jo        short M00_L02
       xor       ecx,ecx
       call      qword ptr [7FFADFF59348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,ebx
       jae       short M00_L03
       mov       ecx,eax
       mov       rcx,[rdi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01CD8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FFADFF83F18]
       mov       rdi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       edi,edx
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       mov       edx,esi
       add       edx,1
       jo        short M01_L07
       cmp       edi,edx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,edx
M01_L03:
       mov       rdx,1C154006E50
       mov       rcx,[rdx]
       mov       [rbp-20],rcx
       xor       edx,edx
       mov       [rbp-18],edx
       cmp       byte ptr [rbp-18],0
       jne       short M01_L04
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFADFBD9030]
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      qword ptr [7FFADFF85750]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       esi,eax
       cmp       byte ptr [rbp-18],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       mov       eax,esi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M01_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 185
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlPart()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
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
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       push      rsi
       sub       rsp,20
       mov       rcx,28299539CD0
       mov       rsi,[rcx]
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Concat(System.String, System.String)
; Total bytes of code 61
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlPart()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFADFF694F8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01DF330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       sub       rsp,28
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      qword ptr [7FFADFF69570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdx,rax
       mov       rcx,1F501C12918
       mov       rcx,[rcx]
       add       rsp,28
       jmp       qword ptr [7FFADFBE1C60]; System.String.Concat(System.String, System.String)
; Total bytes of code 58
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateValPerson()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,100
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       lea       rcx,[rsp+90]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       add       rsp,100
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 139
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,180
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rsp+178]
       lea       rdx,[rsp+170]
       lea       r8,[rsp+168]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       lea       rdx,[rsp+148]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+140]
       mov       [rsp+28],rdx
       lea       rdx,[rsp+130]
       mov       [rsp+30],rdx
       lea       rdx,[rsp+160]
       lea       r8,[rsp+158]
       lea       r9,[rsp+150]
       mov       rcx,[rsp+178]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomPersonData(DotNetTips.Spargine.Tester.Data.Country, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.DateTimeOffset ByRef)
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Id(System.String)
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Address1(System.String)
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Address2(System.String)
       lea       rcx,[rsp+50]
       vmovupd   xmm0,[rsp+130]
       vmovupd   [rsp+40],xmm0
       lea       rdx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_BornOn(System.DateTimeOffset)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+148]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_CellPhone(System.String)
       lea       rcx,[rsp+50]
       cmp       qword ptr [rsp+168],0
       je        short M01_L01
       mov       rdx,[rsp+168]
       mov       rdx,[rdx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,2270FCA3020
       mov       rdx,[rdx]
M01_L02:
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_City(System.String)
       mov       rdx,[rsp+178]
       mov       rdx,[rdx+58]
       lea       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Country(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+140]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Email(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+160]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_FirstName(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+150]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_HomePhone(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+158]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_LastName(System.String)
       mov       rcx,[rsp+178]
       mov       rdx,[rsp+168]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_PostalCode(System.String)
       mov       rdx,[rsp+170]
       mov       rdx,[rdx+20]
       lea       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_State(System.String)
       lea       rdi,[rsp+0C0]
       lea       rsi,[rsp+50]
       mov       ecx,0E
       rep movsq
       mov       rdi,rbx
       lea       rsi,[rsp+0C0]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,rbx
       add       rsp,180
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 587
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateValPerson()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,100
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       lea       rcx,[rsp+90]
       mov       edx,19
       call      qword ptr [7FFADFF399F0]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE01AF888]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       add       rsp,100
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rsp+108]
       lea       rdx,[rsp+100]
       lea       r8,[rsp+0F8]
       call      qword ptr [7FFADFF39150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       lea       rdx,[rsp+0D8]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+0D0]
       mov       [rsp+28],rdx
       lea       rdx,[rsp+0C0]
       mov       [rsp+30],rdx
       lea       rdx,[rsp+0F0]
       lea       r8,[rsp+0E8]
       lea       r9,[rsp+0E0]
       mov       rcx,[rsp+108]
       call      qword ptr [7FFADFF39168]; DotNetTips.Spargine.Tester.RandomData.GetRandomPersonData(DotNetTips.Spargine.Tester.Data.Country, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.DateTimeOffset ByRef)
       call      qword ptr [7FFAE016B978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFADFDC5510]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Id(System.String)
       mov       ecx,esi
       call      qword ptr [7FFADFF39528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFADFDC5198]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Address1(System.String)
       mov       ecx,esi
       call      qword ptr [7FFADFF39528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFADFDC51F8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Address2(System.String)
       vmovupd   xmm0,[rsp+0C0]
       vmovupd   [rsp+40],xmm0
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFADFDC5270]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_BornOn(System.DateTimeOffset)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0D8]
       call      qword ptr [7FFADFDC52D0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_CellPhone(System.String)
       lea       rcx,[rsp+50]
       cmp       qword ptr [rsp+0F8],0
       je        short M01_L01
       mov       rdx,[rsp+0F8]
       mov       rdx,[rdx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,14247402028
       mov       rdx,[rdx]
M01_L02:
       call      qword ptr [7FFADFDC5330]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_City(System.String)
       mov       rdx,[rsp+108]
       mov       rdx,[rdx+58]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFADFDC5390]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Country(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0D0]
       call      qword ptr [7FFADFDC53F0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Email(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0F0]
       call      qword ptr [7FFADFDC5450]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_FirstName(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0E0]
       call      qword ptr [7FFADFDC54B0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_HomePhone(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0E8]
       call      qword ptr [7FFADFDC5570]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_LastName(System.String)
       mov       rcx,[rsp+108]
       mov       rdx,[rsp+0F8]
       call      qword ptr [7FFADFF39138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFADFDC55D0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_PostalCode(System.String)
       mov       rdx,[rsp+100]
       mov       rdx,[rdx+20]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFADFDC5630]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_State(System.String)
       mov       rdi,rbx
       lea       rsi,[rsp+50]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 576
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      qword ptr [7FFAE01AF8B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 19
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       push      rsi
       sub       rsp,20
       test      ecx,ecx
       jle       short M01_L00
       cmp       ecx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,28D
       mov       rdx,7FFADF0846B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       edx,41
       mov       r8d,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 92
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,0A
       call      qword ptr [7FFADFF79528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0211BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       test      ecx,ecx
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFAE0001318]
       mov       rsi,rax
       mov       rcx,2214C808590
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFAE0001450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDF7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDF7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFFAF7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAE0001078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAE0001510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD5FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFADFBF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAE0001090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAE0001510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD85750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,41
       mov       r8d,7A
       call      qword ptr [7FFADFF79558]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 313
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWords()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,5
       mov       r8d,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableList`1[[System.String, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableList`1<System.String> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFADF0546B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       test      edi,edi
       jle       short M01_L03
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       ecx,2F1
       mov       rdx,7FFADF0546B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L05:
       test      ebx,ebx
       jle       short M01_L06
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L07
M01_L06:
       xor       eax,eax
M01_L07:
       test      eax,eax
       jne       short M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,305
       mov       rdx,7FFADF0546B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L08:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L12
M01_L09:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L10
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L11
M01_L10:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L11:
       add       r14d,1
       jo        short M01_L14
       cmp       r14d,esi
       jl        short M01_L09
M01_L12:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFADF3645E0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L13
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L13:
       mov       rcx,7FFADF1E1528
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,29423469260
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 411
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWords()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,5
       mov       r8d,0A
       call      qword ptr [7FFADFF69588]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableList`1[[System.String, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableList`1<System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAE02073D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFADFFF1318]
       mov       rbp,rax
       mov       rax,20A94800188
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFADFFF1450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF9F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFF1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFF1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD4FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFADFBE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFADFFF1090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFADFFF1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFADFD75750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       test      edi,edi
       jle       short M01_L04
       mov       eax,1
       jmp       short M01_L05
M01_L04:
       xor       eax,eax
M01_L05:
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFADFFF1318]
       mov       r14,rax
       mov       rax,20A94800938
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FFADFFF1450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF9F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFF1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFF1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD4FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       edx,3
       call      qword ptr [7FFADFBE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFADFFF1090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFADFFF1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFADFD75750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L07:
       test      ebx,ebx
       jle       short M01_L08
       mov       eax,1
       jmp       short M01_L09
M01_L08:
       xor       eax,eax
M01_L09:
       test      eax,eax
       jne       near ptr M01_L11
       call      qword ptr [7FFADFFF1318]
       mov       r15,rax
       mov       rcx,20A94800940
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFADFFF1450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFADFDE7070
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFADFF9F7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADFFF1078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADFFF1510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFADFD4FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       edx,3
       call      qword ptr [7FFADFBE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFADFFF1090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFADFFF1510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFADFD75750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFADFC57918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L15
M01_L12:
       mov       ecx,edi
       mov       edx,ebx
       call      qword ptr [7FFADFF69540]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L13
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFADFC57A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L14:
       add       r14d,1
       jo        near ptr M01_L23
       cmp       r14d,esi
       jl        short M01_L12
M01_L15:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFADFBA11F0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L16
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      qword ptr [7FFADFC57960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L16:
       mov       rdx,20A8C807DD8
       mov       r15,[rdx]
       mov       rdx,[r15+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L17
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableList`1[[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFAE02018E8]; System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].CreateRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L22
M01_L17:
       mov       rsi,[r15+8]
       cmp       [rsi],sil
       mov       rcx,[rsi+18]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0203978]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAE0203DE0]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0203D98]
       mov       rsi,rax
       cmp       rsi,[r15+8]
       je        short M01_L21
       cmp       qword ptr [rsi+10],0
       je        short M01_L20
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableList`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       cmp       byte ptr [rsi+24],0
       je        short M01_L19
M01_L18:
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       short M01_L22
M01_L19:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0203C78]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0203C78]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rsi+24],1
       jmp       short M01_L18
M01_L20:
       mov       rax,20A8C807DD8
       mov       rax,[rax]
       jmp       short M01_L22
M01_L21:
       mov       rax,r15
M01_L22:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1228
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

