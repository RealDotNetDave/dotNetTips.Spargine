## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFB913DE4B8]
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
       mov       rcx,1AA74341568
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       vmovsd    xmm0,qword ptr [7FFB913DE6C0]
       vmovsd    qword ptr [rdi+8],xmm0
       xor       ecx,ecx
       mov       r8,1AA74341380
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
       vmulsd    xmm0,xmm6,qword ptr [7FFB913DE6C8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1AA74347FE8
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
       mov       rcx,7FFB910D51E0
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
       mov       rax,1AA74342F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rsi
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFB2E4F4188]
       call      qword ptr [7FFB2E8CB1F8]; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB51DE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,256A4400528
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E8F7318]; DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rdi+8],1
       mov       [rbp-40],rdi
       lea       rcx,[rbp-40]
       vmovsd    xmm6,qword ptr [rbp+10]
       mov       [rbp-50],rcx
       mov       dword ptr [rbp-48],1
       mov       rcx,rsi
       lea       r8,[rbp-50]
       call      qword ptr [7FFB2E531DC8]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       xor       eax,eax
       vucomisd  xmm6,qword ptr [7FFB2E4F4378]
       setae     al
       test      eax,eax
       jne       short M01_L00
       vxorps    xmm6,xmm6,xmm6
M01_L00:
       vmulsd    xmm0,xmm6,qword ptr [7FFB2E4F4380]
       call      qword ptr [7FFB2E7C9D38]; System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,256A4404FF8
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
       call      qword ptr [7FFB2E539030]
       int       3
M01_L02:
       mov       rcx,7FFB2E736AE8
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
       call      qword ptr [7FFB2E5799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,256A4401F70
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,23B7F835FF0
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       ecx,41
       mov       edx,7A
       call      qword ptr [7FFB2E8BB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       ecx,eax
       mov       [rsp+28],cx
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB51888]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Char, System.Private.CoreLib]](Char ByRef)
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
       mov       rdx,1EB48406FF0
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
       call      qword ptr [7FFB2E539030]
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      qword ptr [7FFB2E8E7870]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       call      qword ptr [7FFB2E8DBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB4FFC0]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFB2E8DB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rsp+20],eax
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFB2E8DB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rsp+24],eax
       mov       rax,[rsp+20]
       add       rsp,28
       ret
; Total bytes of code 61
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      qword ptr [7FFB2EB71000]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 19
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      rsi
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       rsi,rcx
       mov       rdx,25A24351058
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
       mov       rdx,7FFB910A4B48
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      rsi
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       rsi,rcx
       mov       rdx,21103800060
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
       call      qword ptr [7FFB2E8CB2A0]; DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       vmovupd   xmm0,[rsp+50]
       vmovupd   [rsp+40],xmm0
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB3F7E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
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
       call      qword ptr [7FFB2E953360]
       mov       rbp,rax
       mov       rcx,21101801DB0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E953498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9517F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E953078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E953090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6E5750]
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
       call      qword ptr [7FFB2EB3F5E8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
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
       call      qword ptr [7FFB2EB3F5E8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ecx,[rsp+88]
       mov       eax,[rsp+8C]
       mov       rdx,[rsp+90]
       mov       [rsp+28],ecx
       mov       [rsp+2C],eax
       mov       [rsp+30],rdx
       lea       rcx,[rsp+28]
       call      qword ptr [7FFB2E5BB960]; System.Decimal.ToInt32(System.Decimal)
       mov       esi,eax
       vmovupd   xmm0,[rdi]
       vmovupd   [rsp+68],xmm0
       mov       [rsp+58],ebp
       mov       [rsp+5C],r14d
       mov       [rsp+60],r15
       lea       rcx,[rsp+68]
       lea       rdx,[rsp+58]
       call      qword ptr [7FFB2EB3F5E8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       mov       ecx,[rsp+68]
       mov       eax,[rsp+6C]
       mov       rdx,[rsp+70]
       mov       [rsp+28],ecx
       mov       [rsp+2C],eax
       mov       [rsp+30],rdx
       lea       rcx,[rsp+28]
       call      qword ptr [7FFB2E5BB960]; System.Decimal.ToInt32(System.Decimal)
       mov       edx,eax
       mov       ecx,esi
       call      qword ptr [7FFB2E8CB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFB2EB3F678]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
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
       call      qword ptr [7FFB2EB3F810]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 19
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,237BF0F5FE8
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
       mov       rdx,237BF0F5FF0
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
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       jne       short M03_L04
       jne       short M03_L04
       jne       short M03_L04
       jne       short M03_L04
       jne       short M03_L04
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
M03_L02:
       add       rsp,30
M03_L02:
       add       rsp,30
M03_L02:
       add       rsp,30
M03_L02:
       add       rsp,30
M03_L02:
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
M03_L03:
       mov       rcx,rsi
M03_L03:
       mov       rcx,rsi
M03_L03:
       mov       rcx,rsi
M03_L03:
       mov       rcx,rsi
M03_L03:
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8318]
       call      qword ptr [7FFB98BD8318]
       call      qword ptr [7FFB98BD8318]
       call      qword ptr [7FFB98BD8318]
       call      qword ptr [7FFB98BD8318]
       jmp       short M03_L02
       jmp       short M03_L02
       jmp       short M03_L02
       jmp       short M03_L02
       jmp       short M03_L02
M03_L04:
       cmp       ebx,8
M03_L04:
       cmp       ebx,8
M03_L04:
       cmp       ebx,8
M03_L04:
       cmp       ebx,8
M03_L04:
       cmp       ebx,8
       ja        short M03_L05
       ja        short M03_L05
       ja        short M03_L05
       ja        short M03_L05
       ja        short M03_L05
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       lea       rdx,[7FFB98A91B08]
       lea       rdx,[7FFB98A91B08]
       lea       rdx,[7FFB98A91B08]
       lea       rdx,[7FFB98A91B08]
       lea       rdx,[7FFB98A91B08]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFB98BD82F8]
       call      qword ptr [7FFB98BD82F8]
       call      qword ptr [7FFB98BD82F8]
       call      qword ptr [7FFB98BD82F8]
       call      qword ptr [7FFB98BD82F8]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M03_L06
       je        short M03_L06
       je        short M03_L06
       je        short M03_L06
       je        short M03_L06
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
M03_L05:
       mov       rcx,[rdi+8]
M03_L05:
       mov       rcx,[rdi+8]
M03_L05:
       mov       rcx,[rdi+8]
M03_L05:
       mov       rcx,[rdi+8]
M03_L05:
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFB98BD1BA0]
       call      qword ptr [7FFB98BD1BA0]
       call      qword ptr [7FFB98BD1BA0]
       call      qword ptr [7FFB98BD1BA0]
       call      qword ptr [7FFB98BD1BA0]
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB98BD82F0]
       call      qword ptr [7FFB98BD82F0]
       call      qword ptr [7FFB98BD82F0]
       call      qword ptr [7FFB98BD82F0]
       call      qword ptr [7FFB98BD82F0]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       call      qword ptr [7FFB98BC3770]
       call      qword ptr [7FFB98BC3770]
       call      qword ptr [7FFB98BC3770]
       call      qword ptr [7FFB98BC3770]
       call      qword ptr [7FFB98BC3770]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFB98BDAF68]
       call      qword ptr [7FFB98BDAF68]
       call      qword ptr [7FFB98BDAF68]
       call      qword ptr [7FFB98BDAF68]
       call      qword ptr [7FFB98BDAF68]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
M03_L06:
       mov       rcx,rsi
M03_L06:
       mov       rcx,rsi
M03_L06:
       mov       rcx,rsi
M03_L06:
       mov       rcx,rsi
M03_L06:
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
; Total bytes of code 1325
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,2A44FC06FE8
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
       call      qword ptr [7FFB2E8DB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,ebx
       jae       short M00_L03
       mov       ecx,eax
       mov       rcx,[rdi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB4FBA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FFB2E861A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rdx,2A44FC06FF0
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
       call      qword ptr [7FFB2E559030]
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      qword ptr [7FFB2E907870]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
       jne       short M03_L02
       jne       short M03_L02
       jne       short M03_L02
       jne       short M03_L02
       jne       short M03_L02
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
M03_L02:
       mov       rcx,rsi
M03_L02:
       mov       rcx,rsi
M03_L02:
       mov       rcx,rsi
M03_L02:
       mov       rcx,rsi
M03_L02:
       mov       rcx,rsi
       lea       rax,[7FFB8D0E4B30]
       lea       rax,[7FFB8D0E4B30]
       lea       rax,[7FFB8D0E4B30]
       lea       rax,[7FFB8D0E4B30]
       lea       rax,[7FFB8D0E4B30]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M03_L03:
       cmp       ebx,8
M03_L03:
       cmp       ebx,8
M03_L03:
       cmp       ebx,8
M03_L03:
       cmp       ebx,8
M03_L03:
       cmp       ebx,8
       ja        short M03_L04
       ja        short M03_L04
       ja        short M03_L04
       ja        short M03_L04
       ja        short M03_L04
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       lea       rdx,[7FFB8CF83B48]
       lea       rdx,[7FFB8CF83B48]
       lea       rdx,[7FFB8CF83B48]
       lea       rdx,[7FFB8CF83B48]
       lea       rdx,[7FFB8CF83B48]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFB8D0E4AF8]
       call      qword ptr [7FFB8D0E4AF8]
       call      qword ptr [7FFB8D0E4AF8]
       call      qword ptr [7FFB8D0E4AF8]
       call      qword ptr [7FFB8D0E4AF8]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M03_L05
       je        short M03_L05
       je        short M03_L05
       je        short M03_L05
       je        short M03_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
M03_L04:
       mov       rcx,[rdi+8]
M03_L04:
       mov       rcx,[rdi+8]
M03_L04:
       mov       rcx,[rdi+8]
M03_L04:
       mov       rcx,[rdi+8]
M03_L04:
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8D0DCB48]
       call      qword ptr [7FFB8D0DCB48]
       call      qword ptr [7FFB8D0DCB48]
       call      qword ptr [7FFB8D0DCB48]
       call      qword ptr [7FFB8D0DCB48]
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4AF0]
       call      qword ptr [7FFB8D0E4AF0]
       call      qword ptr [7FFB8D0E4AF0]
       call      qword ptr [7FFB8D0E4AF0]
       call      qword ptr [7FFB8D0E4AF0]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       call      qword ptr [7FFB8D0CBCE0]
       call      qword ptr [7FFB8D0CBCE0]
       call      qword ptr [7FFB8D0CBCE0]
       call      qword ptr [7FFB8D0CBCE0]
       call      qword ptr [7FFB8D0CBCE0]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFB8D0E81B0]
       call      qword ptr [7FFB8D0E81B0]
       call      qword ptr [7FFB8D0E81B0]
       call      qword ptr [7FFB8D0E81B0]
       call      qword ptr [7FFB8D0E81B0]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
M03_L05:
       mov       rcx,rsi
M03_L05:
       mov       rcx,rsi
M03_L05:
       mov       rcx,rsi
M03_L05:
       mov       rcx,rsi
M03_L05:
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
; Total bytes of code 1385
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,185E4502EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB910C0420]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       mov       rcx,185E4507FE0
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
       mov       rdx,185F45018F0
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L02
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       mov       rdx,185E4503120
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEmailAddress()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFB2E8AB2D0]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB1FFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,278C6801ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB2E721EC0]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFB2E8AB570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
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
       call      qword ptr [7FFB2E5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB2E8AB570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
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
       call      qword ptr [7FFB2E5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,278C2802BE0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L07
       mov       rsi,[rcx+18]
M01_L05:
       mov       edx,[rsi+8]
       sub       edx,1
       jo        near ptr M01_L11
       xor       ecx,ecx
       call      qword ptr [7FFB2E8AB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFB2E5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L06:
       lea       rcx,[rsp+20]
       call      qword ptr [7FFB2E59D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L07:
       call      qword ptr [7FFB2E831B40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L08:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      qword ptr [7FFB2E59DA50]
       jmp       near ptr M01_L01
M01_L09:
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       call      qword ptr [7FFB2E59DA50]
       jmp       near ptr M01_L03
M01_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      qword ptr [7FFB2E59DA50]
       jmp       short M01_L06
M01_L11:
       call      CORINFO_HELP_OVERFLOW
M01_L12:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L00
M01_L13:
       call      qword ptr [7FFB2E6E7498]
       int       3
M01_L14:
       mov       rdx,278BE800950
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFB2E59DAF8]
       jmp       near ptr M01_L02
M01_L15:
       mov       rdx,278C6802188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFB2E59DAF8]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFile()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,1B2A0F11D60
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
       mov       rcx,1B240F15440
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
       mov       rcx,1B240F15430
       mov       rsi,[rcx]
       jmp       short M01_L18
M01_L17:
       mov       rcx,1B240F15438
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
       mov       rax,1B260F13020
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
       mov       rdx,7FFB910C4B48
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
       mov       rdx,7FFB910C4B48
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rcx,1EF77400D98
       mov       rbp,[rcx]
       add       rbp,0C
       mov       rcx,rbp
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],0D
       lea       rcx,[rsp+40]
       call      qword ptr [7FFB2E793510]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,1EF67408870
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
       call      qword ptr [7FFB2E511CC0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
M00_L01:
       mov       edx,400
       call      qword ptr [7FFB2E89B2E8]; DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       mov       [rsp+50],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+50]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB0FC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E511CA8]
       mov       rcx,rax
       jmp       short M00_L01
M00_L05:
       mov       rcx,1EF77400D98
       mov       rcx,[rcx]
       jmp       near ptr M00_L01
M00_L06:
       mov       rcx,1EF77400D98
       mov       rcx,[rcx]
       jmp       near ptr M00_L01
M00_L07:
       mov       ecx,1A9FE
       mov       rdx,7FFB2E2C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFB2E6DD960]
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
       call      qword ptr [7FFB2E5599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB2E5599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB2E5599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EF67402028
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
       call      qword ptr [7FFB2E6D74B0]
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
       call      qword ptr [7FFB2E923498]
       mov       rsi,rax
       mov       ecx,21F
       mov       rdx,7FFB2E716478
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9217F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E923078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E923558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFB2E513510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFB2E923360]
       mov       rdi,rax
       mov       rcx,1EF77400DA8
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M03_L05
       call      qword ptr [7FFB2E923498]
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9217F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E923078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E923558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L05:
       mov       edx,3
       call      qword ptr [7FFB2E513510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E923090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E923558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6B5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       mov       rcx,rsi
       call      qword ptr [7FFB2E89B1C8]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFB910C4B48
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
       mov       rdx,7FFB910C4B48
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
       mov       rdx,7FFB910C4B48
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
       mov       r8,1F1D9601D60
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
       vmulsd    xmm0,xmm0,qword ptr [7FFB913BEF60]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2E8DB318]; DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB73678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E963498]
       mov       rdi,rax
       mov       ecx,283
       mov       rdx,7FFB2E756478
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9617F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E963078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E963558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E71D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFB2E553510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFB2E963360]
       mov       rbp,rax
       mov       rax,24EA9C001B8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFB2E963498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9617F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E963078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E963558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E71D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      qword ptr [7FFB2E553510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E963090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E963558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6F5750]
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
       call      qword ptr [7FFB2E963360]
       mov       r14,rax
       mov       rcx,24EB9C00D98
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L09
       call      qword ptr [7FFB2E963498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9617F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E963078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E963558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E71D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       mov       edx,3
       call      qword ptr [7FFB2E553510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E963090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2E963558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rdi
       call      qword ptr [7FFB2E8D1798]; System.IO.Directory.CreateDirectory(System.String)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFB2E5C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L14
M01_L11:
       mov       r8,24EB9C00DA0
       mov       r8,[r8]
       mov       rcx,rdi
       mov       edx,0A
       call      qword ptr [7FFB2E8DB438]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       r15,rax
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFB2E8DB1C8]; DotNetTips.Spargine.Tester.RandomData.CreateFile(System.String, Int32)
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
       call      qword ptr [7FFB2E5C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L13:
       add       r14d,1
       jo        short M01_L16
       cmp       r14d,esi
       jl        short M01_L11
M01_L14:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2E5192B8]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L15
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      qword ptr [7FFB2E5C7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,21A1C2A7FE8
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFB2E8DB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB73318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
       mov       rdx,25903006FF0
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
       call      qword ptr [7FFB2E559030]
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      qword ptr [7FFB2E907870]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1BF48471A98
       mov       rdx,[rdx]
       mov       r8,1BEE8471568
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFB2EAEBDF8]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB2F8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E57DAC8]; System.Guid.NewGuid()
       mov       rdx,1E23DC01B10
       mov       rdx,[rdx]
       mov       r8,1E23BC00528
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFB2E57D9A8]; System.Guid.ToString(System.String, System.IFormatProvider)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,27EA3FD6000
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFB9143F508]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-28],rax
       mov       rdx,27EA3FD5FF0
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
       call      qword ptr [7FFB9109AF70]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFB9143F510]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,27EA3FD6000
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB9143F510]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,0A
       call      qword ptr [7FFB2E8CB390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB3DFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E953360]
       mov       rdi,rax
       mov       rcx,20AA3408590
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E953498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9517F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E953078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E953090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,20AA3407000
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFB2EAF2D40]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-28],rax
       mov       rdx,20AA3406FF0
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
       call      qword ptr [7FFB2E549030]
       int       3
M01_L06:
       xor       edi,edi
       jmp       short M01_L08
M01_L07:
       xor       ecx,ecx
       mov       edx,9
       call      qword ptr [7FFB2E8F7870]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       edx,eax
       mov       rax,[rbp-28]
       cmp       [rax],al
       mov       rcx,rax
       call      qword ptr [7FFB2EB05720]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FFB2E72D7D0]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8F3DF8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       cmp       [rsi],sil
       mov       rcx,rsi
       mov       edx,2
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
M01_L11:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB2EAF2D48]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,20AA3407000
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB2EAF2D48]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,26943882EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB910B0420]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdx,26943883188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L02
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L14:
       mov       rdx,26943883188
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePhoneNumberUSA()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFB2E8DB408]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB71330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,1CEB3C01ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB2E751EC0]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFB2E8DB390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
       call      qword ptr [7FFB2E5999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB2E8DB390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
       call      qword ptr [7FFB2E5999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB2E8DB390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
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
       call      qword ptr [7FFB2E5999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+30]
       add       ecx,[rsi+8]
       mov       [rsp+30],ecx
M01_L05:
       lea       rcx,[rsp+20]
       call      qword ptr [7FFB2E5CD930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M01_L06:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      qword ptr [7FFB2E5CDA50]
       jmp       near ptr M01_L01
M01_L07:
       lea       rcx,[rsp+20]
       mov       rdx,rdi
       call      qword ptr [7FFB2E5CDA50]
       jmp       near ptr M01_L03
M01_L08:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      qword ptr [7FFB2E5CDA50]
       jmp       short M01_L05
M01_L09:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FFB2E717498]
       int       3
M01_L11:
       mov       rdx,1CEB3C02180
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFB2E5CDAF8]
       jmp       near ptr M01_L02
M01_L12:
       mov       rdx,1CEB3C02180
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFB2E5CDAF8]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       r8,1E69FAEE4E8
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
       mov       rdx,7FFB910B4B48
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
       mov       rcx,1E69FAEE4E8
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
       mov       rcx,1E6BFAE2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB910B0420]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       r8,24C55C00D98
       mov       r8,[r8]
       mov       edx,0A
       call      qword ptr [7FFB2E8DB438]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB71348]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E963360]
       mov       rbp,rax
       mov       rcx,24C55C00DA0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E963498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9617F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E963078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E963558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E71D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E553510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E963090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E963558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6F5750]
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
       call      qword ptr [7FFB2E963498]
       mov       r14,rax
       mov       ecx,2BD
       mov       rdx,7FFB2E756478
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,340
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,r15
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9617F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E963078]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2E963558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E71D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,24C55C00D98
       mov       rcx,[rcx]
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFB2E553510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,24C59C01ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB2E751EC0]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFB2E8DB558]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FFB2E5999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[rbp+8]
       mov       [rsp+40],ecx
M01_L07:
       lea       rcx,[rsp+30]
       mov       edx,2E
       call      qword ptr [7FFB2EB71330]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
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
       call      qword ptr [7FFB2E5999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+40]
       add       ecx,[rsi+8]
       mov       [rsp+40],ecx
M01_L08:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFB2E5CD930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2E7D3180]; System.IO.Path.Combine(System.String, System.String)
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
       call      qword ptr [7FFB2E5CDA50]
       jmp       near ptr M01_L07
M01_L10:
       lea       rcx,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFB2E5CDA50]
       jmp       short M01_L08
M01_L11:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L06
M01_L12:
       call      qword ptr [7FFB2E717498]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRefPerson()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
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
       mov       rdx,7FFB9127DCE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+48],rax
       mov       rsi,[rsp+48]
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFB90E406F8
       call      qword ptr [7FFB90E406F8]
       mov       rsi,[rsp+48]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFB90E40700
       call      qword ptr [7FFB90E40700]
       mov       rsi,[rsp+48]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFB90E40708
       call      qword ptr [7FFB90E40708]
       mov       rcx,[rsp+48]
       vmovupd   xmm0,[rsp+50]
       vmovupd   [rsp+38],xmm0
       lea       rdx,[rsp+38]
       mov       r11,7FFB90E40710
       call      qword ptr [7FFB90E40710]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+68]
       mov       r11,7FFB90E40718
       call      qword ptr [7FFB90E40718]
       lea       rcx,[rsp+48]
       cmp       qword ptr [rsp+88],0
       je        short M01_L02
       mov       rdx,[rsp+88]
       mov       rdx,[rdx+18]
       jmp       short M01_L03
M01_L02:
       mov       rdx,1DB61F93020
       mov       rdx,[rdx]
M01_L03:
       mov       rcx,[rcx]
       mov       r11,7FFB90E40720
       call      qword ptr [7FFB90E40720]
       mov       rdx,[rsp+98]
       mov       rdx,[rdx+58]
       mov       rcx,[rsp+48]
       mov       r11,7FFB90E40728
       call      qword ptr [7FFB90E40728]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+60]
       mov       r11,7FFB90E40730
       call      qword ptr [7FFB90E40730]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+80]
       mov       r11,7FFB90E40738
       call      qword ptr [7FFB90E40738]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+70]
       mov       r11,7FFB90E40740
       call      qword ptr [7FFB90E40740]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+78]
       mov       r11,7FFB90E40748
       call      qword ptr [7FFB90E40748]
       mov       rsi,[rsp+48]
       mov       rcx,[rsp+98]
       mov       rdx,[rsp+88]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFB90E40750
       call      qword ptr [7FFB90E40750]
       mov       rdx,[rsp+90]
       mov       rdx,[rdx+20]
       mov       rcx,[rsp+48]
       mov       r11,7FFB90E40758
       call      qword ptr [7FFB90E40758]
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRefPerson()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       edx,19
       call      qword ptr [7FFB2E89B720]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB0F8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E89B150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
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
       call      qword ptr [7FFB2E89B168]; DotNetTips.Spargine.Tester.RandomData.GetRandomPersonData(DotNetTips.Spargine.Tester.Data.Country, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.DateTimeOffset ByRef)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB2E8AF5E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      qword ptr [7FFB2E85D858]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rsp+48],rax
       mov       rsi,[rsp+48]
       call      qword ptr [7FFB2EACB978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFB2E2D0670
       call      qword ptr [r11]
       mov       rsi,[rsp+48]
       mov       ecx,edi
       call      qword ptr [7FFB2E89B528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFB2E2D0678
       call      qword ptr [r11]
       mov       rsi,[rsp+48]
       mov       ecx,edi
       call      qword ptr [7FFB2E89B528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFB2E2D0680
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       vmovupd   xmm0,[rsp+50]
       vmovupd   [rsp+38],xmm0
       lea       rdx,[rsp+38]
       mov       r11,7FFB2E2D0688
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+68]
       mov       r11,7FFB2E2D0690
       call      qword ptr [r11]
       lea       rcx,[rsp+48]
       cmp       qword ptr [rsp+88],0
       je        short M01_L02
       mov       rdx,[rsp+88]
       mov       rdx,[rdx+18]
       jmp       short M01_L03
M01_L02:
       mov       rdx,22735C02028
       mov       rdx,[rdx]
M01_L03:
       mov       rcx,[rcx]
       mov       r11,7FFB2E2D0698
       call      qword ptr [r11]
       mov       rdx,[rsp+98]
       mov       rdx,[rdx+58]
       mov       rcx,[rsp+48]
       mov       r11,7FFB2E2D06A0
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+60]
       mov       r11,7FFB2E2D06A8
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+80]
       mov       r11,7FFB2E2D06B0
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+70]
       mov       r11,7FFB2E2D06B8
       call      qword ptr [r11]
       mov       rcx,[rsp+48]
       mov       rdx,[rsp+78]
       mov       r11,7FFB2E2D06C0
       call      qword ptr [r11]
       mov       rsi,[rsp+48]
       mov       rcx,[rsp+98]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFB2E89B138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r11,7FFB2E2D06C8
       call      qword ptr [r11]
       mov       rdx,[rsp+90]
       mov       rdx,[rdx+20]
       mov       rcx,[rsp+48]
       mov       r11,7FFB2E2D06D0
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,16F1D2D7FF8
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      qword ptr [7FFB9146E158]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFB910CAF70]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFB9146E160]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,16F1D2D7FF8
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFB9146E160]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFB2E8CB468]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB3F8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,26AAE007000
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      qword ptr [7FFB2EB05D60]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       xor       edi,edi
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFB2E8CB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       short M01_L02
M01_L00:
       call      qword ptr [7FFB2E8CB4F8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       rdx,rax
       mov       rcx,[rbp-18]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M01_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-18]
       call      qword ptr [7FFB2E73B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       add       edi,1
       jo        short M01_L04
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFB2E8CB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFB2E72D7D0]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M01_L06
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,[rbp-18]
       mov       edx,2F
       mov       r8d,1
       call      qword ptr [7FFB2E73B258]
       jmp       short M01_L03
M01_L06:
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFB2EB05D68]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,26AAE007000
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFB2EB05D68]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFB910B4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rdx,1DEE5C41D68
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,400
       call      qword ptr [7FFB2E8AB480]; DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB41450]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E933360]
       mov       rdi,rax
       mov       rdx,1FC8F000D98
       mov       rcx,[rdx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L03
       call      qword ptr [7FFB2E933498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7271C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7271C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9317F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E933078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E933558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFB2E523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E933090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E933558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rdx,1FC8F000DA0
       mov       rdx,[rdx]
       mov       ecx,0A
       call      qword ptr [7FFB2E8AB420]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(Int32, System.String)
       mov       rdi,rax
       mov       ecx,esi
       call      qword ptr [7FFB2E8AB528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rsi,rax
       call      qword ptr [7FFB2E7F9000]; System.IO.File.get_UTF8NoBOM()
       mov       rbx,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFB2E7F9978]; System.IO.File.Validate(System.String, System.Text.Encoding)
       mov       rcx,rdi
       mov       r9,rbx
       mov       r8,rsi
       mov       edx,2
       call      qword ptr [7FFB2E7F99A8]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.String, System.Text.Encoding)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,1AEA4FF08F8
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
       mov       rcx,1AEA4FE6000
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      qword ptr [7FFB9146F508]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFB910CAF70]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFB9146F510]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1AEA4FE6000
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFB9146F510]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rax,1AEA4FE1028
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrl()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       call      qword ptr [7FFB2E8BB4C8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,2395D001DB0
       mov       rcx,[rcx]
       call      qword ptr [7FFB2E531C60]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       call      qword ptr [7FFB2E8BB468]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E531C60]; System.String.Concat(System.String, System.String)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB2DFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E8BB570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,23957006FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdi,[rcx+18]
M01_L00:
       mov       rdx,2395D001DB8
       mov       rbx,[rdx]
       mov       rdx,23957002188
       mov       rbp,[rdx]
       mov       r14d,[rdi+8]
       mov       edx,r14d
       sub       edx,1
       jo        short M01_L02
       xor       ecx,ecx
       call      qword ptr [7FFB2E8BB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       jmp       qword ptr [7FFB2E531C90]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      qword ptr [7FFB2E841B40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [7FFB2E5799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFB2E5799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23957002028
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
       call      qword ptr [7FFB2E6D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E6D1C78]
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
       mov       rcx,23957007000
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      qword ptr [7FFB2EAE2D40]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       xor       edi,edi
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFB2E8BB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       short M03_L02
M03_L00:
       call      qword ptr [7FFB2E8BB4F8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       rdx,rax
       mov       rcx,[rbp-18]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M03_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-18]
       call      qword ptr [7FFB2E72B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M03_L01:
       add       edi,1
       jo        short M03_L04
       mov       ecx,1
       mov       edx,0A
       call      qword ptr [7FFB2E8BB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFB2E71D7D0]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       short M03_L06
M03_L04:
       call      CORINFO_HELP_OVERFLOW
M03_L05:
       mov       rcx,[rbp-18]
       mov       edx,2F
       mov       r8d,1
       call      qword ptr [7FFB2E72B258]; System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L03
M03_L06:
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFB2EAE2D48]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,23957007000
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFB2EAE2D48]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,1E116869CF8
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostName()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFB2E8CB4C8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,17080400D98
       mov       rcx,[rcx]
       call      qword ptr [7FFB2E541C60]; System.String.Concat(System.String, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB3F330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E8CB570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,17076406FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdi,[rcx+18]
M01_L00:
       mov       rdx,17080400DA0
       mov       rbx,[rdx]
       mov       rdx,17076402188
       mov       rbp,[rdx]
       mov       r14d,[rdi+8]
       mov       edx,r14d
       sub       edx,1
       jo        short M01_L02
       xor       ecx,ecx
       call      qword ptr [7FFB2E8CB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       jmp       qword ptr [7FFB2E541C90]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      qword ptr [7FFB2E851A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [7FFB2E5899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFB2E5899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,17076402028
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
       call      qword ptr [7FFB2E6E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E6E1C78]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,1EB3A0B5FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdi,[rcx+18]
M01_L00:
       mov       rdx,1EBAA0B1D60
       mov       rbx,[rdx]
       mov       rdx,1EB3A0B1128
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoProtocol()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFB2E8DB4C8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB4DFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E8DB570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,2A0B3406FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdi,[rcx+18]
M01_L00:
       mov       rdx,2A0BD400D98
       mov       rbx,[rdx]
       mov       rdx,2A0B3402188
       mov       rbp,[rdx]
       mov       r14d,[rdi+8]
       mov       edx,r14d
       sub       edx,1
       jo        short M01_L02
       xor       ecx,ecx
       call      qword ptr [7FFB2E8DB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       jmp       qword ptr [7FFB2E551C90]; System.String.Concat(System.String, System.String, System.String, System.String)
M01_L01:
       call      qword ptr [7FFB2E861A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,118584E3BD8
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
       mov       rdx,118584E3BE0
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
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       jne       short M03_L04
       jne       short M03_L04
       jne       short M03_L04
       jne       short M03_L04
       jne       short M03_L04
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
M03_L02:
       add       rsp,30
M03_L02:
       add       rsp,30
M03_L02:
       add       rsp,30
M03_L02:
       add       rsp,30
M03_L02:
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
M03_L03:
       mov       rcx,rsi
M03_L03:
       mov       rcx,rsi
M03_L03:
       mov       rcx,rsi
M03_L03:
       mov       rcx,rsi
M03_L03:
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8318]
       call      qword ptr [7FFB98BD8318]
       call      qword ptr [7FFB98BD8318]
       call      qword ptr [7FFB98BD8318]
       call      qword ptr [7FFB98BD8318]
       jmp       short M03_L02
       jmp       short M03_L02
       jmp       short M03_L02
       jmp       short M03_L02
       jmp       short M03_L02
M03_L04:
       cmp       ebx,8
M03_L04:
       cmp       ebx,8
M03_L04:
       cmp       ebx,8
M03_L04:
       cmp       ebx,8
M03_L04:
       cmp       ebx,8
       ja        short M03_L05
       ja        short M03_L05
       ja        short M03_L05
       ja        short M03_L05
       ja        short M03_L05
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       lea       rdx,[7FFB98A91B08]
       lea       rdx,[7FFB98A91B08]
       lea       rdx,[7FFB98A91B08]
       lea       rdx,[7FFB98A91B08]
       lea       rdx,[7FFB98A91B08]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFB98BD82F8]
       call      qword ptr [7FFB98BD82F8]
       call      qword ptr [7FFB98BD82F8]
       call      qword ptr [7FFB98BD82F8]
       call      qword ptr [7FFB98BD82F8]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       call      qword ptr [7FFB98BD8300]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M03_L06
       je        short M03_L06
       je        short M03_L06
       je        short M03_L06
       je        short M03_L06
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
M03_L05:
       mov       rcx,[rdi+8]
M03_L05:
       mov       rcx,[rdi+8]
M03_L05:
       mov       rcx,[rdi+8]
M03_L05:
       mov       rcx,[rdi+8]
M03_L05:
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFB98BD1BA0]
       call      qword ptr [7FFB98BD1BA0]
       call      qword ptr [7FFB98BD1BA0]
       call      qword ptr [7FFB98BD1BA0]
       call      qword ptr [7FFB98BD1BA0]
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB98BD82F0]
       call      qword ptr [7FFB98BD82F0]
       call      qword ptr [7FFB98BD82F0]
       call      qword ptr [7FFB98BD82F0]
       call      qword ptr [7FFB98BD82F0]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       call      qword ptr [7FFB98BC3770]
       call      qword ptr [7FFB98BC3770]
       call      qword ptr [7FFB98BC3770]
       call      qword ptr [7FFB98BC3770]
       call      qword ptr [7FFB98BC3770]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFB98BDAF68]
       call      qword ptr [7FFB98BDAF68]
       call      qword ptr [7FFB98BDAF68]
       call      qword ptr [7FFB98BDAF68]
       call      qword ptr [7FFB98BDAF68]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       call      qword ptr [7FFB98BD8308]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
M03_L06:
       mov       rcx,rsi
M03_L06:
       mov       rcx,rsi
M03_L06:
       mov       rcx,rsi
M03_L06:
       mov       rcx,rsi
M03_L06:
       mov       rcx,rsi
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       call      qword ptr [7FFB98BD8310]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
; Total bytes of code 1325
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,21537402BE0
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
       call      qword ptr [7FFB2E8CB348]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,ebx
       jae       short M00_L03
       mov       ecx,eax
       mov       rcx,[rdi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB3F8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FFB2E851A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rdx,21537402BE8
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
       call      qword ptr [7FFB2E549030]
       int       3
M01_L05:
       mov       ecx,esi
       mov       edx,edi
       call      qword ptr [7FFB2E8F7870]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
M03_L00:
       mov       rdi,[rsi+8]
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       test      rdi,rdi
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       je        short M03_L01
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       mov       ebx,[rdi+10]
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       cmp       ebx,8
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       jne       short M03_L03
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
M03_L01:
       cmp       qword ptr [rsi+8],0
       jne       short M03_L02
       jne       short M03_L02
       jne       short M03_L02
       jne       short M03_L02
       jne       short M03_L02
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       mov       rax,[rsi+18]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
M03_L02:
       mov       rcx,rsi
M03_L02:
       mov       rcx,rsi
M03_L02:
       mov       rcx,rsi
M03_L02:
       mov       rcx,rsi
M03_L02:
       mov       rcx,rsi
       lea       rax,[7FFB8D0E4B30]
       lea       rax,[7FFB8D0E4B30]
       lea       rax,[7FFB8D0E4B30]
       lea       rax,[7FFB8D0E4B30]
       lea       rax,[7FFB8D0E4B30]
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       add       rsp,30
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
       jmp       qword ptr [rax]
M03_L03:
       cmp       ebx,8
M03_L03:
       cmp       ebx,8
M03_L03:
       cmp       ebx,8
M03_L03:
       cmp       ebx,8
M03_L03:
       cmp       ebx,8
       ja        short M03_L04
       ja        short M03_L04
       ja        short M03_L04
       ja        short M03_L04
       ja        short M03_L04
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       mov       ecx,ebx
       lea       rdx,[7FFB8CF83B48]
       lea       rdx,[7FFB8CF83B48]
       lea       rdx,[7FFB8CF83B48]
       lea       rdx,[7FFB8CF83B48]
       lea       rdx,[7FFB8CF83B48]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       lea       rax,[M03_L00]
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       add       rdx,rax
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       jmp       rdx
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       xor       edx,edx
       call      qword ptr [7FFB8D0E4AF8]
       call      qword ptr [7FFB8D0E4AF8]
       call      qword ptr [7FFB8D0E4AF8]
       call      qword ptr [7FFB8D0E4AF8]
       call      qword ptr [7FFB8D0E4AF8]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       mov       r8d,1
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       call      qword ptr [7FFB8D0E4B00]
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       jmp       short M03_L01
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       mov       rax,[rsi+10]
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       test      rax,rax
       je        short M03_L05
       je        short M03_L05
       je        short M03_L05
       je        short M03_L05
       je        short M03_L05
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
M03_L04:
       mov       rcx,[rdi+8]
M03_L04:
       mov       rcx,[rdi+8]
M03_L04:
       mov       rcx,[rdi+8]
M03_L04:
       mov       rcx,[rdi+8]
M03_L04:
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8D0DCB48]
       call      qword ptr [7FFB8D0DCB48]
       call      qword ptr [7FFB8D0DCB48]
       call      qword ptr [7FFB8D0DCB48]
       call      qword ptr [7FFB8D0DCB48]
       int       3
       int       3
       int       3
       int       3
       int       3
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4AF0]
       call      qword ptr [7FFB8D0E4AF0]
       call      qword ptr [7FFB8D0E4AF0]
       call      qword ptr [7FFB8D0E4AF0]
       call      qword ptr [7FFB8D0E4AF0]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       mov       rcx,[rsi]
       call      qword ptr [7FFB8D0CBCE0]
       call      qword ptr [7FFB8D0CBCE0]
       call      qword ptr [7FFB8D0CBCE0]
       call      qword ptr [7FFB8D0CBCE0]
       call      qword ptr [7FFB8D0CBCE0]
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       mov       rcx,rax
       call      qword ptr [7FFB8D0E81B0]
       call      qword ptr [7FFB8D0E81B0]
       call      qword ptr [7FFB8D0E81B0]
       call      qword ptr [7FFB8D0E81B0]
       call      qword ptr [7FFB8D0E81B0]
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       call      qword ptr [7FFB8D0E4B08]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
M03_L05:
       mov       rcx,rsi
M03_L05:
       mov       rcx,rsi
M03_L05:
       mov       rcx,rsi
M03_L05:
       mov       rcx,rsi
M03_L05:
       mov       rcx,rsi
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       call      qword ptr [7FFB8D0E4B18]
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
       jmp       near ptr M03_L01
; Total bytes of code 1385
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,2208D171D60
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlPart()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFB2E89B4F8]; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB0FBA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E89B570]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdx,rax
       mov       rcx,206F7800D98
       mov       rcx,[rcx]
       add       rsp,28
       jmp       qword ptr [7FFB2E511C60]; System.String.Concat(System.String, System.String)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       add       rsp,100
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 139
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
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
       mov       rdx,19BB0653020
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
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2E8CB9F0]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB3DFC0]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       add       rsp,100
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2E8CB150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
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
       call      qword ptr [7FFB2E8CB168]; DotNetTips.Spargine.Tester.RandomData.GetRandomPersonData(DotNetTips.Spargine.Tester.Data.Country, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.DateTimeOffset ByRef)
       call      qword ptr [7FFB2EAF9978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFB2E755510]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Id(System.String)
       mov       ecx,esi
       call      qword ptr [7FFB2E8CB528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFB2E755198]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Address1(System.String)
       mov       ecx,esi
       call      qword ptr [7FFB2E8CB528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFB2E7551F8]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Address2(System.String)
       vmovupd   xmm0,[rsp+0C0]
       vmovupd   [rsp+40],xmm0
       lea       rdx,[rsp+40]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFB2E755270]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_BornOn(System.DateTimeOffset)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0D8]
       call      qword ptr [7FFB2E7552D0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_CellPhone(System.String)
       lea       rcx,[rsp+50]
       cmp       qword ptr [rsp+0F8],0
       je        short M01_L01
       mov       rdx,[rsp+0F8]
       mov       rdx,[rdx+18]
       jmp       short M01_L02
M01_L01:
       mov       rdx,28766002028
       mov       rdx,[rdx]
M01_L02:
       call      qword ptr [7FFB2E755330]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_City(System.String)
       mov       rdx,[rsp+108]
       mov       rdx,[rdx+58]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFB2E755390]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Country(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0D0]
       call      qword ptr [7FFB2E7553F0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Email(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0F0]
       call      qword ptr [7FFB2E755450]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_FirstName(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0E0]
       call      qword ptr [7FFB2E7554B0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_HomePhone(System.String)
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0E8]
       call      qword ptr [7FFB2E755570]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_LastName(System.String)
       mov       rcx,[rsp+108]
       mov       rdx,[rsp+0F8]
       call      qword ptr [7FFB2E8CB138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFB2E7555D0]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_PostalCode(System.String)
       mov       rdx,[rsp+100]
       mov       rdx,[rdx+20]
       lea       rcx,[rsp+50]
       call      qword ptr [7FFB2E755630]; DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_State(System.String)
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
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       sub       rsp,28
       mov       rcx,rdx
       call      qword ptr [7FFB2EB3F000]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 19
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFB910D4B48
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,0A
       call      qword ptr [7FFB2E8AB528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB1FBA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E933360]
       mov       rsi,rax
       mov       rcx,1F3B88001B0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E933498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7271C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7271C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9317F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E933078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E933558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E933090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E933558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,41
       mov       r8d,7A
       call      qword ptr [7FFB2E8AB558]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,7FFB910C4B48
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
       mov       rdx,7FFB910C4B48
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
       mov       rdx,7FFB910C4B48
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
       vmulsd    xmm0,xmm0,qword ptr [7FFB913C5CA0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L13
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L13:
       mov       rcx,7FFB91244238
       mov       edx,2
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A4C04F4E60
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2E8CB588]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableList`1[[System.String, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableList`1<System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB6B3D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFB2E953360]
       mov       rbp,rax
       mov       rax,1E656C001B8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E953498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9517F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E953078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E953090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6E5750]
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
       call      qword ptr [7FFB2E953360]
       mov       r14,rax
       mov       rax,1E656C00960
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FFB2E953498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9517F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E953078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E953090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6E5750]
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
       call      qword ptr [7FFB2E953360]
       mov       r15,rax
       mov       rcx,1E656C00968
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFB2E953498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E9517F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E953078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E953090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB2E953558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      qword ptr [7FFB2E5B7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L15
M01_L12:
       mov       ecx,edi
       mov       edx,ebx
       call      qword ptr [7FFB2E8CB540]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
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
       call      qword ptr [7FFB2E5B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L14:
       add       r14d,1
       jo        near ptr M01_L23
       cmp       r14d,esi
       jl        short M01_L12
M01_L15:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2E502110]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L16
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      qword ptr [7FFB2E5B7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L16:
       mov       rdx,1E65EC07F80
       mov       r15,[rdx]
       mov       rdx,[r15+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L17
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableList`1[[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFB2EB658E8]; System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].CreateRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L22
M01_L17:
       mov       rsi,[r15+8]
       cmp       [rsi],sil
       mov       rcx,[rsi+18]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB67978]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2EB67DE0]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB67D98]
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
       call      qword ptr [7FFB2EB67C78]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EB67C78]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [rsi+24],1
       jmp       short M01_L18
M01_L20:
       mov       rax,1E65EC07F80
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

