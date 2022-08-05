## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateByteArray()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FF8946A6158]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 49
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
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FF80],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       mov       rcx,201AA6B1568
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       vmovsd    xmm0,qword ptr [7FF8946A6358]
       vmovsd    qword ptr [rdi+8],xmm0
       xor       ecx,ecx
       mov       r8,201AA6B1380
       mov       r8,[r8]
       vmovsd    xmm6,qword ptr [rbp+10]
       vucomisd  xmm6,xmm0
       setae     bl
       movzx     ebx,bl
       mov       [rbp+0FFA8],rdi
       mov       [rbp+0FFB0],rcx
       mov       [rbp+0FFB8],rcx
       mov       [rbp+0FFC0],r8
       mov       rcx,rsi
       lea       r8,[rbp+0FFA8]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       and       ebx,1
       jne       short M01_L00
       vxorps    xmm6,xmm6,xmm6
M01_L00:
       vmulsd    xmm0,xmm6,qword ptr [7FF8946A6360]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2019A6B36F8
       mov       rcx,[rdx]
       mov       [rbp+0FF90],rcx
       xor       edx,edx
       mov       [rbp+0FFC8],edx
       cmp       byte ptr [rbp+0FFC8],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFC8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,2019A6B3700
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rsi
       mov       [rbp+0FFA0],edi
       lea       rdx,[rbp+0FF98]
       call      qword ptr [7FF8946A9B90]
       nop
       cmp       byte ptr [rbp+0FFC8],0
       je        short M01_L03
       mov       rcx,[rbp+0FF90]
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
       mov       rax,201AA6B2E98
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
       cmp       byte ptr [rbp+0FFC8],0
       je        short M01_L06
       mov       rcx,[rbp+0FF90]
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
; Total bytes of code 450
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,41
       mov       edx,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       rdx,[rsi+18]
       mov       [rdx+50],ax
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
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
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
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
       mov       rdx,169E5E07B00
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       xor       edx,edx
       mov       [rbp+0FFE8],edx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L04
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L06
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L08
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       lea       rdx,[rsp+28]
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
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
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper ByRef)
       ret
; Total bytes of code 1
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      rsi
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rax
       mov       rsi,rcx
       mov       rdx,179CE111058
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
       lea       rcx,[rsp+40]
       mov       r9d,2
       call      DotNetTips.Spargine.Tester.RandomData.GenerateDecimal(System.Decimal, System.Decimal, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       lea       rdx,[rsp+40]
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,50
       pop       rsi
       ret
; Total bytes of code 131
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
       mov       ecx,21
       mov       rdx,7FF8945E6D08
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
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,19ACF7536F0
       mov       rdi,[rdx]
       mov       ebx,[rdi+8]
       mov       edx,ebx
       sub       edx,1
       jo        short M00_L00
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,ebx
       jae       short M00_L01
       movsxd    rdx,eax
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
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
       mov       rdx,19ACF7536F8
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       xor       edx,edx
       mov       [rbp+0FFE8],edx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L04
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L06
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L08
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEmailAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ecx,5
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       ecx,5
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rdi,rax
       mov       rdx,168711C7AF8
       mov       rbx,[rdx]
       mov       rdx,168811C26D0
       mov       rbp,[rdx]
       mov       r14d,[rbx+8]
       mov       edx,r14d
       sub       edx,1
       jo        short M01_L00
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,r14d
       jae       short M01_L01
       movsxd    r9,eax
       mov       r9,[rbx+r9*8+10]
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Concat(System.String, System.String, System.String, System.String)
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 164
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFile()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1C8]
       mov       rdx,192901E2B38
       mov       rdx,[rdx]
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rcx,rax
       mov       edx,400
       call      DotNetTips.Spargine.Tester.RandomData.GenerateFile(System.String, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 71
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
       lea       eax,[rbx+0FFFF]
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
       mov       rcx,192B01E98A0
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
       mov       rcx,192B01E9890
       mov       rsi,[rcx]
       jmp       short M01_L18
M01_L17:
       mov       rcx,192B01E9898
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
       mov       rax,192B01E3020
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
       mov       ecx,41
       mov       rdx,7FF8945A6D08
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
       mov       ecx,53
       mov       rdx,7FF8945A6D08
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFiles()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1C8]
       mov       edx,2
       mov       r8d,400
       call      DotNetTips.Spargine.Tester.RandomData.GenerateFiles(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
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
       mov       ecx,0A5
       mov       rdx,7FF8945D6D08
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
       mov       rdx,7FF8945D6D08
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
       mov       ecx,53
       mov       rdx,7FF8945D6D08
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
       mov       r8,2162A972338
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
       vmulsd    xmm0,xmm0,qword ptr [7FF89469DFC0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       mov       rdx,[rsi+18]
       mov       [rdx+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
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
       mov       rdx,1C519947B00
       mov       rcx,[rdx]
       mov       [rbp+0FFE0],rcx
       xor       edx,edx
       mov       [rbp+0FFE8],edx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L04
       lea       rdx,[rbp+0FFE8]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L06
       mov       rcx,[rbp+0FFE0]
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L08
       mov       rcx,[rbp+0FFE0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       lea       rcx,[rsp+28]
       call      System.Guid.NewGuid()
       mov       rdx,217CC5313C0
       mov       rdx,[rdx]
       mov       r8,217EC531568
       mov       r8,[r8]
       lea       rcx,[rsp+28]
       call      System.Guid.ToString(System.String, System.IFormatProvider)
       nop
       add       rsp,38
       ret
; Total bytes of code 68
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateNumber()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
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
       mov       ecx,0AF
       mov       rdx,7FF8945D6D08
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       mov       rdx,23284D67B00
       mov       rcx,[rdx]
       mov       [rbp+0FFD8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L04
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L05:
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L06:
       xor       ecx,ecx
       mov       edx,9
       call      System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       edx,eax
       mov       rcx,rdi
       call      System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       add       ebx,1
       jo        short M01_L03
       cmp       ebx,esi
       jl        short M01_L06
M01_L07:
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L08
       mov       rcx,[rbp+0FFD8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L08:
       mov       rcx,rdi
       call      qword ptr [7FF894692180]
       mov       rsi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L09
       mov       rax,rsi
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
M01_L10:
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L11
       mov       rcx,[rbp+0FFD8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 340
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePhoneNumberUSA()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
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
       mov       rcx,29F392F2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF894692598]
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
       mov       rdx,29F392F32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L02
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L14:
       mov       rdx,29F392F32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
; Total bytes of code 632
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1C8]
       mov       r8,15B4E521B20
       mov       r8,[r8]
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRandomFileName(System.String, Int32, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 63
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
       mov       ecx,0C1
       mov       rdx,7FF8945B6D08
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
       mov       rcx,15B4E521B20
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
       mov       rcx,15B3E522EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF894692598]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRefPerson()
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 104
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       [rsp+60],rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebx,r9d
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],0
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF894708508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F04E0
       call      qword ptr [7FF8946904E0]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F04E8
       call      qword ptr [7FF8946904E8]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F04F0
       call      qword ptr [7FF8946904F0]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L02
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L03
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L03
       imul      rsi,rcx,2710
       lea       rcx,[rsp+50]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L04
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+50]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L05
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L05
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FF8942F04F8
       call      qword ptr [7FF8946904F8]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F0500
       call      qword ptr [7FF894690500]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F0508
       call      qword ptr [7FF894690508]
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F0510
       call      qword ptr [7FF894690510]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F0518
       call      qword ptr [7FF894690518]
       mov       ecx,[rsp+0B0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F0520
       call      qword ptr [7FF894690520]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F0528
       call      qword ptr [7FF894690528]
       mov       ecx,[rsp+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F0530
       call      qword ptr [7FF894690530]
       mov       ecx,[rsp+0C0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F0538
       call      qword ptr [7FF894690538]
       mov       ecx,[rsp+0C8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF8942F0540
       call      qword ptr [7FF894690540]
       mov       rax,rbp
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 828
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       ecx,1
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       short M01_L01
M01_L00:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M01_L04
       mov       ecx,1
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jg        short M01_L00
M01_L01:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M01_L02
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],2F
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       edx,2F
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rsi
       mov       rax,[7FF894672180]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 203
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTempFile()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,400
       call      DotNetTips.Spargine.Tester.RandomData.GenerateTempFile(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
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
       mov       ecx,53
       mov       rdx,7FF8945D6D08
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rdx,211C39D5F30
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrl()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       mov       rdi,rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rdx,rax
       mov       rcx,rdi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       push      rsi
       sub       rsp,20
       mov       rax,1EA0C575F28
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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       ecx,1
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       test      eax,eax
       jle       short M02_L01
M02_L00:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
       add       edi,1
       jo        short M02_L04
       mov       ecx,1
       mov       edx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,edi
       jg        short M02_L00
M02_L01:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L02
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],2F
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       edx,2F
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L03:
       mov       rcx,rsi
       mov       rax,[7FF8946A2180]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 203
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
       mov       rax,1EA0C573020
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostName()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostName()
       push      rsi
       sub       rsp,20
       mov       rax,24010A51B20
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr System.String.Concat(System.String, System.String)
; Total bytes of code 39
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoProtocol()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoProtocol()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ecx,1
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       rax,15FB2E51B20
       mov       rdi,[rax]
       mov       rax,15FC2E53290
       mov       rbx,[rax]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoSubDomain()
       mov       r9,rax
       mov       r8,rbx
       mov       rcx,rdi
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Concat(System.String, System.String, System.String, System.String)
; Total bytes of code 92
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoSubDomain()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ecx,3
       mov       edx,19
       mov       r8d,61
       mov       r9d,7A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32, Char, Char)
       mov       rsi,rax
       mov       rdx,1FC2A277AF8
       mov       rdi,[rdx]
       mov       ebx,[rdi+8]
       mov       edx,ebx
       sub       edx,1
       jo        short M01_L00
       xor       ecx,ecx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       cmp       eax,ebx
       jae       short M01_L01
       movsxd    rdx,eax
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Concat(System.String, System.String)
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 106
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlPart()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateUrlPart()
       push      rsi
       sub       rsp,20
       mov       rcx,29886BC1B20
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateValPerson()
       push      rbp
       push      rsi
       sub       rsp,0B8
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp+0FF88],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFF0],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp+0FFF0],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp+0FF88]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       lea       rdx,[rbp+0FF88]
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       add       rsp,0B8
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 151
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,148
       vzeroupper
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rax,0FFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       vmovdqa   xmmword ptr [rsp+rax+160],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rsp+140],rax
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebp,r9d
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Id(System.String)
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Address1(System.String)
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Address2(System.String)
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+58]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L01
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L02
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L02
       imul      rsi,rcx,2710
       lea       rcx,[rsp+58]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L03
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+58]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L04
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L04
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+38],xmm0
       lea       rcx,[rsp+38]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+38]
       vmovupd   [rsp+48],xmm0
       lea       rcx,[rsp+68]
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+28],xmm0
       lea       rdx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_BornOn(System.DateTimeOffset)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_CellPhone(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Country(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_Email(System.String)
       mov       ecx,[rsp+190]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_HomePhone(System.String)
       mov       ecx,[rsp+198]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_LastName(System.String)
       mov       ecx,[rsp+1A0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_PostalCode(System.String)
       mov       ecx,[rsp+1A8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      DotNetTips.Spargine.Tester.Models.ValueTypes.Person.set_State(System.String)
       lea       rdi,[rsp+0D8]
       lea       rsi,[rsp+68]
       mov       ecx,0E
       rep movsq
       mov       rdi,rbx
       lea       rsi,[rsp+0D8]
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
       add       rsp,148
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 826
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       ret
; Total bytes of code 1
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWord()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
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
       mov       ecx,0AF
       mov       rdx,7FF8945A6D08
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateWords()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,5
       mov       r8d,0A
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       rdx,7FF8945D6D08
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
       mov       ecx,117
       mov       rdx,7FF8945D6D08
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
       mov       ecx,12B
       mov       rdx,7FF8945D6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF89468EBE0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L13
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L13:
       mov       rcx,7FF89475A488
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2C340CC2F48
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
; Total bytes of code 408
```

