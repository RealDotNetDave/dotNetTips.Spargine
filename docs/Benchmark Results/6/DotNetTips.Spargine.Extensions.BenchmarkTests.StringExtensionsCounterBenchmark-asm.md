## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rax,21AE36D3020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,21AC36D1638
       mov       rax,[rax]
       mov       [rbp+0FFB8],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rbp+0FFB0],rax
       lea       rcx,[rbp+0FFC0]
       lea       rdx,[rbp+0FFB8]
       lea       r8,[rbp+0FFB0]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rbp+0FFB0],rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFA8],rdi
       mov       rcx,21AE36D1BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBCD3CB78]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L02
       mov       rdx,21AE36D1568
       mov       r12,[rdx]
       mov       rdx,21AC36D2F90
       mov       r13,[rdx]
M01_L01:
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       r14d,1
       jo        short M01_L03
       cmp       r15d,r14d
       jg        short M01_L01
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD378C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD44508]
       mov       rax,[rbp+0FFC0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L05
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [7FFEBCD44508]
M01_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rax,217C98A3020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,217A98A1638
       mov       rax,[rax]
       mov       [rbp+0FFB8],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rbp+0FFB0],rax
       lea       rcx,[rbp+0FFC0]
       lea       rdx,[rbp+0FFB8]
       lea       r8,[rbp+0FFB0]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rbp+0FFB0],rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFA8],rdi
       mov       rcx,217C98A1BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBCD5CB78]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L02
       mov       rdx,217C98A1568
       mov       r12,[rdx]
       mov       rdx,217A98A1F78
       mov       r13,[rdx]
M01_L01:
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       r14d,1
       jo        short M01_L03
       cmp       r15d,r14d
       jg        short M01_L01
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD578C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD64508]
       mov       rax,[rbp+0FFC0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L05
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [7FFEBCD64508]
M01_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rax,2159F6B3020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,2159F6B5A40
       mov       rax,[rax]
       mov       [rbp+0FFB8],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rbp+0FFB0],rax
       lea       rcx,[rbp+0FFC0]
       lea       rdx,[rbp+0FFB8]
       lea       r8,[rbp+0FFB0]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rbp+0FFB0],rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFA8],rdi
       mov       rcx,2159F6B1BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBCD5CB78]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L02
       mov       rdx,2159F6B1568
       mov       r12,[rdx]
       mov       rdx,2157F6B1760
       mov       r13,[rdx]
M01_L01:
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       r14d,1
       jo        short M01_L03
       cmp       r15d,r14d
       jg        short M01_L01
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD578C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD64508]
       mov       rax,[rbp+0FFC0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L05
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [7FFEBCD64508]
M01_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rax,17323E53020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,17323E55A40
       mov       rax,[rax]
       mov       [rbp+0FFB8],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rbp+0FFB0],rax
       lea       rcx,[rbp+0FFC0]
       lea       rdx,[rbp+0FFB8]
       lea       r8,[rbp+0FFB0]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rbp+0FFB0],rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFA8],rdi
       mov       rcx,17323E51BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBCD4CB78]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L02
       mov       rdx,17323E51568
       mov       r12,[rdx]
       mov       rdx,17323E57398
       mov       r13,[rdx]
M01_L01:
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       r14d,1
       jo        short M01_L03
       cmp       r15d,r14d
       jg        short M01_L01
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD478C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD54508]
       mov       rax,[rbp+0FFC0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L05
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [7FFEBCD54508]
M01_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rax,28351523020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,28371521638
       mov       rax,[rax]
       mov       [rbp+0FFB8],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rbp+0FFB0],rax
       lea       rcx,[rbp+0FFC0]
       lea       rdx,[rbp+0FFB8]
       lea       r8,[rbp+0FFB0]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rbp+0FFB0],rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFA8],rdi
       mov       rcx,28351521BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBCD5CB78]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L02
       mov       rdx,28351521568
       mov       r12,[rdx]
       mov       rdx,28371522F90
       mov       r13,[rdx]
M01_L01:
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       r14d,1
       jo        short M01_L03
       cmp       r15d,r14d
       jg        short M01_L01
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD578C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD64508]
       mov       rax,[rbp+0FFC0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L05
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [7FFEBCD64508]
M01_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rax,2B031AC1028
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,2B001AC3630
       mov       rax,[rax]
       mov       [rbp+0FFB8],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rbp+0FFB0],rax
       lea       rcx,[rbp+0FFC0]
       lea       rdx,[rbp+0FFB8]
       lea       r8,[rbp+0FFB0]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rbp+0FFB0],rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFA8],rdi
       mov       rcx,2B001AC1BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBCD6CB78]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L02
       mov       rdx,2B001AC1568
       mov       r12,[rdx]
       mov       rdx,2B001AC3F70
       mov       r13,[rdx]
M01_L01:
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       r14d,1
       jo        short M01_L03
       cmp       r15d,r14d
       jg        short M01_L01
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD678C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD74508]
       mov       rax,[rbp+0FFC0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L05
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [7FFEBCD74508]
M01_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rax,18720903020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,18720905A40
       mov       rax,[rax]
       mov       [rbp+0FFB8],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rbp+0FFB0],rax
       lea       rcx,[rbp+0FFC0]
       lea       rdx,[rbp+0FFB8]
       lea       r8,[rbp+0FFB0]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rbp+0FFB0],rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFA8],rdi
       mov       rcx,18720901BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBCD7CB78]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L02
       mov       rdx,18720901568
       mov       r12,[rdx]
       mov       rdx,18720907398
       mov       r13,[rdx]
M01_L01:
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       r14d,1
       jo        short M01_L03
       cmp       r15d,r14d
       jg        short M01_L01
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD778C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD84508]
       mov       rax,[rbp+0FFC0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L05
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [7FFEBCD84508]
M01_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rax,1FCA8273020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,1FC882795D0
       mov       rax,[rax]
       mov       [rbp+0FFB8],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rbp+0FFB0],rax
       lea       rcx,[rbp+0FFC0]
       lea       rdx,[rbp+0FFB8]
       lea       r8,[rbp+0FFB0]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rbp+0FFB0],rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFA8],rdi
       mov       rcx,1FCA8271BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBCD6CB78]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L02
       mov       rdx,1FCA8271568
       mov       r12,[rdx]
       mov       rdx,1FCA827B018
       mov       r13,[rdx]
M01_L01:
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       r14d,1
       jo        short M01_L03
       cmp       r15d,r14d
       jg        short M01_L01
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD678C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD74508]
       mov       rax,[rbp+0FFC0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L05
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [7FFEBCD74508]
M01_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rax,1DBE7AF3020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,1DBC7AF1638
       mov       rax,[rax]
       mov       [rbp+0FFB8],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rbp+0FFB0],rax
       lea       rcx,[rbp+0FFC0]
       lea       rdx,[rbp+0FFB8]
       lea       r8,[rbp+0FFB0]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       xor       ecx,ecx
       mov       [rbp+0FFB0],rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFA8],rdi
       mov       rcx,1DBE7AF1BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEBCD4CB78]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L02
       mov       rdx,1DBE7AF1568
       mov       r12,[rdx]
       mov       rdx,1DBC7AF1F78
       mov       r13,[rdx]
M01_L01:
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.Text.StringBuilder.Append(System.String)
       add       r14d,1
       jo        short M01_L03
       cmp       r15d,r14d
       jg        short M01_L01
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEBCD478C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD54508]
       mov       rax,[rbp+0FFC0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L05
       mov       rcx,[rbp+0FFA8]
       call      qword ptr [7FFEBCD54508]
M01_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,1E2A16B1308
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1E2A16B1028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,1E2A16B3BF0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,1E2B16B12A8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,1E2B16B12B0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD47880]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE24568
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E2C16B2F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE60108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE60138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       rax,1E2A16B1028
       mov       r14,[rax]
       test      rbp,rbp
       je        short M03_L00
       cmp       dword ptr [rbp+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       r14,rcx
M03_L03:
       mov       rdx,1E2A16B38C8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,1E2A16B3AA8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L05
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L06
M03_L05:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L06:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L10
M03_L07:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L08
       cmp       esi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L09
M03_L08:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r15d,ebp
       jg        short M03_L07
M03_L10:
       mov       rcx,r14
       call      qword ptr [7FFEBCD578C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 340
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,1EAEA533300
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1EAEA533020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,1EACA5317E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,1EACA532AD8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,1EACA532AE0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD37880]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE14568
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EAEA532F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE50108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE50138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       rax,1EAEA533020
       mov       r14,[rax]
       test      rbp,rbp
       je        short M03_L00
       cmp       dword ptr [rbp+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       r14,rcx
M03_L03:
       mov       rdx,1EACA5314B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,1EACA531698
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L05
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L06
M03_L05:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L06:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L10
M03_L07:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L08
       cmp       esi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L09
M03_L08:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r15d,ebp
       jg        short M03_L07
M03_L10:
       mov       rcx,r14
       call      qword ptr [7FFEBCD478C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 340
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,212230F3300
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,212230F3020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,212230F5BE8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,212530F12A8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,212530F12B0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD47880]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE24568
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,212230F2F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE60108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE60138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       rax,212230F3020
       mov       r14,[rax]
       test      rbp,rbp
       je        short M03_L00
       cmp       dword ptr [rbp+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       r14,rcx
M03_L03:
       mov       rdx,212230F58C0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,212230F5AA0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L05
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L06
M03_L05:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L06:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L10
M03_L07:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L08
       cmp       esi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L09
M03_L08:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r15d,ebp
       jg        short M03_L07
M03_L10:
       mov       rcx,r14
       call      qword ptr [7FFEBCD578C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 340
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,2BDDDAC3300
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,2BDDDAC3020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,2BDDDAC5BE8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,2BE0DACD6D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,2BE0DACD6E0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD67880]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE44568
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2BDDDAC2F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5FCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5FF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE80108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE80138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       rax,2BDDDAC3020
       mov       r14,[rax]
       test      rbp,rbp
       je        short M03_L00
       cmp       dword ptr [rbp+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       r14,rcx
M03_L03:
       mov       rdx,2BDDDAC58C0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,2BDDDAC5AA0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L05
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L06
M03_L05:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L06:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L10
M03_L07:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L08
       cmp       esi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L09
M03_L08:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r15d,ebp
       jg        short M03_L07
M03_L10:
       mov       rcx,r14
       call      qword ptr [7FFEBCD778C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 340
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,2E2B7DE1308
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,2E2B7DE1028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,2E297DE17E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,2E297DE2AD8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,2E297DE2AE0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD37880]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE14568
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2E2C7DE2F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE50108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE50138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE2FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       rax,2E2B7DE1028
       mov       r14,[rax]
       test      rbp,rbp
       je        short M03_L00
       cmp       dword ptr [rbp+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       r14,rcx
M03_L03:
       mov       rdx,2E297DE14B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,2E297DE1698
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L05
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L06
M03_L05:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L06:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L10
M03_L07:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L08
       cmp       esi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L09
M03_L08:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r15d,ebp
       jg        short M03_L07
M03_L10:
       mov       rcx,r14
       call      qword ptr [7FFEBCD478C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 340
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,1888A0F3300
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1888A0F3020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,188AA0F17E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,188AA0F2AD8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,188AA0F2AE0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD57880]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE34568
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1888A0F2F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE70108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE70138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       rax,1888A0F3020
       mov       r14,[rax]
       test      rbp,rbp
       je        short M03_L00
       cmp       dword ptr [rbp+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       r14,rcx
M03_L03:
       mov       rdx,188AA0F14B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,188AA0F1698
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L05
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L06
M03_L05:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L06:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L10
M03_L07:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L08
       cmp       esi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L09
M03_L08:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r15d,ebp
       jg        short M03_L07
M03_L10:
       mov       rcx,r14
       call      qword ptr [7FFEBCD678C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 340
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,26D0E523300
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,26D0E523020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,26CEE5237D8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,26D0E5246D0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,26D0E5246D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD57880]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE34568
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26D0E522F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE70108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE70138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       rax,26D0E523020
       mov       r14,[rax]
       test      rbp,rbp
       je        short M03_L00
       cmp       dword ptr [rbp+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       r14,rcx
M03_L03:
       mov       rdx,26CEE5234B0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,26CEE523690
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L05
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L06
M03_L05:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L06:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L10
M03_L07:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L08
       cmp       esi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L09
M03_L08:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r15d,ebp
       jg        short M03_L07
M03_L10:
       mov       rcx,r14
       call      qword ptr [7FFEBCD678C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 340
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,28A6E683300
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,28A6E683020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,28A4E6817E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,28A4E681AC0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,28A4E681AC8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD47880]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE24568
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,28A6E682F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE60108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE60138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE3FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       rax,28A6E683020
       mov       r14,[rax]
       test      rbp,rbp
       je        short M03_L00
       cmp       dword ptr [rbp+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       r14,rcx
M03_L03:
       mov       rdx,28A4E6814B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,28A4E681698
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L05
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L06
M03_L05:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L06:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L10
M03_L07:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L08
       cmp       esi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L09
M03_L08:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r15d,ebp
       jg        short M03_L07
M03_L10:
       mov       rcx,r14
       call      qword ptr [7FFEBCD578C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 340
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,1C3B0951308
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1C3B0951028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,1C3B0960020
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,1C3B0961318
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,1C3B0961320
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD57880]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE34568
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C390952F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FF00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE70108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE70138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE4FED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       rax,1C3B0951028
       mov       r14,[rax]
       test      rbp,rbp
       je        short M03_L00
       cmp       dword ptr [rbp+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       r14,rcx
M03_L03:
       mov       rdx,1C3B095FCF8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,1C3B095FED8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L05
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L06
M03_L05:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L06:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L10
M03_L07:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L08
       cmp       esi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L09
M03_L08:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r15d,ebp
       jg        short M03_L07
M03_L10:
       mov       rcx,r14
       call      qword ptr [7FFEBCD678C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 340
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L02
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L02
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L02
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L02
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L02
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L02
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L02
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L02
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L02
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass5_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,216A3D51028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,24530353020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,21C31381028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1E1B7001028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,19027E63020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1C0B5641028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1CFE4D11028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,2D655533020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1963C991028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2B43B2553A0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rax,2B43B253020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,2B43B2553A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L06
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 151
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,24E41D81F78
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rax,24E61D83020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,24E41D81F80
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L06
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 151
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1BA85E32F90
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rax,1BAA5E33020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,1BA85E32F98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L06
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 151
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,213F3E77398
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rax,213F3E73020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,213F3E773A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L06
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 151
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,22E7D181760
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rax,22E5D183020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,22E7D181768
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L06
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 151
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1D258897398
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rax,1D258893020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,1D2588973A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L06
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 151
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,199FF97DB90
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rax,19A1F973020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,199FF97DB98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L06
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 151
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1913CDD0FB8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rax,1913CDC1028
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,1913CDD0FC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L06
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 151
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2A81FD22FB0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rax,2A81FD13020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,2A81FD22FB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L06
       cmp       dword ptr [rsi+8],0
       je        short M01_L06
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 151
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1EC00961028
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1EBD096B448
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1EBD096CF20
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 238
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1B28F0B3020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1B26F0B14B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1B29F0B1760
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 238
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,184EC713020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,184EC71FCF8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,184CC711760
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 238
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,17A3C233020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,17A5C2314B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,17A3C242FB0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 238
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1B631521028
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1B6115234B0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1B611523F70
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 238
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,225ABE13020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,2258BE114B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,2258BE11F78
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 238
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1A7F6FF3020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1A7F6FF9D58
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1A816FFA710
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 238
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,297803C3020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,297803C9D58
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,297603CA710
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 238
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1B276D81028
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1B2A6D8D8E8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1B276D82B90
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 238
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1B5E9801028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1B5E9801028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,23FBB103020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,23FBB103020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1E40A461028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1E40A461028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1D8B3C53020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1D8B3C53020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1E6604C3020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1E6604C3020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1635B563020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1635B563020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1C496061028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1C496061028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,2668C871028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,2668C871028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1B031661028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1B031661028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1E5F2BB3020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,1E612BB14B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1E5F2BB1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1E5F2BB1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFEBCD3EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2B43EA61028
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,2B43EA638C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,2B45EA61B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2B45EA61AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFEBCD4EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1AA7ED43020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,1AA8ED414B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1AA7ED41B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1AA7ED41AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFEBCD5EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,13F398C3020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,13F398C58C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,13F398C1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,13F398C1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFEBCD6EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,25CB1881028
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,25C918814B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,25CC1881B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,25CC1881AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFEBCD5EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,256AEA93020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,2568EA914B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,256AEA91B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,256AEA91AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFEBCD7EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1691F613020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,168FF6114B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1691F611B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1691F611AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFEBCD3EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,19F176F3020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,19F376F14B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,19F176F1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,19F176F1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFEBCD6EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,16B1AF33020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,16AFAF314B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,16B1AF31B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,16B1AF31AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFEBCD5EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rax,22921363020
       mov       rbp,[rax]
       mov       r14,rbx
       test      r14,r14
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rbp,rcx
M01_L03:
       mov       rdx,229213658C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [r14],r14d
       mov       rcx,r14
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L05
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       mov       ebp,1
       jmp       short M01_L09
M01_L06:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L07
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],di
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L08
M01_L07:
       movzx     edx,di
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L08:
       add       ebp,1
       jo        short M01_L12
M01_L09:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L10
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L13
M01_L10:
       cmp       ebp,edx
       jle       short M01_L06
       test      esi,esi
       jle       short M01_L11
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L11:
       mov       rcx,r14
       call      qword ptr [7FFEBCD578C0]
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 311
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rax,2BFEA9A1028
       mov       rbp,[rax]
       mov       r14,rbx
       test      r14,r14
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rbp,rcx
M01_L03:
       mov       rdx,2BFBA9A14B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [r14],r14d
       mov       rcx,r14
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L05
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       mov       ebp,1
       jmp       short M01_L09
M01_L06:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L07
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],di
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L08
M01_L07:
       movzx     edx,di
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L08:
       add       ebp,1
       jo        short M01_L12
M01_L09:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L10
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L13
M01_L10:
       cmp       ebp,edx
       jle       short M01_L06
       test      esi,esi
       jle       short M01_L11
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L11:
       mov       rcx,r14
       call      qword ptr [7FFEBCD578C0]
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 311
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rax,23A14FB3020
       mov       rbp,[rax]
       mov       r14,rbx
       test      r14,r14
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rbp,rcx
M01_L03:
       mov       rdx,23A14FC1CF0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [r14],r14d
       mov       rcx,r14
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L05
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       mov       ebp,1
       jmp       short M01_L09
M01_L06:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L07
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],di
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L08
M01_L07:
       movzx     edx,di
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L08:
       add       ebp,1
       jo        short M01_L12
M01_L09:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L10
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L13
M01_L10:
       cmp       ebp,edx
       jle       short M01_L06
       test      esi,esi
       jle       short M01_L11
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L11:
       mov       rcx,r14
       call      qword ptr [7FFEBCD478C0]
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 311
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rax,17F0B583020
       mov       rbp,[rax]
       mov       r14,rbx
       test      r14,r14
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rbp,rcx
M01_L03:
       mov       rdx,17F0B591CF0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [r14],r14d
       mov       rcx,r14
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L05
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       mov       ebp,1
       jmp       short M01_L09
M01_L06:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L07
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],di
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L08
M01_L07:
       movzx     edx,di
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L08:
       add       ebp,1
       jo        short M01_L12
M01_L09:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L10
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L13
M01_L10:
       cmp       ebp,edx
       jle       short M01_L06
       test      esi,esi
       jle       short M01_L11
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L11:
       mov       rcx,r14
       call      qword ptr [7FFEBCD678C0]
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 311
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rax,1DD9E771028
       mov       rbp,[rax]
       mov       r14,rbx
       test      r14,r14
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rbp,rcx
M01_L03:
       mov       rdx,1DD9E7738C8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [r14],r14d
       mov       rcx,r14
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L05
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       mov       ebp,1
       jmp       short M01_L09
M01_L06:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L07
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],di
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L08
M01_L07:
       movzx     edx,di
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L08:
       add       ebp,1
       jo        short M01_L12
M01_L09:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L10
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L13
M01_L10:
       cmp       ebp,edx
       jle       short M01_L06
       test      esi,esi
       jle       short M01_L11
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L11:
       mov       rcx,r14
       call      qword ptr [7FFEBCD478C0]
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 311
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rax,20C79BE3020
       mov       rbp,[rax]
       mov       r14,rbx
       test      r14,r14
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rbp,rcx
M01_L03:
       mov       rdx,20C79BE58C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [r14],r14d
       mov       rcx,r14
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L05
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       mov       ebp,1
       jmp       short M01_L09
M01_L06:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L07
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],di
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L08
M01_L07:
       movzx     edx,di
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L08:
       add       ebp,1
       jo        short M01_L12
M01_L09:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L10
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L13
M01_L10:
       cmp       ebp,edx
       jle       short M01_L06
       test      esi,esi
       jle       short M01_L11
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L11:
       mov       rcx,r14
       call      qword ptr [7FFEBCD678C0]
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 311
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rax,23E87E13020
       mov       rbp,[rax]
       mov       r14,rbx
       test      r14,r14
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rbp,rcx
M01_L03:
       mov       rdx,23E77E114B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [r14],r14d
       mov       rcx,r14
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L05
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       mov       ebp,1
       jmp       short M01_L09
M01_L06:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L07
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],di
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L08
M01_L07:
       movzx     edx,di
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L08:
       add       ebp,1
       jo        short M01_L12
M01_L09:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L10
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L13
M01_L10:
       cmp       ebp,edx
       jle       short M01_L06
       test      esi,esi
       jle       short M01_L11
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L11:
       mov       rcx,r14
       call      qword ptr [7FFEBCD478C0]
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 311
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rax,205CDB53020
       mov       rbp,[rax]
       mov       r14,rbx
       test      r14,r14
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rbp,rcx
M01_L03:
       mov       rdx,205CDB61CF0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [r14],r14d
       mov       rcx,r14
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L05
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       mov       ebp,1
       jmp       short M01_L09
M01_L06:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L07
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],di
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L08
M01_L07:
       movzx     edx,di
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L08:
       add       ebp,1
       jo        short M01_L12
M01_L09:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L10
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L13
M01_L10:
       cmp       ebp,edx
       jle       short M01_L06
       test      esi,esi
       jle       short M01_L11
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L11:
       mov       rcx,r14
       call      qword ptr [7FFEBCD578C0]
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 311
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rax,21837591028
       mov       rbp,[rax]
       mov       r14,rbx
       test      r14,r14
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rbp,rcx
M01_L03:
       mov       rdx,2182759D8E8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [r14],r14d
       mov       rcx,r14
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,r14
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L05
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       mov       ebp,1
       jmp       short M01_L09
M01_L06:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L07
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],di
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L08
M01_L07:
       movzx     edx,di
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L08:
       add       ebp,1
       jo        short M01_L12
M01_L09:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L10
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L13
M01_L10:
       cmp       ebp,edx
       jle       short M01_L06
       test      esi,esi
       jle       short M01_L11
       mov       rcx,r14
       mov       rdx,rbx
       call      System.Text.StringBuilder.Append(System.String)
M01_L11:
       mov       rcx,r14
       call      qword ptr [7FFEBCD578C0]
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 311
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
       cmp       eax,4
       ja        short M01_L01
       mov       edx,1
M01_L00:
       mov       eax,edx
       add       rsp,28
       ret
M01_L01:
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L00
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L04
M01_L03:
       mov       edx,1
M01_L04:
       jmp       short M01_L00
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 105
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
       cmp       eax,4
       ja        short M01_L01
       mov       edx,1
M01_L00:
       mov       eax,edx
       add       rsp,28
       ret
M01_L01:
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L00
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L04
M01_L03:
       mov       edx,1
M01_L04:
       jmp       short M01_L00
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 105
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
       cmp       eax,4
       ja        short M01_L01
       mov       edx,1
M01_L00:
       mov       eax,edx
       add       rsp,28
       ret
M01_L01:
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L00
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L04
M01_L03:
       mov       edx,1
M01_L04:
       jmp       short M01_L00
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 105
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
       cmp       eax,4
       ja        short M01_L01
       mov       edx,1
M01_L00:
       mov       eax,edx
       add       rsp,28
       ret
M01_L01:
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L00
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L04
M01_L03:
       mov       edx,1
M01_L04:
       jmp       short M01_L00
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 105
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
       cmp       eax,4
       ja        short M01_L01
       mov       edx,1
M01_L00:
       mov       eax,edx
       add       rsp,28
       ret
M01_L01:
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L00
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L04
M01_L03:
       mov       edx,1
M01_L04:
       jmp       short M01_L00
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 105
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
       cmp       eax,4
       ja        short M01_L01
       mov       edx,1
M01_L00:
       mov       eax,edx
       add       rsp,28
       ret
M01_L01:
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L00
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L04
M01_L03:
       mov       edx,1
M01_L04:
       jmp       short M01_L00
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 105
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
       cmp       eax,4
       ja        short M01_L01
       mov       edx,1
M01_L00:
       mov       eax,edx
       add       rsp,28
       ret
M01_L01:
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L00
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L04
M01_L03:
       mov       edx,1
M01_L04:
       jmp       short M01_L00
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 105
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
       cmp       eax,4
       ja        short M01_L01
       mov       edx,1
M01_L00:
       mov       eax,edx
       add       rsp,28
       ret
M01_L01:
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L00
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L04
M01_L03:
       mov       edx,1
M01_L04:
       jmp       short M01_L00
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 105
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rax,ecx
       mov       rcx,7FFF1BC01240
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
       cmp       eax,4
       ja        short M01_L01
       mov       edx,1
M01_L00:
       mov       eax,edx
       add       rsp,28
       ret
M01_L01:
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L00
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      dl
       movzx     edx,dl
       jmp       short M01_L04
M01_L03:
       mov       edx,1
M01_L04:
       jmp       short M01_L00
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 105
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0AC]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,15CA48E42A8
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,15CA48E4770
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,239FAEF2AE8
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,239FAEF2FB0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,22465D736A8
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22465D73B70
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,201ADC356A0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,201ADC35B68
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,183A7513EC0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,183A7514388
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,11A368566B8
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,11A36856B80
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,1E01F5E1AB0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E01F5E1F78
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,2162D7AE6E0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2162D7AEBA8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,22295783AA8
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22295783F70
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,242255E2F90
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,242255E2F98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,22BA4461760
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,22BA4461768
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,18C9A80DB90
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,18C9A80DB98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,27971C40FB8
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,27971C40FC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1A2C0A72FB0
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A2C0A72FB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,2497B191F98
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2497B191FA0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,13FDCDC3F70
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,13FDCDC3F78
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,21B3F1F2778
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,21B3F1F2780
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,2D89BFCDB90
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2D89BFCDB98
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,27105523020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rax,27105523020
       mov       rdi,[rax]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,271055258C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,27105526380
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       call      System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,24623953020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rax,24623953020
       mov       rdi,[rax]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,246039514B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,24603951F78
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       call      System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,1B4E0F91028
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rax,1B4E0F91028
       mov       rdi,[rax]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,1B4E0F938C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1B4E0F94388
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       call      System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,25E1B7D3020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rax,25E1B7D3020
       mov       rdi,[rax]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,25DFB7D14B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,25DFB7D1F78
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       call      System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,2903E8C3020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rax,2903E8C3020
       mov       rdi,[rax]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,2901E8C14B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,2901E8C1F78
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       call      System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,1E5CC093020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rax,1E5CC093020
       mov       rdi,[rax]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,1E5AC099450
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1E5CC09B018
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       call      System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,1C6A2C21028
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rax,1C6A2C21028
       mov       rdi,[rax]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,1C6A2C238C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1C6C2C23758
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       call      System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,255E20B1028
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rax,255E20B1028
       mov       rdi,[rax]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,255B20B14B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,255D20C0BA0
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       call      System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,2CA4AA03020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       mov       rax,2CA4AA03020
       mov       rdi,[rax]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdi,rcx
M01_L04:
       mov       rdx,2CA4AA058C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,2CA4AA06380
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       call      System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1CA96463020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1CA764614B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1CA96470FB8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1C545B73020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1C565B714B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1C545B82FB0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,27AB5523020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,27AB55238C8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,27AB55253A0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1A67C813020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1A67C8158C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1A67C817398
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1AD6F5C1028
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1AD6F5C38C8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1AD8F5D0BA0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,2B8035A3020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,2B8035A58C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,2B8035A7398
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,2A5540D3020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,2A5540D58C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,2A5740DEBA8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,298E1DB3020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,298C1DB14B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,298F1DB2778
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,29AA8731028
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,29AA873FCF8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,29AA87407B8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1DBD0C63020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1DBD0C658C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1DBB0C66C10
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,279B8231028
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,279B82318D0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,279C8233758
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1D7E9C93020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1D7C9C914B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1D7C9C92F90
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,14CB2B43020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,14CB2B458C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,14CE2B4DB90
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,203F1BE3020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,20411BE14B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,20411BE2F90
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1E7F9FB3020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1E7D9FB14B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1E809FB5BF8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1B825C33020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1B805C314B8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1B805C31F78
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,20BD78B3020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,20BD78B58C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,20BF78B5BF8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       mov       rdx,[rsi+48]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1B034833020
       mov       rbx,[rax]
       mov       rbp,rbx
       test      rsi,rsi
       je        short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rbp,rcx
M01_L04:
       mov       rdx,1B0348358C0
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rbp,rbx
       test      rdi,rdi
       je        short M01_L07
       cmp       dword ptr [rdi+8],0
       je        short M01_L07
       xor       eax,eax
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L08
M01_L07:
       mov       eax,1
       jmp       short M01_L06
M01_L08:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rbp+8],0
       je        short M01_L09
       mov       rcx,rbp
       jmp       short M01_L09
M01_L09:
       mov       rdx,1B034837398
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 259
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,21325C13020
       mov       rbp,[rax]
       mov       r14,rbp
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       r14,rcx
M01_L03:
       mov       rdx,21305C114B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L05
       mov       rcx,21325C13270
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L05:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L06
       mov       rcx,21325C13260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,21305C11F78
       mov       rcx,[rcx]
       mov       rdx,21325C13270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       add       ebx,esi
       jo        near ptr M01_L19
       sub       ebx,1
       jo        near ptr M01_L19
       jmp       short M01_L10
M01_L09:
       add       esi,1
       jo        near ptr M01_L19
M01_L10:
       cmp       esi,ebx
       jg        short M01_L13
       cmp       esi,r14d
       jae       near ptr M01_L20
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L12:
       sub       ebx,1
       jo        near ptr M01_L19
M01_L13:
       cmp       ebx,esi
       jl        short M01_L15
       cmp       ebx,r14d
       jae       near ptr M01_L20
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       cmp       ecx,100
       jae       short M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L12
       jmp       short M01_L15
M01_L14:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L12
M01_L15:
       sub       ebx,esi
       jo        short M01_L19
       add       ebx,1
       jo        short M01_L19
       cmp       r14d,ebx
       je        short M01_L16
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L17
M01_L16:
       mov       rax,rdi
M01_L17:
       test      ebx,ebx
       je        short M01_L18
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,280372B1028
       mov       rbp,[rax]
       mov       r14,rbp
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       r14,rcx
M01_L03:
       mov       rdx,280272B14B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L05
       mov       rcx,280372B1278
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L05:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L06
       mov       rcx,280372B1268
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,280472BFB88
       mov       rcx,[rcx]
       mov       rdx,280372B1278
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       add       ebx,esi
       jo        near ptr M01_L19
       sub       ebx,1
       jo        near ptr M01_L19
       jmp       short M01_L10
M01_L09:
       add       esi,1
       jo        near ptr M01_L19
M01_L10:
       cmp       esi,ebx
       jg        short M01_L13
       cmp       esi,r14d
       jae       near ptr M01_L20
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L12:
       sub       ebx,1
       jo        near ptr M01_L19
M01_L13:
       cmp       ebx,esi
       jl        short M01_L15
       cmp       ebx,r14d
       jae       near ptr M01_L20
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       cmp       ecx,100
       jae       short M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L12
       jmp       short M01_L15
M01_L14:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L12
M01_L15:
       sub       ebx,esi
       jo        short M01_L19
       add       ebx,1
       jo        short M01_L19
       cmp       r14d,ebx
       je        short M01_L16
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L17
M01_L16:
       mov       rax,rdi
M01_L17:
       test      ebx,ebx
       je        short M01_L18
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,1D51EFF3020
       mov       rbp,[rax]
       mov       r14,rbp
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       r14,rcx
M01_L03:
       mov       rdx,1D53EFF14B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L05
       mov       rcx,1D51EFF3270
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L05:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L06
       mov       rcx,1D51EFF3260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,1D51EFF5B68
       mov       rcx,[rcx]
       mov       rdx,1D51EFF3270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       add       ebx,esi
       jo        near ptr M01_L19
       sub       ebx,1
       jo        near ptr M01_L19
       jmp       short M01_L10
M01_L09:
       add       esi,1
       jo        near ptr M01_L19
M01_L10:
       cmp       esi,ebx
       jg        short M01_L13
       cmp       esi,r14d
       jae       near ptr M01_L20
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L12:
       sub       ebx,1
       jo        near ptr M01_L19
M01_L13:
       cmp       ebx,esi
       jl        short M01_L15
       cmp       ebx,r14d
       jae       near ptr M01_L20
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       cmp       ecx,100
       jae       short M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L12
       jmp       short M01_L15
M01_L14:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L12
M01_L15:
       sub       ebx,esi
       jo        short M01_L19
       add       ebx,1
       jo        short M01_L19
       cmp       r14d,ebx
       je        short M01_L16
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L17
M01_L16:
       mov       rax,rdi
M01_L17:
       test      ebx,ebx
       je        short M01_L18
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,195B44A3020
       mov       rbp,[rax]
       mov       r14,rbp
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       r14,rcx
M01_L03:
       mov       rdx,195B44A38C8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L05
       mov       rcx,195B44A3270
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L05:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L06
       mov       rcx,195B44A3260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,195B44A53A0
       mov       rcx,[rcx]
       mov       rdx,195B44A3270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       add       ebx,esi
       jo        near ptr M01_L19
       sub       ebx,1
       jo        near ptr M01_L19
       jmp       short M01_L10
M01_L09:
       add       esi,1
       jo        near ptr M01_L19
M01_L10:
       cmp       esi,ebx
       jg        short M01_L13
       cmp       esi,r14d
       jae       near ptr M01_L20
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L12:
       sub       ebx,1
       jo        near ptr M01_L19
M01_L13:
       cmp       ebx,esi
       jl        short M01_L15
       cmp       ebx,r14d
       jae       near ptr M01_L20
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       cmp       ecx,100
       jae       short M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L12
       jmp       short M01_L15
M01_L14:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L12
M01_L15:
       sub       ebx,esi
       jo        short M01_L19
       add       ebx,1
       jo        short M01_L19
       cmp       r14d,ebx
       je        short M01_L16
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L17
M01_L16:
       mov       rax,rdi
M01_L17:
       test      ebx,ebx
       je        short M01_L18
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,22FEEC03020
       mov       rbp,[rax]
       mov       r14,rbp
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       r14,rcx
M01_L03:
       mov       rdx,22FEEC058C0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L05
       mov       rcx,22FEEC03270
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L05:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L06
       mov       rcx,22FEEC03260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,2300EC01760
       mov       rcx,[rcx]
       mov       rdx,22FEEC03270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       add       ebx,esi
       jo        near ptr M01_L19
       sub       ebx,1
       jo        near ptr M01_L19
       jmp       short M01_L10
M01_L09:
       add       esi,1
       jo        near ptr M01_L19
M01_L10:
       cmp       esi,ebx
       jg        short M01_L13
       cmp       esi,r14d
       jae       near ptr M01_L20
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L12:
       sub       ebx,1
       jo        near ptr M01_L19
M01_L13:
       cmp       ebx,esi
       jl        short M01_L15
       cmp       ebx,r14d
       jae       near ptr M01_L20
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       cmp       ecx,100
       jae       short M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L12
       jmp       short M01_L15
M01_L14:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L12
M01_L15:
       sub       ebx,esi
       jo        short M01_L19
       add       ebx,1
       jo        short M01_L19
       cmp       r14d,ebx
       je        short M01_L16
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L17
M01_L16:
       mov       rax,rdi
M01_L17:
       test      ebx,ebx
       je        short M01_L18
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,27941791028
       mov       rbp,[rax]
       mov       r14,rbp
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       r14,rcx
M01_L03:
       mov       rdx,279217934B0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L05
       mov       rcx,27941791278
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L05:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L06
       mov       rcx,27941791268
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,27941793B70
       mov       rcx,[rcx]
       mov       rdx,27941791278
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       add       ebx,esi
       jo        near ptr M01_L19
       sub       ebx,1
       jo        near ptr M01_L19
       jmp       short M01_L10
M01_L09:
       add       esi,1
       jo        near ptr M01_L19
M01_L10:
       cmp       esi,ebx
       jg        short M01_L13
       cmp       esi,r14d
       jae       near ptr M01_L20
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L12:
       sub       ebx,1
       jo        near ptr M01_L19
M01_L13:
       cmp       ebx,esi
       jl        short M01_L15
       cmp       ebx,r14d
       jae       near ptr M01_L20
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       cmp       ecx,100
       jae       short M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L12
       jmp       short M01_L15
M01_L14:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L12
M01_L15:
       sub       ebx,esi
       jo        short M01_L19
       add       ebx,1
       jo        short M01_L19
       cmp       r14d,ebx
       je        short M01_L16
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L17
M01_L16:
       mov       rax,rdi
M01_L17:
       test      ebx,ebx
       je        short M01_L18
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,1A584903020
       mov       rbp,[rax]
       mov       r14,rbp
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       r14,rcx
M01_L03:
       mov       rdx,1A5649014B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L05
       mov       rcx,1A584903270
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L05:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L06
       mov       rcx,1A584903260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,1A564901F78
       mov       rcx,[rcx]
       mov       rdx,1A584903270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       add       ebx,esi
       jo        near ptr M01_L19
       sub       ebx,1
       jo        near ptr M01_L19
       jmp       short M01_L10
M01_L09:
       add       esi,1
       jo        near ptr M01_L19
M01_L10:
       cmp       esi,ebx
       jg        short M01_L13
       cmp       esi,r14d
       jae       near ptr M01_L20
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L12:
       sub       ebx,1
       jo        near ptr M01_L19
M01_L13:
       cmp       ebx,esi
       jl        short M01_L15
       cmp       ebx,r14d
       jae       near ptr M01_L20
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       cmp       ecx,100
       jae       short M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L12
       jmp       short M01_L15
M01_L14:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L12
M01_L15:
       sub       ebx,esi
       jo        short M01_L19
       add       ebx,1
       jo        short M01_L19
       cmp       r14d,ebx
       je        short M01_L16
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L17
M01_L16:
       mov       rax,rdi
M01_L17:
       test      ebx,ebx
       je        short M01_L18
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,20DAB001028
       mov       rbp,[rax]
       mov       r14,rbp
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       r14,rcx
M01_L03:
       mov       rdx,20DAB00FCF8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L05
       mov       rcx,20DAB001278
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L05:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L06
       mov       rcx,20DAB001268
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,20DAB0107B8
       mov       rcx,[rcx]
       mov       rdx,20DAB001278
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       add       ebx,esi
       jo        near ptr M01_L19
       sub       ebx,1
       jo        near ptr M01_L19
       jmp       short M01_L10
M01_L09:
       add       esi,1
       jo        near ptr M01_L19
M01_L10:
       cmp       esi,ebx
       jg        short M01_L13
       cmp       esi,r14d
       jae       near ptr M01_L20
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L12:
       sub       ebx,1
       jo        near ptr M01_L19
M01_L13:
       cmp       ebx,esi
       jl        short M01_L15
       cmp       ebx,r14d
       jae       near ptr M01_L20
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       cmp       ecx,100
       jae       short M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L12
       jmp       short M01_L15
M01_L14:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L12
M01_L15:
       sub       ebx,esi
       jo        short M01_L19
       add       ebx,1
       jo        short M01_L19
       cmp       r14d,ebx
       je        short M01_L16
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L17
M01_L16:
       mov       rax,rdi
M01_L17:
       test      ebx,ebx
       je        short M01_L18
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,228A1541028
       mov       rbp,[rax]
       mov       r14,rbp
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
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
       jne       short M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       r14,rcx
M01_L03:
       mov       rdx,228C15434B0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L04:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L05
       mov       rcx,228A1541278
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L05:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L06
       mov       rcx,228A1541268
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,228C1544F88
       mov       rcx,[rcx]
       mov       rdx,228A1541278
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       add       ebx,esi
       jo        near ptr M01_L19
       sub       ebx,1
       jo        near ptr M01_L19
       jmp       short M01_L10
M01_L09:
       add       esi,1
       jo        near ptr M01_L19
M01_L10:
       cmp       esi,ebx
       jg        short M01_L13
       cmp       esi,r14d
       jae       near ptr M01_L20
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       near ptr M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L09
       jmp       short M01_L13
M01_L12:
       sub       ebx,1
       jo        near ptr M01_L19
M01_L13:
       cmp       ebx,esi
       jl        short M01_L15
       cmp       ebx,r14d
       jae       near ptr M01_L20
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       cmp       ecx,100
       jae       short M01_L20
       movsxd    rcx,ecx
       mov       rax,7FFF1BC01240
       test      byte ptr [rcx+rax],80
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L12
       jmp       short M01_L15
M01_L14:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r15d,al
       test      r15d,r15d
       jne       short M01_L12
M01_L15:
       sub       ebx,esi
       jo        short M01_L19
       add       ebx,1
       jo        short M01_L19
       cmp       r14d,ebx
       je        short M01_L16
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L17
M01_L16:
       mov       rax,rdi
M01_L17:
       test      ebx,ebx
       je        short M01_L18
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.GetStringArray(10, 15, 20).ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,2C343BC3020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,2C343BC3BF0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,2C343BC3ED0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,2C343BC3ED8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD57840]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE34AE8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2C343BC2F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE735E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCE49240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M03_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M03_L03
M03_L02:
       mov       rax,2C343BC3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M03_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCE49310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE49450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCD678C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M03_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M03_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2C343BC3020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M04_L01
       cmp       dword ptr [rdi+8],0
       je        short M04_L01
       xor       eax,eax
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L05
       jmp       short M04_L02
M04_L01:
       mov       eax,1
       jmp       short M04_L00
M04_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rsi,rcx
M04_L04:
       mov       rdx,2C343BC38C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.GetStringArray(10, 15, 20).ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,27C0FF71028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,27C0FF73BF0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,27C3FF7D6D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,27C3FF7D6E0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD67840]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE44AE8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,27C2FF72F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE832D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83628
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M03_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M03_L03
M03_L02:
       mov       rax,27C0FF71028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M03_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCD778C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M03_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M03_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,27C0FF71028
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M04_L01
       cmp       dword ptr [rdi+8],0
       je        short M04_L01
       xor       eax,eax
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L05
       jmp       short M04_L02
M04_L01:
       mov       eax,1
       jmp       short M04_L00
M04_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rsi,rcx
M04_L04:
       mov       rdx,27C0FF738C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.GetStringArray(10, 15, 20).ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,28CF4CC3020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,28CD4CC17E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,28CD4CC1AC0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,28CD4CC1AC8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD47840]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE24AE8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,28CF4CC2F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE622D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE624F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE624F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE624F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCE39240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M03_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M03_L03
M03_L02:
       mov       rax,28CF4CC3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M03_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCE39310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE39450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCD578C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M03_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M03_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,28CF4CC3020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M04_L01
       cmp       dword ptr [rdi+8],0
       je        short M04_L01
       xor       eax,eax
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L05
       jmp       short M04_L02
M04_L01:
       mov       eax,1
       jmp       short M04_L00
M04_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rsi,rcx
M04_L04:
       mov       rdx,28CD4CC14B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.GetStringArray(10, 15, 20).ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,209FC133020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,209FC135BE8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,20A1C1322C0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,20A1C1322C8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD67840]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE44AE8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,209FC132F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE822D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE824F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE824F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE824F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M03_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M03_L03
M03_L02:
       mov       rax,209FC133020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M03_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCD778C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M03_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M03_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,209FC133020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M04_L01
       cmp       dword ptr [rdi+8],0
       je        short M04_L01
       xor       eax,eax
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L05
       jmp       short M04_L02
M04_L01:
       mov       eax,1
       jmp       short M04_L00
M04_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rsi,rcx
M04_L04:
       mov       rdx,209FC1358C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.GetStringArray(10, 15, 20).ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,237EA283020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,237EA28A080
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,237CA289240
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,237CA289248
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD67840]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE44AE8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,237EA282F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE832D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83628
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M03_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M03_L03
M03_L02:
       mov       rax,237EA283020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M03_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCD778C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M03_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M03_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,237EA283020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M04_L01
       cmp       dword ptr [rdi+8],0
       je        short M04_L01
       xor       eax,eax
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L05
       jmp       short M04_L02
M04_L01:
       mov       eax,1
       jmp       short M04_L00
M04_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rsi,rcx
M04_L04:
       mov       rdx,237EA289D58
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.GetStringArray(10, 15, 20).ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1A721923020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,1A7019217E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,1A721932AF8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,1A721932B00
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD57840]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE34AE8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A721922F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE732D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73628
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCE49240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M03_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M03_L03
M03_L02:
       mov       rax,1A721923020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M03_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCE49310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE49450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCD678C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M03_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M03_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1A721923020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M04_L01
       cmp       dword ptr [rdi+8],0
       je        short M04_L01
       xor       eax,eax
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L05
       jmp       short M04_L02
M04_L01:
       mov       eax,1
       jmp       short M04_L00
M04_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rsi,rcx
M04_L04:
       mov       rdx,1A7019214B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.GetStringArray(10, 15, 20).ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1ED69953020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,1ED499517E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,1ED49952AD8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,1ED49952AE0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD47840]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE24AE8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1ED69952F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE632D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE63500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE634F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE63518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE63628
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE63658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE634F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE634F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCE39240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M03_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M03_L03
M03_L02:
       mov       rax,1ED69953020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M03_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCE39310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE39450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCD578C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M03_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M03_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1ED69953020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M04_L01
       cmp       dword ptr [rdi+8],0
       je        short M04_L01
       xor       eax,eax
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L05
       jmp       short M04_L02
M04_L01:
       mov       eax,1
       jmp       short M04_L00
M04_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rsi,rcx
M04_L04:
       mov       rdx,1ED499514B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.GetStringArray(10, 15, 20).ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1F70F803020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,1F6EF8017E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,1F6EF801AC0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,1F6EF801AC8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD57840]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE34AE8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F70F802F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE732D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73628
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE73658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE734F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCE49240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M03_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M03_L03
M03_L02:
       mov       rax,1F70F803020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M03_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCE49310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE49450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCD678C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M03_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M03_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1F70F803020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M04_L01
       cmp       dword ptr [rdi+8],0
       je        short M04_L01
       xor       eax,eax
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L05
       jmp       short M04_L02
M04_L01:
       mov       eax,1
       jmp       short M04_L00
M04_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rsi,rcx
M04_L04:
       mov       rdx,1F6EF8014B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.GetStringArray(10, 15, 20).ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,20A805E3020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,20A605E17E0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,20A605E1AC0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,20A605E1AC8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD67840]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE44AE8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20A805E2F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
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
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
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
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
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
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
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
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE835F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE83620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE834B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M03_L00
       mov       rcx,[rbp+10]
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M03_L02
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M03_L03
M03_L02:
       mov       rax,20A805E3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M03_L08
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M03_L06
       jmp       short M03_L07
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE59450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L07:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFEBCD778C0]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M03_L08
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M03_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,20A805E3020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M04_L01
       cmp       dword ptr [rdi+8],0
       je        short M04_L01
       xor       eax,eax
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L05
       jmp       short M04_L02
M04_L01:
       mov       eax,1
       jmp       short M04_L00
M04_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rsi,rcx
M04_L04:
       mov       rdx,20A605E14B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,20FD5103020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,20FD51058C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 149
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,23682A03020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,23662A014B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 149
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,17B73511028
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,17B635114B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 149
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2149FCE3020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,2147FCE14B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 149
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1A36F2B1028
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,1A34F2B34B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 149
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1B73EF93020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,1B75EF914B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 149
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,22E73833020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,22E538314B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 149
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,23B9AC21028
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,23B8AC214B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 149
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2259B443020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M01_L01
       cmp       dword ptr [rdi+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L02
M01_L01:
       mov       eax,1
       jmp       short M01_L00
M01_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rdx,2259B451CF0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 149
```

