## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.LongTestString.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+18]
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,2408B7C1BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB478C0138]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2408B7C1568
       mov       r14,[rdx]
       mov       rdx,2409B7D3680
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FFB478BAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476012B8
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.LongTestString.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+18]
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,17704581BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB47890138]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,17704581568
       mov       r14,[rdx]
       mov       rdx,176F4582BA0
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FFB4788AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475D12B8
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.LongTestString.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+18]
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,1CFE2151BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB47890138]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1CFE2151568
       mov       r14,[rdx]
       mov       rdx,1CFD2160A58
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FFB4788AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475D12B8
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.LongTestString.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+18]
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,1E9277D1BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB47890138]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1E9277D1568
       mov       r14,[rdx]
       mov       rdx,1E9477E3680
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FFB4788AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475D12B8
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.LongTestString.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+18]
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,13C31F21BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB478A0138]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,13C31F21568
       mov       r14,[rdx]
       mov       rdx,13C41F32668
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475E12B8
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.LongTestString.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+18]
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,1E23B351BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB47890138]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1E23B351568
       mov       r14,[rdx]
       mov       rdx,1E24B3523A0
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FFB4788AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475D12B8
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.LongTestString.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+18]
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,1D0C6F81BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB478A0138]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1D0C6F81568
       mov       r14,[rdx]
       mov       rdx,1D0D6F81B88
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475E12B8
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.LongTestString.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+18]
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,2B41CE41BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB478A0138]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2B41CE41568
       mov       r14,[rdx]
       mov       rdx,2B40CE42BA0
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475E12B8
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.LongTestString.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+18]
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       mov       rax,1BC75A31BA8
       mov       rsi,[rax]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB478A0138]
       mov       rcx,rax
       call      System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1BC75A31568
       mov       r14,[rdx]
       mov       rdx,1BC75A44660
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L02
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       rcx,rdi
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475E12B8
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
; Total bytes of code 308
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat()
; 			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,242C4173300
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFB47738750
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
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475E12B8
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,242C4172EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478AAD80]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB478B29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,242C41732F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,242C41732F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
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
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
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
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,242C41839C8
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat()
; 			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,1C8BEE93300
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFB47748750
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
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475F12B8
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1C8BEE92EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478BAD80]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB478C29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,1C8BEE932F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,1C8BEE932F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
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
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
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
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,1C8BEEA39C8
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FFB478AAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat()
; 			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,1B0FECC3300
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFB47728750
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
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475D12B8
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1B0FECC2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB4789AD80]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB478A29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,1B0FECC32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,1B0FECC32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
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
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
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
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,1B0FECD39C8
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FFB4788AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat()
; 			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,24758CB3300
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFB47728750
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
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475D12B8
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,24758CB2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB4789AD80]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB478A29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,24758CB32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,24758CB32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
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
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
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
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,24758CC39C8
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FFB4788AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat()
; 			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,1E3DCE93300
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFB47758750
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
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476012B8
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1E3DCE92EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478CAD80]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB478D29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,1E3DCE932F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,1E3DCE932F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
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
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
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
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,1E3DCE95B10
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FFB478BAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat()
; 			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,1BD0D7D3300
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFB47738750
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
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475E12B8
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1BD0D7D2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478AAD80]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB478B29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,1BD0D7D32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,1BD0D7D32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
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
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
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
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,1BD0D7E39C8
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat()
; 			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,282BADD3300
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFB47738750
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
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475E12B8
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,282BADD2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478AAD80]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB478B29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,282BADD32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,282BADD32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
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
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
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
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,282BADE39C8
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat()
; 			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,27A3B2B3300
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFB47758750
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
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB476012B8
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,27A3B2B2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478CAD80]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB478D29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,27A3B2B32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,27A3B2B32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
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
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
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
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,27A3B2C39C8
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FFB478BAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat()
; 			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,2B7CA011308
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFB47738750
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
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,77B
       mov       rdx,7FFB475E12B8
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,2B7BA012EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478AAD80]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB478B29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,2B7CA011300
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,2B7CA011300
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
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
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbp
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
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
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,2B7BA0215B8
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M03_L04
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M03_L05
M03_L04:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M03_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       test      rsi,rsi
       je        short M03_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L09
       xor       ebp,ebp
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L09
M03_L06:
       movsxd    rcx,ebp
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L07
       cmp       edi,0FFFFFFFE
       je        short M03_L07
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L08
M03_L07:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M03_L08:
       add       ebp,1
       jo        short M03_L10
       cmp       r15d,ebp
       jg        short M03_L06
M03_L09:
       mov       rcx,r14
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],41
       mov       word ptr [rax+12],5A
       mov       rcx,rdi
       mov       rdx,rax
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ContainsAny[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, Char[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]]
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
       test      rcx,rcx
       je        short M01_L02
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Char, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass3_0`1[[System.Char, System.Private.CoreLib]].<ContainsAny>b__0(Char)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Any[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>, System.Func`2<Char,Boolean>)
; Total bytes of code 161
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,26C85711028
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1B7D8843020
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,24DC1033020
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,29DCF713020
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,21F8E1F3020
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,229375C3020
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,20B27473020
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2590B063020
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,232CDAE3020
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,2868B5723A0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
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
       mov       ecx,9FE
       mov       rdx,7FFB475F12B8
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
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,1465BD31B88
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
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
       mov       ecx,9FE
       mov       rdx,7FFB475E12B8
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
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,242B0B82BA0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
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
       mov       ecx,9FE
       mov       rdx,7FFB475F12B8
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
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,252A33B33B8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
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
       mov       ecx,9FE
       mov       rdx,7FFB475E12B8
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
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,20D79EE3E48
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
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
       mov       ecx,9FE
       mov       rdx,7FFB475D12B8
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
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,26446693B80
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
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
       mov       ecx,9FE
       mov       rdx,7FFB475D12B8
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
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,271CBD74398
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
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
       mov       ecx,9FE
       mov       rdx,7FFB475F12B8
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
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,277AE232BA0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
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
       mov       ecx,9FE
       mov       rdx,7FFB475F12B8
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
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,190D8194660
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
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
       mov       ecx,9FE
       mov       rdx,7FFB475C12B8
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
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,5
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Equals(System.String, System.String, System.StringComparison)
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,2814EAE3020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,2814EAE3020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FFB47874B40]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FFB478849A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFB47224000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFB47224000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
       mov       rcx,7FFB47334928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,2814EAE1520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1D14F693020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,1D14F693020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FFB47894B40]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FFB478A49A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
       mov       rcx,7FFB47354928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1D14F691520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,27DE8643020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,27DE8643020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FFB47894C60]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FFB478A4AC1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
       mov       rcx,7FFB47354928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,27DE8641520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,2A0FC523020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,2A0FC523020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FFB47884C60]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FFB47894AC1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
       mov       rcx,7FFB47344928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,2A0FC521520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,26ADFD73020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,26ADFD73020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FFB47884B40]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FFB478949A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
       mov       rcx,7FFB47344928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,26ADFD71520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,21EA78C1028
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,21EA78C1028
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FFB47884B40]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FFB478949A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
       mov       rcx,7FFB47344928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,21EC78C1520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1F75C813020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,1F75C813020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FFB47894C60]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FFB478A4AC1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
       mov       rcx,7FFB47354928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1F75C811520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1B743603020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,1B743603020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FFB47884B40]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FFB478949A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
       mov       rcx,7FFB47344928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,1B743601520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,201AAE23020
       mov       rcx,[rcx]
M00_L00:
       test      rdx,rdx
       jne       short M00_L01
       mov       rdx,201AAE23020
       mov       rdx,[rdx]
M00_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       je        short M01_L01
       test      rsi,rsi
       je        near ptr M01_L04
       test      rdi,rdi
       je        near ptr M01_L04
       cmp       ebx,5
       jne       short M01_L03
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M01_L02
M01_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       cmp       ebx,5
       ja        near ptr M01_L07
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L03:
       cmp       ebx,5
       ja        short M01_L06
       mov       r8d,ebx
       lea       rcx,[7FFB47894B40]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[7FFB478A49A1]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M01_L00
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       cmp       ebx,5
       ja        short M01_L07
       jmp       near ptr M01_L00
M01_L05:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
       mov       rcx,7FFB47354928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,201AAE21520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M01_L05
; Total bytes of code 429
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+20]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+18]
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
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1C9CCD21B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1C9CCD21AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB478AEA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+20]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+18]
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
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1134B121B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1134B121AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB4788EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+20]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+18]
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
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,20686811B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,20686811AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB478AEA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+20]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+18]
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
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1D0D8EF1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1D0D8EF1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB4789EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+20]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+18]
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
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1F558861B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1F558861AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB478BEA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+20]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+18]
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
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1E2C4D01B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1E2C4D01AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB4787EA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+20]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+18]
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
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1CE66DC1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1CE66DC1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB478BEA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+20]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+18]
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
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,2D4F2291B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2D4F2291AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB478AEA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+20]
       call      DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+18]
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
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       mov       rdx,1F1D9C81B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1F1D9C81AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB478AEA40]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 207
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,2B8A7D91028
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,1E152963020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,175571D1028
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,14C5A7E3020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,1CC36F91028
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,208E7D53020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,1E0B1DD3020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,240CFFE3020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M01_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,20BC7023020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
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
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
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
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFB4787AB38]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
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
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
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
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFB4788AB38]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
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
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
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
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFB4789AB38]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
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
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
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
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFB4788AB38]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
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
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
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
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFB4788AB38]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
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
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
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
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFB478AAB38]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
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
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
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
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFB478AAB38]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
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
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
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
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFB478BAB38]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+18]
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
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rax,rdi
       test      rax,rax
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
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jne       short M01_L03
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       mov       ebp,1
       jmp       short M01_L07
M01_L04:
       mov       edx,[r14+18]
       mov       ecx,edx
       mov       r8,[r14+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short M01_L05
       movsxd    rcx,ecx
       mov       [r8+rcx*2+10],bx
       inc       edx
       mov       [r14+18],edx
       jmp       short M01_L06
M01_L05:
       movzx     edx,bx
       mov       rcx,r14
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L06:
       add       ebp,1
       jo        short M01_L10
M01_L07:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L08
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L11
M01_L08:
       cmp       ebp,edx
       jle       short M01_L04
       test      esi,esi
       jle       short M01_L09
       mov       rcx,r14
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFB4787AB38]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],60
       setne     dil
       movzx     edi,dil
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 93
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
       mov       rcx,[rsi+18]
       mov       [rcx+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 126
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
; 			var result = this._testCharacter.IsAsciiDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+2B8]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
       mov       rax,[rsi+18]
       mov       [rax+54],dil
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 71
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = this.TestGuid.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,1794ED63DB0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,1794ED5D7F0
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = this.TestGuid.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,1F5BDB022F0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,1F5ADB0D7F0
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = this.TestGuid.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,1EE84E145B0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,1EE84E0D7F0
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = this.TestGuid.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,2A593BC2B08
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,2A5B3BCD7F0
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = this.TestGuid.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,25B6E3422F0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,25B7E34D7F0
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = this.TestGuid.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,23B855A3DB0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,23B8559D7F0
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = this.TestGuid.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,2124E794DC8
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,2124E78D7F0
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = this.TestGuid.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,27A4F201AF0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,27A5F20D7F0
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = this.TestGuid.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+1B8]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; System.Guid.ToString()
       mov       rdx,27ADB2F3DB0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       xor       eax,eax
       ret
M02_L00:
       mov       rdx,27ADB2ED7F0
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var result = MacAddress.IsMacAddress();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,2897DE24660
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,2897DE1D7F8
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var result = MacAddress.IsMacAddress();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,27CBB5E2BA0
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,27CAB5ED7F8
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var result = MacAddress.IsMacAddress();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1DA1D081B88
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,1DA0D08D7F8
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var result = MacAddress.IsMacAddress();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,245F3B01B88
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,24603B0B3E8
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var result = MacAddress.IsMacAddress();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,211D5BC5678
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,211D5BBD7F8
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var result = MacAddress.IsMacAddress();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,2DA0C471B88
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,2DA1C47D7F8
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var result = MacAddress.IsMacAddress();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,24C09501B88
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,24BE950D7F8
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var result = MacAddress.IsMacAddress();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,2BA32C71B88
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,2BA42C7B800
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var result = MacAddress.IsMacAddress();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,21E32EF2BA0
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       [rsp+8],rcx
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       xor       eax,eax
       ret
M01_L00:
       mov       rdx,21E42EFD7F8
       mov       rcx,[rdx]
       mov       rdx,[rsp+8]
       cmp       [rcx],ecx
       jmp       near ptr System.Text.RegularExpressions.Regex.IsMatch(System.String)
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       mov       rdx,1FF92153020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
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
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1FF92165678
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M01_L02:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       mov       rdx,244CC013020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
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
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,244CC024E60
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M01_L02:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       mov       rdx,2B53EEC3020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
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
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,2B54EEC2BA0
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M01_L02:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       mov       rdx,1CEE6BD1028
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
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
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1CF06BD3B80
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M01_L02:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       mov       rdx,25DF0133020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
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
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,25DF0136FA8
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M01_L02:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       mov       rdx,1A929083020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
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
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1A929095678
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M01_L02:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       mov       rdx,1FA20983020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
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
       mov       ecx,65D
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1FA10981B88
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M01_L02:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       mov       rdx,20D96233020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
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
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,20D96244660
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M01_L02:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       mov       rdx,2042F733020
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+18]
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
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
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
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,2042F744660
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       r9d,9
       add       rsp,20
       pop       rsi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
M01_L02:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 127
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2B0]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
; 			foreach (LineSplitEntry line in this._crlfString.SplitLines())
; 			                             ^^
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
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
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2B0]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
; 			foreach (LineSplitEntry line in this._crlfString.SplitLines())
; 			                             ^^
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
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
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2B0]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
; 			foreach (LineSplitEntry line in this._crlfString.SplitLines())
; 			                             ^^
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
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
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2B0]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
; 			foreach (LineSplitEntry line in this._crlfString.SplitLines())
; 			                             ^^
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
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
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2B0]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
; 			foreach (LineSplitEntry line in this._crlfString.SplitLines())
; 			                             ^^
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
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
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2B0]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
; 			foreach (LineSplitEntry line in this._crlfString.SplitLines())
; 			                             ^^
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
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
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2B0]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
; 			foreach (LineSplitEntry line in this._crlfString.SplitLines())
; 			                             ^^
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
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
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2B0]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
; 			foreach (LineSplitEntry line in this._crlfString.SplitLines())
; 			                             ^^
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB476012B8
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
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitLines()
       push      rdi
       push      rsi
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0B0],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2B0]
       lea       rcx,[rsp+58]
       call      DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0A8],xmm0
; 			foreach (LineSplitEntry line in this._crlfString.SplitLines())
; 			                             ^^
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdi,[rsi+18]
       lea       rcx,[rsp+38]
       mov       rax,[rcx]
       mov       [rsp+28],rax
       mov       ecx,[rcx+8]
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       cmp       [rdi],edi
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsp+88]
       call      DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L01
M00_L02:
       add       rsp,0B8
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 273
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitLines(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
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
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
M01_L02:
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       mov       [rcx+8],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdi,rbx
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L04:
       xor       eax,eax
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 221
```
```assembly
; DotNetTips.Spargine.Core.LineSplitEnumerator.MoveNext()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rbx,rcx
       mov       rbp,[rbx]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jne       short M02_L01
       xor       eax,eax
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       edx,0D
       mov       r8d,0A
       mov       r9d,r14d
       call      System.SpanHelpers.IndexOfAny(Char ByRef, Char, Char, Int32)
       mov       r15d,eax
       cmp       r15d,0FFFFFFFF
       jne       short M02_L02
       xor       eax,eax
       mov       [rbx],rax
       xor       eax,eax
       mov       [rbx+8],eax
       lea       rdx,[rsp+80]
       mov       [rdx],rbp
       mov       [rdx+8],r14d
       lea       rdx,[rsp+90]
       mov       [rdx],rax
       xor       eax,eax
       mov       [rdx+8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+60]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       eax,r14d
       sub       eax,1
       jo        near ptr M02_L04
       cmp       r15d,eax
       jge       near ptr M02_L03
       cmp       r15d,r14d
       jae       near ptr M02_L06
       movsxd    rax,r15d
       cmp       word ptr [rbp+rax*2],0D
       jne       near ptr M02_L03
       mov       eax,r15d
       add       eax,1
       jo        near ptr M02_L04
       cmp       eax,r14d
       jae       near ptr M02_L06
       movsxd    rax,eax
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,0A
       jne       near ptr M02_L03
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+2]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0B0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],2
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       r15d,2
       jo        near ptr M02_L04
       cmp       r15d,r14d
       ja        near ptr M02_L05
       mov       eax,r14d
       sub       eax,r15d
       mov       edx,r15d
       lea       rdx,[rbp+rdx*2]
       mov       [rbx],rdx
       mov       [rbx+8],eax
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       r12d,r15d
       mov       eax,r14d
       cmp       r12,rax
       ja        near ptr M02_L05
       mov       rax,rbp
       lea       rdx,[r12+1]
       mov       ecx,r14d
       cmp       rdx,rcx
       ja        near ptr M02_L05
       lea       rax,[rax+r12*2]
       lea       rdx,[rsp+0C0]
       mov       [rdx],rbp
       mov       [rdx+8],r15d
       lea       rdx,[rsp+0D0]
       mov       [rdx],rax
       mov       dword ptr [rdx+8],1
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdi,[rbx+10]
       lea       rsi,[rsp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       eax,r15d
       add       eax,1
       jo        short M02_L04
       cmp       eax,r14d
       ja        short M02_L05
       mov       edx,r14d
       sub       edx,eax
       mov       eax,eax
       lea       rax,[rbp+rax*2]
       mov       [rbx],rax
       mov       [rbx+8],edx
       mov       eax,1
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
M02_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 44
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+60]
       mov       rdx,[rsi+70]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+18]
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
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A18
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       ecx,65D
       mov       rdx,7FFB475E12B8
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
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,1BFD6813020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,1BFD6813020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AE0
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A4A
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0AF6
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AE0
       mov       rdx,7FFB475E12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
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
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,1B6E1783020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,1B6E1783020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AE0
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A4A
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0AF6
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AE0
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
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
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,1C3FA503020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,1C3FA503020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AE0
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A4A
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0AF6
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AE0
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
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
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,15CA3C23020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,15CA3C23020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AE0
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A4A
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0AF6
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AE0
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       ecx,65D
       mov       rdx,7FFB475F12B8
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
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,2029A843020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,2029A843020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AE0
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A4A
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0AF6
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AE0
       mov       rdx,7FFB475F12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
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
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,25BE5B03020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,25BE5B03020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AE0
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A4A
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0AF6
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AE0
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       ecx,65D
       mov       rdx,7FFB475C12B8
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
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,16CEB503020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,16CEB503020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AE0
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A4A
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0AF6
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AE0
       mov       rdx,7FFB475C12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       ecx,65D
       mov       rdx,7FFB476012B8
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
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,2A6B3173020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,2A6B3173020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AE0
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A4A
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0AF6
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AE0
       mov       rdx,7FFB476012B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+18]
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       ecx,65D
       mov       rdx,7FFB475D12B8
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
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,26C35D93020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,26C35D93020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AE0
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A4A
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0AF6
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AE0
       mov       rdx,7FFB475D12B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			Consumer.Consume(this.LowerCaseString.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478B07E8]
       mov       rcx,rax
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478B07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFB47364928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,205AA4A1578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,205AA4A1558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,205BA4B1270
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,205BA4B1278
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB478AAB38]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			Consumer.Consume(this.LowerCaseString.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478B07E8]
       mov       rcx,rax
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478B07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFB47364928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2B4DFED1578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2B4DFED1558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,2B4DFED5F90
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,2B4DFED5F98
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB478AAB38]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			Consumer.Consume(this.LowerCaseString.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478B07E8]
       mov       rcx,rax
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478B07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFB47364928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,17122C71578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,17122C71558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,17112C71B88
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,17112C71B90
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB478AAB38]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			Consumer.Consume(this.LowerCaseString.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472707E8
       call      qword ptr [7FFB478C07E8]
       mov       rcx,rax
       mov       r11,7FFB472707F0
       call      qword ptr [7FFB478C07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFB47374928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,227ADDC1578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,227ADDC1558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,2277DDC1B88
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,2277DDC1B90
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB478BAB38]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFB47264000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			Consumer.Consume(this.LowerCaseString.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478A07E8]
       mov       rcx,rax
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFB47354928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,1E588B51578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,1E588B51558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,1E588B65678
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,1E588B65680
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB4789AB38]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			Consumer.Consume(this.LowerCaseString.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478B07E8]
       mov       rcx,rax
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478B07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFB47364928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,23CD9FE1578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,23CD9FE1558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,23CE9FE1B88
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,23CE9FE1B90
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB478AAB38]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			Consumer.Consume(this.LowerCaseString.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472407E8
       call      qword ptr [7FFB478907E8]
       mov       rcx,rax
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478907F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFB47344928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,21230551578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,21230551558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,21250552BA0
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,21250552BA8
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB4788AB38]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			Consumer.Consume(this.LowerCaseString.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472407E8
       call      qword ptr [7FFB478907E8]
       mov       rcx,rax
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478907F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFB47344928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,1FD2F871578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,1FD2F871558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,1FD2F884660
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,1FD2F884668
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB4788AB38]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			Consumer.Consume(this.LowerCaseString.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+18]
       mov       rdi,[rcx+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rdx,rax
M00_L01:
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478B07E8]
       mov       rcx,rax
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478B07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFB47364928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,17C74661578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,17C74661558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+88],rdx
       mov       rsi,rcx
       cmp       qword ptr [rsp+88],0
       je        near ptr M03_L40
       mov       rax,[rsp+88]
       cmp       dword ptr [rax+8],0
       jne       short M03_L00
       mov       rax,[rsp+88]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
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
       mov       [rsp+30],rdi
       xor       edi,edi
       mov       rcx,[rsi+20]
       mov       rdx,17C84661B88
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15+0FFFF]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,17C84661B90
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB478AAB38]
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478B07E8]
       mov       rcx,rax
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478B07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,1D9D6383020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478A07E8]
       mov       rcx,rax
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,15D1F8E3020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472707E8
       call      qword ptr [7FFB478C07E8]
       mov       rcx,rax
       mov       r11,7FFB472707F0
       call      qword ptr [7FFB478C07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,1F2C0643020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472707E8
       call      qword ptr [7FFB478C07E8]
       mov       rcx,rax
       mov       r11,7FFB472707F0
       call      qword ptr [7FFB478C07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,25ABF523020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472707E8
       call      qword ptr [7FFB478C07E8]
       mov       rcx,rax
       mov       r11,7FFB472707F0
       call      qword ptr [7FFB478C07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,15242263020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478B07E8]
       mov       rcx,rax
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478B07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,153E6033020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472407E8
       call      qword ptr [7FFB478907E8]
       mov       rcx,rax
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478907F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,2A580073020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478A07E8]
       mov       rcx,rax
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,23182693020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       mov       rdx,rdi
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
M00_L01:
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478A07E8]
       mov       rcx,rax
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478A07F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M02_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFBA64D12C0
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,21801253020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```

