## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0A4C48170
       mov       r9d,0DD370D8F
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,26B11D7
       mov       r9d,0A5732E6F
       call      qword ptr [7FF9C611DD20]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C648FFC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,4DB34CAE
       mov       r9d,3609843B
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,1E78BECB
       mov       r9d,4954CF2
       call      qword ptr [7FF9C610DD20]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C647FFC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,90DC4B85
       mov       r9d,6288B8B0
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0E201F81C
       mov       r9d,0F3A7484
       call      qword ptr [7FF9BFCFDD20]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C00A1FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+298]
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0E8D1DAAF
       mov       r9d,8341F42B
       call      System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       r10d,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       r10d,8
       or        r10d,80000000
       mov       ecx,edx
       shr       r10d,cl
M01_L02:
       add       r8d,r10d
       mov       eax,r9d
       xor       eax,r8d
       mov       edx,r8d
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       r10d,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       r10d,10
       movzx     edx,word ptr [rcx]
       or        r10d,edx
       jmp       short M01_L02
M01_L06:
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
       jmp       short M01_L05
; Total bytes of code 274
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.GetHashCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,5D2525BF
       mov       r9d,0CE9C7AE0
       call      qword ptr [7FF9C17FDD20]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       [rsp+28],eax
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1BA1FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M01_L04
       mov       eax,edx
       shr       eax,3
M01_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r8d,r10d
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       rcx,8
       dec       eax
       jne       short M01_L00
       test      dl,4
       jne       short M01_L03
M01_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       not       edx
       shl       edx,3
       shr       eax,8
       or        eax,80000000
       shrx      eax,eax,edx
M01_L02:
       add       r8d,eax
       mov       eax,r9d
       xor       eax,r8d
       mov       ecx,r8d
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       ret
M01_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M01_L01
M01_L04:
       cmp       edx,4
       jae       short M01_L03
       mov       eax,80
       test      dl,1
       jne       short M01_L06
M01_L05:
       test      dl,2
       je        short M01_L02
       shl       eax,10
       movzx     ecx,word ptr [rcx]
       or        eax,ecx
       jmp       short M01_L02
M01_L06:
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
       jmp       short M01_L05
; Total bytes of code 256
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,1DF937FB5F0
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,0BABF01A1F5A7
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FF9C55D4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DF737F7128
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,0BABF01A1F5A7
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,1DF937F2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5BACE70]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,1DF937F2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5BACE70]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,23CE10085F8
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C6113258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0A5528864116E
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C61131E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6113270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C6113288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FF9C6113318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6113270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61132A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61132B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,23CED0066D0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C673FCF0]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,23CED0066D0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C673FCF0]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,0A5528864116E
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C613D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FF9C6357768]
       int       3
M01_L15:
       call      qword ptr [7FF9C6357498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,2AFAE843588
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,81F730605BA3
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FF9C55C4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2AFAE841648
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,81F730605BA3
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,2AFAE832FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B87720]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,2AFAE832FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B87720]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,2B7DE812588
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C6113258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,79C36243EA42
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C61131E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6113270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C6113288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FF9C6113318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6113270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61132A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61132B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,2B7DE802008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C671D070]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,2B7DE802008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C671D070]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,79C36243EA42
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C613D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FF9C6357768]
       int       3
M01_L15:
       call      qword ptr [7FF9C6357498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,1730CED3588
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,53FC9C4C937E
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FF9C55D4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1730CED1648
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,53FC9C4C937E
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,1730CEC2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B97720]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,1730CEC2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B97720]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,2720E4020C8
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C6123258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0C11A8665740F
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C61231E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6123270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C6123288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FF9C6123318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6123270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61232A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61232B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,272124046D8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C67602E0]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,272124046D8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C67602E0]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,0C11A8665740F
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FF9C6367768]
       int       3
M01_L15:
       call      qword ptr [7FF9C6367498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,2AB3B2A91E0
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,60886A7935CF
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FF9C55B4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2AB5B2A9538
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,60886A7935CF
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C54A4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF9C54A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,2AB3B2A2FE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B88250]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,2AB3B2A2FE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B88250]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,178E84044D8
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C6123258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0D01AB3D37404
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C61231E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6123270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C6123288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FF9C6123318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6123270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61232A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61232B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,178E8402008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C6760A50]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,178E8402008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C6760A50]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,0D01AB3D37404
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FF9C6367768]
       int       3
M01_L15:
       call      qword ptr [7FF9C6367498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,1C0085D3588
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,0E107C40DF072
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FF9C55C4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C0085D1648
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,0E107C40DF072
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,1C0085C2FE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B86C80]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,1C0085C2FE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B86C80]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,28838012588
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C6123258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,63F462073438
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C61231E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6123270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C6123288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FF9C6123318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6123270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61232A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61232B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,28838002008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C6760448]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,28838002008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C6760448]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,63F462073438
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FF9C6367768]
       int       3
M01_L15:
       call      qword ptr [7FF9C6367498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,190A9403588
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,741E4323621D
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FF9C55C4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,190A9401648
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,741E4323621D
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,190A93F2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B87720]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,190A93F2FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B87720]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,1A5C5C12588
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C6123258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0CF9CDB52B152
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C61231E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6123270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C6123288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FF9C6123318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C6123270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61232A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C61232B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,1A5C5C02008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C672D070]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,1A5C5C02008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C672D070]; Precode of System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,0CF9CDB52B152
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FF9C6367768]
       int       3
M01_L15:
       call      qword ptr [7FF9C6367498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],ecx
       mov       rdx,1E895E33588
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+80],rax
       mov       rax,154054388FF4
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14d,[rbp+0F0]
       test      ebx,ebx
       jl        near ptr M01_L14
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L15
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      rsi,rsi
       je        near ptr M01_L16
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        near ptr M01_L16
M01_L01:
       cmp       ebx,1
       jle       near ptr M01_L04
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M01_L04
       test      r15d,r15d
       jne       near ptr M01_L19
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+78]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       [rbp+70],ecx
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       lea       rdx,[rbp+58]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       xor       r15d,r15d
       test      r13d,r13d
       jle       near ptr M01_L11
M01_L02:
       xor       r12d,r12d
       mov       ecx,[rsi+8]
       mov       eax,ecx
       test      eax,eax
       jle       near ptr M01_L10
M01_L03:
       movsxd    rcx,r12d
       mov       rdx,[rsi+rcx*8+10]
       test      rdx,rdx
       je        short M01_L09
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L09
       jmp       short M01_L08
M01_L04:
       mov       rsi,rdi
       test      r14b,2
       jne       near ptr M01_L17
M01_L05:
       test      r14b,1
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L07
M01_L06:
       test      ebx,ebx
       jne       near ptr M01_L18
M01_L07:
       mov       rcx,7FF9C55C4938
       mov       edx,54
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E895E31648
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L08:
       mov       r8d,[rdx+8]
       cmp       r15d,r13d
       jae       near ptr M01_L34
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       cx,[rdx+0C]
       je        near ptr M01_L21
M01_L09:
       inc       r12d
       cmp       eax,r12d
       jg        near ptr M01_L03
M01_L10:
       inc       r15d
       cmp       r13d,r15d
       jg        near ptr M01_L02
M01_L11:
       mov       r9d,[rbp+70]
       mov       ecx,r9d
       mov       edx,[rbp+80]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       r10,[rbp+78]
       mov       r11d,[rbp+50]
       mov       ecx,r11d
       mov       edx,[rbp+60]
       cmp       rcx,rdx
       ja        near ptr M01_L28
       mov       rdx,[rbp+58]
       test      r9d,r9d
       jne       near ptr M01_L29
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L12:
       mov       rcx,154054388FF4
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A4F9
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       ecx,42
       mov       edx,59
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L16:
       xor       ecx,ecx
       xor       edx,edx
       mov       [rbp+30],rcx
       mov       [rbp+38],edx
       mov       rcx,rdi
       lea       rdx,[rbp+30]
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L17:
       test      ebx,ebx
       jle       near ptr M01_L05
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L18:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L12
M01_L19:
       cmp       dword ptr [rdx+8],0
       jne       short M01_L20
       mov       ebx,1
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L21:
       mov       ecx,r13d
       sub       ecx,r15d
       cmp       ecx,r8d
       jl        near ptr M01_L09
       cmp       r8d,1
       je        short M01_L25
       mov       ecx,r15d
       mov       r9d,r8d
       add       rcx,r9
       mov       r9d,r13d
       cmp       rcx,r9
       jbe       short M01_L22
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L22:
       lea       rcx,[rdi+0C]
       mov       r9d,r15d
       lea       rcx,[rcx+r9*2]
       mov       r9d,r8d
       add       rdx,0C
       mov       [rbp+44],r8d
       mov       r10d,r8d
       cmp       r9d,r10d
       jne       short M01_L23
       mov       [rbp+0C],eax
       mov       r9d,r9d
       lea       r8,[r9+r9]
       call      System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L24
M01_L23:
       xor       ecx,ecx
       mov       [rbp+0C],eax
       mov       eax,ecx
M01_L24:
       test      eax,eax
       mov       eax,[rbp+0C]
       mov       r8d,[rbp+44]
       je        near ptr M01_L09
M01_L25:
       mov       r12d,[rbp+70]
       cmp       r12d,[rbp+80]
       jl        short M01_L26
       mov       [rbp+44],r8d
       lea       rcx,[rbp+68]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L26:
       lea       rcx,[rbp+78]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L34
       mov       rcx,[rcx]
       movsxd    rax,r12d
       mov       [rcx+rax*4],r15d
       inc       r12d
       mov       [rbp+70],r12d
       mov       r12d,[rbp+50]
       cmp       r12d,[rbp+60]
       jl        short M01_L27
       mov       [rbp+44],r8d
       lea       rcx,[rbp+48]
       call      System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].Grow()
       mov       r8d,[rbp+44]
M01_L27:
       lea       rax,[rbp+58]
       cmp       r12d,[rax+8]
       jae       near ptr M01_L34
       mov       rax,[rax]
       movsxd    rdx,r12d
       mov       [rax+rdx*4],r8d
       inc       r12d
       mov       [rbp+50],r12d
       lea       r15d,[r15+r8-1]
       jmp       near ptr M01_L10
M01_L28:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L29:
       test      r14d,r14d
       jne       short M01_L30
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rsi,rax
       jmp       short M01_L31
M01_L30:
       mov       [rbp+20],r10
       mov       [rbp+28],r9d
       mov       [rbp+10],rdx
       mov       [rbp+18],r11d
       mov       [rsp+20],ebx
       mov       [rsp+28],r14d
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rsi,rax
M01_L31:
       mov       rdx,[rbp+68]
       test      rdx,rdx
       je        short M01_L32
       xor       ecx,ecx
       mov       [rbp+68],rcx
       mov       rcx,1E895E22FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B87720]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L32:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L33
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,1E895E22FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C5B87720]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L33:
       mov       rax,rsi
       jmp       near ptr M01_L12
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1282
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Split()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       cmp       [rcx],cl
       mov       rdx,22CAC812588
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C5D53258]; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       mov       edx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rdx
       mov       r14,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],rax
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 127
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,71F79918FE56
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L13
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L14
       xor       r14d,r14d
       test      rdx,rdx
       setne     r14b
       test      r14d,r14d
       jne       short M01_L02
       test      r8,r8
       je        short M01_L01
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L02
M01_L01:
       xor       ecx,ecx
       mov       [rbp+30],rcx
       xor       ecx,ecx
       mov       [rbp+38],ecx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C5D531E0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L04
       mov       edi,1
M01_L03:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C5D53270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF9C5D53288]; System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L11
M01_L05:
       mov       [rbp+0C0],r8
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+70],r9
       mov       dword ptr [rbp+78],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       test      [rsp],esp
       sub       rsp,200
       lea       r9,[rsp+30]
       mov       [rbp+50],r9
       mov       dword ptr [rbp+58],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      qword ptr [7FF9C5D53318]
       mov       eax,[rbp+68]
       cmp       eax,[rbp+78]
       ja        near ptr M01_L15
       mov       r9,[rbp+70]
       mov       r10d,[rbp+48]
       cmp       r10d,[rbp+58]
       ja        near ptr M01_L15
       mov       r11,[rbp+50]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FF9C5D53270]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       jmp       near ptr M01_L11
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C5D532A0]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L08
M01_L07:
       mov       [rbp+20],r9
       mov       [rbp+28],eax
       mov       [rbp+10],r11
       mov       [rbp+18],r10d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF9C5D532B8]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L08:
       mov       rdx,[rbp+60]
       test      rdx,rdx
       je        short M01_L09
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,22CAC802008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C635DA30]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L09:
       mov       rdx,[rbp+40]
       test      rdx,rdx
       je        short M01_L10
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       rcx,22CAC802008
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C635DA30]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L10:
       mov       rax,r14
M01_L11:
       mov       rcx,71F79918FE56
       cmp       [rbp+8],rcx
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1C7
       mov       rdx,7FF9C5B04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A18D
       mov       rdx,7FF9C5B04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C5D7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C5F85750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       ecx,44
       mov       edx,59
       call      qword ptr [7FF9C5F97768]
       int       3
M01_L15:
       call      qword ptr [7FF9C5F97498]
       int       3
; Total bytes of code 745
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C55E4938
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
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C64B13D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9C644B090]
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
       jmp       qword ptr [7FF9C64B10C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9C5C14C10
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
       call      qword ptr [7FF9C64B12A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
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
       call      qword ptr [7FF9C6449B10]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9C5D47210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FF9C6449B10]
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
       call      qword ptr [7FF9C5F79AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9C5F79270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9C64B10D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C55C4938
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
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C64B16D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9C644B090]
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
       jmp       qword ptr [7FF9C64B13C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9C5C14C10
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
       call      qword ptr [7FF9C64B15A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
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
       call      qword ptr [7FF9C6449B10]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9C5D47210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FF9C6449B10]
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
       call      qword ptr [7FF9C5F79AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9C5F79270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9C64B13D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C55E4938
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
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C1BC1F48]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9C1B5D090]
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
       jmp       qword ptr [7FF9C1BC1C30]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9C1314C10
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
       call      qword ptr [7FF9C1BC1E10]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
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
       call      qword ptr [7FF9C1B5BB10]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9C1447210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FF9C1B5BB10]
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
       call      qword ptr [7FF9C1679AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9C1679270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9C1BC1C48]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C55E4938
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
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToBrotliAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C1BA13D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9C1B3B090]
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
       jmp       qword ptr [7FF9C1BA10C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToBrotliAsync>d__23 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9C1304C10
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
       call      qword ptr [7FF9C1BA12A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToBrotliAsync>d__23.MoveNext()
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
       call      qword ptr [7FF9C1B39B10]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9C1437210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FF9C1B39B10]
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
       call      qword ptr [7FF9C1669AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9C1669270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9C1BA10D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C55C4938
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
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C64B36D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9C644D090]
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
       jmp       qword ptr [7FF9C64B33C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9C5C14C10
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
       call      qword ptr [7FF9C64B35A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
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
       call      qword ptr [7FF9C644BB10]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9C5D47210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FF9C644BB10]
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
       call      qword ptr [7FF9C5F79AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9C5F79270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9C64B33D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C55C4938
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
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C64C13D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9C645B090]
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
       jmp       qword ptr [7FF9C64C10C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9C5C24C10
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
       call      qword ptr [7FF9C64C12A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
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
       call      qword ptr [7FF9C6459B10]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9C5D57210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FF9C6459B10]
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
       call      qword ptr [7FF9C5F89AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9C5F89270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9C64C10D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C55F4938
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
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C1B916D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9C1B2BAC8]
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
       jmp       qword ptr [7FF9C1B913C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FF9C12E4C10
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
       call      qword ptr [7FF9C1B915A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
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
       call      qword ptr [7FF9C1B2B570]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FF9C1417210]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7FF9C1B2B570]
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
       call      qword ptr [7FF9C1649AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9C1649270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FF9C1B913D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToGZipAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
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
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToGZipAsync>d__24 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FF9C55C4938
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
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark+<ToGZipAsync>d__24.MoveNext()
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

