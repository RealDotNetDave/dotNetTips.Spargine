## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
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
       mov       rax,2CE1CB01028
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,2CE1CB0FE78
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
       mov       rcx,2CDFCB01BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2694CB78]
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
       mov       rdx,2CDFCB01568
       mov       r12,[rdx]
       mov       rdx,2CE2CB01B58
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
       call      qword ptr [7FFF269478C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF2694B810]
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
       call      qword ptr [7FFF2694B810]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
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
       mov       rax,127D5E23020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,127B5E21638
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
       mov       rcx,127D5E21BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2693CB78]
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
       mov       rdx,127D5E21568
       mov       r12,[rdx]
       mov       rdx,127D5E32390
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
       call      qword ptr [7FFF269378C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF2693B810]
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
       call      qword ptr [7FFF2693B810]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
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
       mov       rax,13ABD6A1028
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,13ADD6AFA60
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
       mov       rcx,13AED6A1BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2694CB78]
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
       mov       rdx,13AED6A1568
       mov       r12,[rdx]
       mov       rdx,13ADD6B17B0
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
       call      qword ptr [7FFF269478C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF2694B810]
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
       call      qword ptr [7FFF2694B810]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
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
       mov       rax,25FDA093020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,25FFA091638
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
       mov       rcx,25FDA091BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2697CB78]
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
       mov       rdx,25FDA091568
       mov       r12,[rdx]
       mov       rdx,25FFA092370
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
       call      qword ptr [7FFF269778C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF2697B810]
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
       call      qword ptr [7FFF2697B810]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
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
       mov       rax,1E57CB13020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,1E57CB21E70
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
       mov       rcx,1E57CB11BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2695CB78]
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
       mov       rdx,1E57CB11568
       mov       r12,[rdx]
       mov       rdx,1E57CB22BA8
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
       call      qword ptr [7FFF269578C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF2695B810]
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
       call      qword ptr [7FFF2695B810]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
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
       mov       rax,29C82F81028
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,29C82F83A48
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
       mov       rcx,29C92F81BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2696CB78]
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
       mov       rdx,29C92F81568
       mov       r12,[rdx]
       mov       rdx,29C82F84780
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
       call      qword ptr [7FFF269678C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF2696B810]
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
       call      qword ptr [7FFF2696B810]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
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
       mov       rax,23B2A213020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,23B4A211638
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
       mov       rcx,23B2A211BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2695CB78]
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
       mov       rdx,23B2A211568
       mov       r12,[rdx]
       mov       rdx,23B2A222390
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
       call      qword ptr [7FFF269578C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF2695B810]
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
       call      qword ptr [7FFF2695B810]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
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
       mov       rax,2032AF61028
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,2030AF61638
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
       mov       rcx,2031AF61BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2693CB78]
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
       mov       rdx,2031AF61568
       mov       r12,[rdx]
       mov       rdx,2031AF70F98
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
       call      qword ptr [7FFF269378C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF2693B810]
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
       call      qword ptr [7FFF2693B810]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
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
       mov       rax,16E0B653020
       mov       rax,[rax]
       mov       [rbp+0FFC0],rax
       mov       rax,16E0B659ED8
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
       mov       rcx,16E0B651BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF2695CB78]
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
       mov       rdx,16E0B651568
       mov       r12,[rdx]
       mov       rdx,16DEB651B58
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
       call      qword ptr [7FFF269578C0]
       mov       [rbp+0FFC0],rax
       jmp       short M01_L04
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF2695B810]
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
       call      qword ptr [7FFF2695B810]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,18975AF3300
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
; Total bytes of code 137
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
       mov       rdx,18975AF3020
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
       mov       rdx,18975AF5BE8
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
       mov       rdx,18975AF5ED0
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
       mov       rdx,18975AF5ED8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B00E40]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26ADBB00
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18975AF2FC8
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
       mov       rdx,7FFF26B86478
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
       mov       rdx,7FFF26B86498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26B86488
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
       mov       rdx,7FFF26B864B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26B865C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26B865D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26B86488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26B86488
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
       mov       rax,18975AF3020
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
       mov       rdx,18975AF58C0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,18975AF5AA0
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
       call      qword ptr [7FFF26B078C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,2A1D51F3300
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
; Total bytes of code 137
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
       mov       rdx,2A1D51F3020
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
       mov       rdx,2A1F51FDC10
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
       mov       rdx,2A1D51F56B8
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
       mov       rdx,2A1D51F56C0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B10E40]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AEBB00
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2A1D51F2FC8
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
       mov       rdx,7FFF26B96478
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
       mov       rdx,7FFF26B96498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26B96488
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
       mov       rdx,7FFF26B964B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26B965C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26B965D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26B96488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26B96488
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
       mov       rax,2A1D51F3020
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
       mov       rdx,2A1F51FD8E8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,2A1F51FDAC8
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
       call      qword ptr [7FFF26B178C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,20675C13300
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
; Total bytes of code 137
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
       mov       rdx,20675C13020
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
       mov       rdx,20675C15BE8
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
       mov       rdx,20675C15ED0
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
       mov       rdx,20675C15ED8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B10E40]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AEBB00
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20675C12FC8
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
       mov       rdx,7FFF26B96478
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
       mov       rdx,7FFF26B96498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26B96488
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
       mov       rdx,7FFF26B964B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26B965C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26B965D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26B96488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26B96488
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
       mov       rax,20675C13020
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
       mov       rdx,20675C158C0
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,20675C15AA0
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
       call      qword ptr [7FFF26B178C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,1DF05461308
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
; Total bytes of code 137
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
       mov       rdx,1DF05461028
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
       mov       rdx,1DF254617E0
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
       mov       rdx,1DEF546E6F8
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
       mov       rdx,1DEF546E700
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B20E40]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AFBB00
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DF15462FC8
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
       mov       rdx,7FFF26BA6478
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
       mov       rdx,7FFF26BA6498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26BA6488
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
       mov       rdx,7FFF26BA64B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26BA65C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26BA65D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26BA6488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26BA6488
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
       mov       rax,1DF05461028
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
       mov       rdx,1DF254614B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,1DF25461698
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
       call      qword ptr [7FFF26B278C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,1F444C83300
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
; Total bytes of code 137
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
       mov       rdx,1F444C83020
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
       mov       rdx,1F474C817E0
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
       mov       rdx,1F474C81AC8
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
       mov       rdx,1F474C81AD0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B20E40]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AFBB00
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F444C82FC8
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
       mov       rdx,7FFF26BA6478
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
       mov       rdx,7FFF26BA6498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26BA6488
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
       mov       rdx,7FFF26BA64B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26BA65C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26BA65D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26BA6488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26BA6488
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
       mov       rax,1F444C83020
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
       mov       rdx,1F474C814B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,1F474C81698
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
       call      qword ptr [7FFF26B278C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,1B5EA063300
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
; Total bytes of code 137
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
       mov       rdx,1B5EA063020
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
       mov       rdx,1B60A0617E0
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
       mov       rdx,1B60A061AC8
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
       mov       rdx,1B60A061AD0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26AF0E40]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26ACBB00
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1B5EA062FC8
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
       mov       rdx,7FFF26B76478
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
       mov       rdx,7FFF26B76498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26B76488
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
       mov       rdx,7FFF26B764B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26B765C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26B765D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26B76488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26B76488
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
       mov       rax,1B5EA063020
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
       mov       rdx,1B60A0614B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,1B60A061698
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
       call      qword ptr [7FFF26AF78C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,18295453300
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
; Total bytes of code 137
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
       mov       rdx,18295453020
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
       mov       rdx,182B54517E0
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
       mov       rdx,18295461AE8
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
       mov       rdx,18295461AF0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B00E40]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26ADBB00
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18295452FC8
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
       mov       rdx,7FFF26B86478
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
       mov       rdx,7FFF26B86498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26B86488
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
       mov       rdx,7FFF26B864B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26B865C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26B865D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26B86488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26B86488
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
       mov       rax,18295453020
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
       mov       rdx,182B54514B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,182B5451698
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
       call      qword ptr [7FFF26B078C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,168E4CC1308
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
; Total bytes of code 137
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
       mov       rdx,168E4CC1028
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
       mov       rdx,168D4CCDC10
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
       mov       rdx,168B4CC42C0
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
       mov       rdx,168B4CC42C8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B20E40]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AFBB00
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,168B4CC2FC8
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
       mov       rdx,7FFF26BA6478
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
       mov       rdx,7FFF26BA6498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26BA6488
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
       mov       rdx,7FFF26BA64B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26BA65C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26BA65D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26BA6488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26BA6488
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
       mov       rax,168E4CC1028
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
       mov       rdx,168D4CCD8E8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,168D4CCDAC8
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
       call      qword ptr [7FFF26B278C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r9,rax
       mov       rdx,23676CD1308
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
; Total bytes of code 137
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
       mov       rdx,23676CD1028
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
       mov       rdx,23696CD17E0
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
       mov       rdx,23696CD2AE0
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
       mov       rdx,23696CD2AE8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B10E40]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AEBB00
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23686CD2FC8
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
       mov       rdx,7FFF26B96720
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
       mov       rdx,7FFF26B96740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26B96730
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
       mov       rdx,7FFF26B96758
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26B96868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26B96880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26B96730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26B96730
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
       mov       rax,23676CD1028
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
       mov       rdx,23696CD14B8
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L04:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rdx,23696CD1698
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
       call      qword ptr [7FFF26B178C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
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
       mov       rcx,18D29BA3020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
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
       mov       rcx,1AFF1673020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
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
       mov       rcx,262BFC73020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
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
       mov       rcx,19A78A93020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
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
       mov       rcx,23CEE6B3020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
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
       mov       rcx,23201771028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
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
       mov       rcx,24411033020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
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
       mov       rcx,2421B9C3020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
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
       mov       rcx,25447EA1028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,203F25BEFA0
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
       mov       rax,203E25B3020
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
       mov       rdx,203F25BEFA8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1C7904E2BA8
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
       mov       rax,1C7904D3020
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
       mov       rdx,1C7904E2BB0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1B0210C5F60
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
       mov       rax,1B0210C3020
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
       mov       rdx,1B0210C5F68
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1BAA47F5F60
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
       mov       rax,1BAA47F3020
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
       mov       rdx,1BAA47F5F68
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,21177EF2370
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
       mov       rax,21157EF3020
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
       mov       rdx,21177EF2378
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2AA2AEB2390
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
       mov       rax,2AA2AEA3020
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
       mov       rdx,2AA2AEB2398
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2341F1F1BC8
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
       mov       rax,2341F1E1028
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
       mov       rdx,2341F1F1BD0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2126374DF88
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
       mov       rax,21233743020
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
       mov       rdx,2126374DF90
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,21AFC6B2370
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
       mov       rax,21ADC6B3020
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
       mov       rdx,21AFC6B2378
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
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
       mov       rax,243B5631028
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
       mov       rdx,243D563B448
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
       mov       rdx,243D563C300
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
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
       mov       rax,1AA79C23020
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
       mov       rdx,1AA99C2D8E8
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
       mov       rdx,1AAA9C22B70
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
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
       mov       rax,26AF2F33020
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
       mov       rdx,26AF2F41CF0
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
       mov       rdx,26AF2F42BA8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
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
       mov       rax,1EE2A233020
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
       mov       rdx,1EE4A2314B8
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
       mov       rdx,1EE4A232370
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
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
       mov       rax,1B742503020
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
       mov       rdx,1B7225014B8
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
       mov       rdx,1B742512390
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
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
       mov       rax,1AEF0243020
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
       mov       rdx,1AEF02458C0
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
       mov       rdx,1AF10242B70
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
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
       mov       rax,2460DB71028
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
       mov       rdx,2462DB734B0
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
       mov       rdx,2462DB74368
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
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
       mov       rax,24D01863020
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
       mov       rdx,24D018658C0
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
       mov       rdx,24CE1861B58
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
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
       mov       rax,213B4CD1028
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
       mov       rdx,213D4CDD8E8
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
       mov       rdx,213B4CD3F68
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
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
       mov       rcx,2D111CF3020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,2D111CF3020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
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
       mov       rcx,25C822C1028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,25C822C1028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
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
       mov       rcx,23969301028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,23969301028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
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
       mov       rcx,1F825B13020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1F825B13020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
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
       mov       rcx,2301F2D3020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,2301F2D3020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
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
       mov       rcx,1AC88DC3020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1AC88DC3020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
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
       mov       rcx,24A10023020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,24A10023020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
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
       mov       rcx,1B0A2773020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1B0A2773020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
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
       mov       rcx,1B5BEDF3020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1B5BEDF3020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
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
       mov       rax,18CD8AF3020
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
       mov       rdx,18CD8AF9D58
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
       mov       rdx,18CD8AF1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,18CD8AF1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF26B0EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
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
       mov       rax,23C6E1F1028
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
       mov       rdx,23C8E1FD8E8
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
       mov       rdx,23C7E1F1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,23C7E1F1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF26B2EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
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
       mov       rax,2BDDE463020
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
       mov       rdx,2BDFE4614B8
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
       mov       rdx,2BDDE461B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2BDDE461AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF26B1EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
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
       mov       rax,12A899A1028
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
       mov       rdx,12A899A7D60
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
       mov       rdx,12A699A1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,12A699A1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF26B3EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
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
       mov       rax,1E46F2F3020
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
       mov       rdx,1E46F301CF0
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
       mov       rdx,1E46F2F1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1E46F2F1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF26B1EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
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
       mov       rax,21175E71028
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
       mov       rdx,21165E714B8
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
       mov       rdx,21155E71B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21155E71AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF26B0EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
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
       mov       rax,222EA883020
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
       mov       rdx,2230A8814B8
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
       mov       rdx,222EA881B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,222EA881AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF26B1EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
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
       mov       rax,25B3F2E3020
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
       mov       rdx,25B3F2F1CF0
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
       mov       rdx,25B3F2E1B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,25B3F2E1AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF26B2EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
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
       mov       rax,1989A041028
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
       mov       rdx,198AA0414B8
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
       mov       rdx,1988A041B00
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1988A041AE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF26B2EA40]
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 215
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
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
       mov       rax,22D82621028
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
       mov       rdx,22DA262B448
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
       call      qword ptr [7FFF269578C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
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
       mov       rax,18380373020
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
       mov       rdx,18380381CF0
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
       call      qword ptr [7FFF269678C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
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
       mov       rax,19710513020
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
       mov       rdx,197305114B8
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
       call      qword ptr [7FFF269378C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
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
       mov       rax,27AD6803020
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
       mov       rdx,27AF68014B8
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
       call      qword ptr [7FFF269678C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
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
       mov       rax,22CE3293020
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
       mov       rdx,22D032914B8
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
       call      qword ptr [7FFF269478C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
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
       mov       rax,2333F733020
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
       mov       rdx,2335F73F8E0
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
       call      qword ptr [7FFF269678C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
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
       mov       rax,18504D21028
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
       mov       rdx,18524D234B0
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
       call      qword ptr [7FFF269578C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
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
       mov       rax,1C124FD3020
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
       mov       rdx,1C154FD14B8
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
       call      qword ptr [7FFF269578C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
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
       mov       rax,27826993020
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
       mov       rdx,278269A1CF0
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
       call      qword ptr [7FFF269578C0]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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
       mov       rcx,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiWhitespace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+130]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
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
       mov       rdx,230082922B8
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
       mov       rdx,23008292B70
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
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
       mov       rdx,27258E522F0
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
       mov       rdx,27258E52BA8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
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
       mov       rdx,20EBCDA3308
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
       mov       rdx,20EBCDA3BC0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
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
       mov       rdx,19AE0B456A8
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
       mov       rdx,19AE0B45F60
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
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
       mov       rdx,1A665892AD0
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
       mov       rdx,1A665893388
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
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
       mov       rdx,265777E3308
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
       mov       rdx,265777E3BC0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
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
       mov       rdx,1861A8CD6D0
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
       mov       rdx,1861A8CDF88
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
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
       mov       rdx,1D6764212A0
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
       mov       rdx,1D676421B58
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
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
       mov       rdx,143ED3612A0
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
       mov       rdx,143ED361B58
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1D7FAE9E7A0
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
       mov       rdx,1D7FAE9E7A8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1E16D222F88
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
       mov       rdx,1E16D222F90
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,22DEB751B58
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
       mov       rdx,22DEB751B60
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1E4481F1B58
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
       mov       rdx,1E4481F1B60
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,2B6A4B53BC0
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
       mov       rdx,2B6A4B53BC8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,274944C2370
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
       mov       rdx,274944C2378
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1F0CEE42370
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
       mov       rdx,1F0CEE42378
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1936E76DF88
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
       mov       rdx,1936E76DF90
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,2249AEB0798
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
       mov       rdx,2249AEB07A0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+128]
       mov       rdx,16449D53020
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
       mov       rax,16449D53020
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
       mov       rdx,16469D514B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,16449D62390
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+128]
       mov       rdx,1CEB0B13020
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
       mov       rax,1CEB0B13020
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
       mov       rdx,1CED0B114B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1CEB0B15F60
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+128]
       mov       rdx,2378BBC3020
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
       mov       rax,2378BBC3020
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
       mov       rdx,237ABBC14B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,2378BBC5F60
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+128]
       mov       rdx,224A4343020
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
       mov       rax,224A4343020
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
       mov       rdx,224A4351CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,224A4352BA8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+128]
       mov       rdx,21E35053020
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
       mov       rax,21E35053020
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
       mov       rdx,21E35061CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,21E35062BA8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+128]
       mov       rdx,29676F53020
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
       mov       rax,29676F53020
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
       mov       rdx,29686F514B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,29696F51B58
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+128]
       mov       rdx,1A2C3C33020
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
       mov       rax,1A2C3C33020
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
       mov       rdx,1A2F3C3D8E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,1A2C3C36F78
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+128]
       mov       rdx,2C3A2F73020
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
       mov       rax,2C3A2F73020
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
       mov       rdx,2C3A2F758C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,2C382F72B70
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+128]
       mov       rdx,18185C03020
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
       mov       rax,18185C03020
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
       mov       rdx,181A5C014B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       mov       rdx,18185C12390
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
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
       mov       rax,239CCA93020
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
       mov       rdx,239DCA914B8
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
       mov       rdx,239ACA92B70
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
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
       mov       rax,28876AE1028
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
       mov       rdx,28876AEFCF8
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
       mov       rdx,28856AE2B70
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
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
       mov       rax,1DCE6493020
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
       mov       rdx,1DCE64958C0
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
       mov       rdx,1DCE6496778
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
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
       mov       rax,22151043020
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
       mov       rdx,22151051CF0
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
       mov       rdx,22131041B58
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
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
       mov       rax,20DF3EB3020
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
       mov       rdx,20E13EB5950
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
       mov       rdx,20E13EB6808
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
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
       mov       rax,29998EE1028
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
       mov       rdx,299B8EF18D8
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
       mov       rdx,29998EE2F88
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
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
       mov       rax,1F328623020
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
       mov       rdx,1F328631CF0
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
       mov       rdx,1F328633BC0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
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
       mov       rax,22C98711028
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
       mov       rdx,22CA87114B8
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
       mov       rdx,22CB8714B68
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
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
       mov       rax,22497AB3020
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
       mov       rdx,22497AC1CF0
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
       mov       rdx,22497AC2BA8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
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
       mov       rax,1CFCCB13020
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
       mov       rdx,1CFDCB114B8
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
       mov       rdx,1CFDCB12370
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
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
       mov       rax,1EBE5FB3020
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
       mov       rdx,1EC05FBF8E0
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
       mov       rdx,1EC05FC0798
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
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
       mov       rax,197D9BA1028
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
       mov       rdx,197F9BA34B0
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
       mov       rdx,19809BAEFA0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
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
       mov       rax,269E1AA3020
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
       mov       rdx,26A11AA14B8
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
       mov       rdx,269E1AB2390
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
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
       mov       rax,24B66FB3020
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
       mov       rdx,24B86FB14B8
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
       mov       rdx,24B66FB5F60
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
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
       mov       rax,18C82B21028
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
       mov       rdx,18CA2B234B0
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
       mov       rdx,18C82B23F68
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
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
       mov       rax,1E7DFB03020
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
       mov       rdx,1E7DFB11CF0
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
       mov       rdx,1E7DFB13BC0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
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
       mov       rax,1C430323020
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
       mov       rdx,1C4503214B8
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
       mov       rdx,1C46032EFA0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
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
       mov       rax,26690871028
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
       mov       rdx,266C087D8E8
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
       mov       rdx,266B0873B50
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
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
       mov       rax,22649BF3020
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
       mov       rdx,22669BF14B8
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
       mov       rcx,22649BF3270
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
       mov       rcx,22649BF3260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,22669BF2370
       mov       rcx,[rcx]
       mov       rdx,22649BF3270
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
       mov       rax,7FFF857E1240
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
       mov       rax,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
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
       mov       rax,13358573020
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
       mov       rdx,13358581CF0
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
       mov       rcx,13358573270
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
       mov       rcx,13358573260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,13358582BA8
       mov       rcx,[rcx]
       mov       rdx,13358573270
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
       mov       rax,7FFF857E1240
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
       mov       rax,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
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
       mov       rax,2862D471028
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
       mov       rdx,2864D4734B0
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
       mov       rcx,2862D471278
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
       mov       rcx,2862D471268
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,2864D474368
       mov       rcx,[rcx]
       mov       rdx,2862D471278
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
       mov       rax,7FFF857E1240
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
       mov       rax,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
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
       mov       rax,1E0B04E1028
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
       mov       rdx,1E0D04EF8E0
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
       mov       rcx,1E0B04E1278
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
       mov       rcx,1E0B04E1268
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,1E0B04E3F68
       mov       rcx,[rcx]
       mov       rdx,1E0B04E1278
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
       mov       rax,7FFF857E1240
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
       mov       rax,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
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
       mov       rax,18D0AB33020
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
       mov       rdx,18D2AB3D8E8
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
       mov       rcx,18D0AB33270
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
       mov       rcx,18D0AB33260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,18D2AB3E7A0
       mov       rcx,[rcx]
       mov       rdx,18D0AB33270
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
       mov       rax,7FFF857E1240
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
       mov       rax,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
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
       mov       rax,1E00CFD3020
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
       mov       rdx,1E00CFE1CF0
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
       mov       rcx,1E00CFD3270
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
       mov       rcx,1E00CFD3260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,1E00CFE2BA8
       mov       rcx,[rcx]
       mov       rdx,1E00CFD3270
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
       mov       rax,7FFF857E1240
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
       mov       rax,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
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
       mov       rax,2E111181028
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
       mov       rdx,2E1311814B8
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
       mov       rcx,2E111181278
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
       mov       rcx,2E111181268
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,2E111190398
       mov       rcx,[rcx]
       mov       rdx,2E111181278
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
       mov       rax,7FFF857E1240
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
       mov       rax,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
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
       mov       rax,1ED48513020
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
       mov       rdx,1ED685114B8
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
       mov       rcx,1ED48513270
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
       mov       rcx,1ED48513260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,1ED68513388
       mov       rcx,[rcx]
       mov       rdx,1ED48513270
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
       mov       rax,7FFF857E1240
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
       mov       rax,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
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
       mov       rax,238E6233020
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
       mov       rdx,239062314B8
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
       mov       rcx,238E6233270
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
       mov       rcx,238E6233260
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L06:
       mov       r14d,[rdi+8]
       mov       ecx,r14d
       sub       ecx,ebx
       jo        near ptr M01_L19
       cmp       ecx,esi
       jg        short M01_L07
       mov       rcx,238E6242390
       mov       rcx,[rcx]
       mov       rdx,238E6233270
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
       mov       rax,7FFF857E1240
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
       mov       rax,7FFF857E1240
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
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
; Total bytes of code 121
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
       mov       rdx,128E3593020
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
       mov       rdx,128E35A2018
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
       mov       rdx,128C35912B0
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
       mov       rdx,128C35912B8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B20FC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AFC080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,128E3592FC8
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
       mov       rdx,7FFF26BA9980
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
       mov       rdx,7FFF26BA99A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9990
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
       mov       rdx,7FFF26BA99B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9990
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
       mov       rdx,7FFF26BA04F8
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
       mov       rax,128E3593020
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
       mov       rdx,7FFF26BA05C8
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
       mov       rdx,7FFF26BA0708
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
       call      qword ptr [7FFF26B378C0]
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
       mov       rax,128E3593020
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
       mov       rdx,128E35A1CF0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
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
; Total bytes of code 121
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
       mov       rdx,172FA083020
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
       mov       rdx,1731A0817E0
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
       mov       rdx,172FA0866D0
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
       mov       rdx,172FA0866D8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B20FC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AFC080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,172FA082FC8
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
       mov       rdx,7FFF26BA8960
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
       mov       rdx,7FFF26BA8980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8970
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
       mov       rdx,7FFF26BA8998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8970
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
       mov       rdx,7FFF26BA04F8
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
       mov       rax,172FA083020
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
       mov       rdx,7FFF26BA05C8
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
       mov       rdx,7FFF26BA0708
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
       call      qword ptr [7FFF26B378C0]
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
       mov       rax,172FA083020
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
       mov       rdx,1731A0814B8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
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
; Total bytes of code 121
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
       mov       rdx,1E438AF3020
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
       mov       rdx,1E438B02018
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
       mov       rdx,1E418AF12B0
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
       mov       rdx,1E418AF12B8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B20FC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AFC080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E438AF2FC8
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
       mov       rdx,7FFF26BA9980
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
       mov       rdx,7FFF26BA99A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9990
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
       mov       rdx,7FFF26BA99B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26BA9990
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
       mov       rdx,7FFF26BA04F8
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
       mov       rax,1E438AF3020
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
       mov       rdx,7FFF26BA05C8
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
       mov       rdx,7FFF26BA0708
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
       call      qword ptr [7FFF26B378C0]
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
       mov       rax,1E438AF3020
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
       mov       rdx,1E438B01CF0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
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
; Total bytes of code 121
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
       mov       rdx,21935413020
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
       mov       rdx,219554117E0
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
       mov       rdx,219354156B8
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
       mov       rdx,219354156C0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B00FC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26ADC080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,21935412FC8
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
       mov       rdx,7FFF26B89920
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
       mov       rdx,7FFF26B89940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26B89930
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
       mov       rdx,7FFF26B89958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26B89A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26B89A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26B89930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26B89930
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
       mov       rdx,7FFF26B804F8
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
       mov       rax,21935413020
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
       mov       rdx,7FFF26B805C8
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
       mov       rdx,7FFF26B80708
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
       call      qword ptr [7FFF26B178C0]
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
       mov       rax,21935413020
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
       mov       rdx,219554114B8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
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
; Total bytes of code 121
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
       mov       rdx,25675E01028
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
       mov       rdx,25675E10020
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
       mov       rdx,25665E042C0
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
       mov       rdx,25665E042C8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B10FC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AEC080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25665E02FC8
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
       mov       rdx,7FFF26B99920
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
       mov       rdx,7FFF26B99940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26B99930
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
       mov       rdx,7FFF26B99958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26B99A68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26B99A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26B99930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26B99930
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
       mov       rdx,7FFF26B904F8
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
       mov       rax,25675E01028
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
       mov       rdx,7FFF26B905C8
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
       mov       rdx,7FFF26B90708
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
       call      qword ptr [7FFF26B278C0]
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
       mov       rax,25675E01028
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
       mov       rdx,25675E0FCF8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
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
; Total bytes of code 121
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
       mov       rdx,1E751283020
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
       mov       rdx,1E751292018
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
       mov       rdx,1E7612812B0
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
       mov       rdx,1E7612812B8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B30FC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26B0C080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E751282FC8
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
       mov       rdx,7FFF26BB8B70
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
       mov       rdx,7FFF26BB8B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26BB8B80
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
       mov       rdx,7FFF26BB8BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26BB8CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26BB8CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26BB8B80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26BB8B80
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
       mov       rdx,7FFF26BB04F8
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
       mov       rax,1E751283020
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
       mov       rdx,7FFF26BB05C8
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
       mov       rdx,7FFF26BB0708
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
       call      qword ptr [7FFF26B478C0]
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
       mov       rax,1E751283020
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
       mov       rdx,1E751291CF0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
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
; Total bytes of code 121
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
       mov       rdx,1DB10C71028
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
       mov       rdx,1DB30C7FC08
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
       mov       rdx,1DB10C736C0
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
       mov       rdx,1DB10C736C8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B20FC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AFC080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DB30C72FC8
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
       mov       rdx,7FFF26BA8960
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
       mov       rdx,7FFF26BA8980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8970
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
       mov       rdx,7FFF26BA8998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8970
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
       mov       rdx,7FFF26BA04F8
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
       mov       rax,1DB10C71028
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
       mov       rdx,7FFF26BA05C8
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
       mov       rdx,7FFF26BA0708
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
       call      qword ptr [7FFF26B378C0]
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
       mov       rax,1DB10C71028
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
       mov       rdx,1DB30C7F8E0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
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
; Total bytes of code 121
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
       mov       rdx,23B96173020
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
       mov       rdx,23BB61717E0
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
       mov       rdx,23BB6172AE0
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
       mov       rdx,23BB6172AE8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B00FC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26ADC080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23B96172FC8
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
       mov       rdx,7FFF26B88960
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
       mov       rdx,7FFF26B88980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26B88970
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
       mov       rdx,7FFF26B88998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26B88AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26B88AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26B88970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26B88970
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
       mov       rdx,7FFF26B804F8
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
       mov       rax,23B96173020
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
       mov       rdx,7FFF26B805C8
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
       mov       rdx,7FFF26B80708
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
       call      qword ptr [7FFF26B178C0]
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
       mov       rax,23B96173020
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
       mov       rdx,23BB61714B8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+120]
       mov       edx,0A
       mov       r8d,0F
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
; Total bytes of code 121
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
       mov       rdx,2BA2D283020
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
       mov       rdx,2BA4D28DC10
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
       mov       rdx,2BA2D2866D0
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
       mov       rdx,2BA2D2866D8
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
       vmulsd    xmm0,xmm0,qword ptr [7FFF26B20FC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFF26AFC080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2BA2D282FC8
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
       mov       rdx,7FFF26BA8960
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
       mov       rdx,7FFF26BA8980
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8970
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
       mov       rdx,7FFF26BA8998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFF26BA8970
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
       mov       rdx,7FFF26BA04F8
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
       mov       rax,2BA2D283020
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
       mov       rdx,7FFF26BA05C8
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
       mov       rdx,7FFF26BA0708
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
       call      qword ptr [7FFF26B378C0]
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
       mov       rax,2BA2D283020
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
       mov       rdx,2BA4D28D8E8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
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
       mov       rax,277E4BD3020
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
       mov       rdx,27804BD14B8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
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
       mov       rax,1E98B4C1028
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
       mov       rdx,1E9AB4C14B8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
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
       mov       rax,175D3213020
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
       mov       rdx,175D3221CF0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
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
       mov       rax,20E3C863020
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
       mov       rdx,20E5C8614B8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
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
       mov       rax,2694BF13020
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
       mov       rdx,2697BF114B8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
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
       mov       rax,1F1217D3020
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
       mov       rdx,1F1217D58C0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
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
       mov       rax,2533C793020
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
       mov       rdx,2533C7A1CF0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
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
       mov       rax,1A89A6F3020
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
       mov       rdx,1A8BA6F14B8
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
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
       mov       rax,234EF2E1028
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
       mov       rdx,2350F2EF8E0
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

