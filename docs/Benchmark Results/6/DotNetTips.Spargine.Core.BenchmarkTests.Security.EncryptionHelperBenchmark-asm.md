## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,[rsi+1A0]
       mov       r8,[rsi+198]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-78],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
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
       jne       near ptr M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,9AB
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        short M01_L03
       lea       rcx,[r14+0C]
       mov       rdx,1B9D7EA9B20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[r14+0C]
       add       rcx,6
       mov       rdx,1B9D7EA3090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L07
       mov       rax,1B9D7EA3020
       mov       rcx,[rax]
M01_L02:
       test      rcx,rcx
       je        near ptr M01_L12
       jmp       near ptr M01_L11
M01_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       dword ptr [r14+8],2
       jl        near ptr M01_L15
       lea       rcx,[r14+0C]
       mov       rdx,1B9D7EA3150
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r14+0C]
       add       rcx,4
       mov       rdx,1B9D7EA3090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       mov       rdx,1B9D7EA3020
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L18
       jmp       near ptr M01_L17
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,r14
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp-48],r14
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       mov       r12,r15
       add       r12,40
       mov       r13,r12
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       mov       [r13+10],rcx
       mov       [r13+18],ecx
       mov       [rbp-50],r15
       mov       rcx,[r12]
       mov       r11,7FFA986C0788
       call      qword ptr [7FFA986C0788]
       mov       r13d,eax
       mov       rcx,[r12]
       mov       r11,7FFA986C0790
       call      qword ptr [7FFA986C0790]
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[r12]
       mov       r11,7FFA986C0798
       call      qword ptr [7FFA986C0798]
       mov       [rsp+30],eax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,r12
       mov       [rsp+20],r13d
       mov       edi,[rbp-3C]
       mov       [rsp+28],edi
       mov       r9d,1
       call      Internal.Cryptography.CngSymmetricAlgorithmCore.CreateCryptoTransform(Byte[], Byte[], Boolean, System.Security.Cryptography.PaddingMode, System.Security.Cryptography.CipherMode, Int32)
       mov       r8,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rbp-68]
       mov       rdx,r14
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       rdi,[rbp-68]
       mov       [rbp-58],rdi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,1B9D7EA2580
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rbx
       mov       [rbp-60],rcx
       mov       rdx,rsi
       call      qword ptr [7FFA98922948]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFA989228B0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFA98D1D9D8]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,r14
       call      qword ptr [7FFA98B552E8]; System.IO.MemoryStream.ToArray()
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rdi,rax
       mov       rcx,[r15+8]
       test      rcx,rcx
       je        short M01_L09
       call      System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+8],rcx
M01_L09:
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L10
       call      System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+10],rcx
M01_L10:
       mov       rcx,r15
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFA98B55218]; System.IO.MemoryStream.Dispose(Boolean)
       mov       rcx,r14
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rdi
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       cmp       dword ptr [rcx+8],0
       je        short M01_L12
       xor       eax,eax
       jmp       short M01_L13
M01_L12:
       mov       eax,1
M01_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L14
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       cmp       dword ptr [rcx+8],0
       je        short M01_L18
       xor       eax,eax
       jmp       short M01_L19
M01_L18:
       mov       eax,1
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-60],0
       je        short M01_L21
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFA989228B0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      System.GC.SuppressFinalize(System.Object)
M01_L21:
       nop
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
       sub       rsp,48
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-58],0
       je        short M01_L22
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFA98D1D9D8]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      System.GC.SuppressFinalize(System.Object)
M01_L22:
       nop
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
       sub       rsp,48
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-50],0
       je        short M01_L25
       mov       r15,[rbp-50]
       cmp       qword ptr [r15+8],0
       je        short M01_L23
       mov       rcx,[r15+8]
       call      System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+8],rcx
M01_L23:
       cmp       qword ptr [r15+10],0
       je        short M01_L24
       mov       rcx,[r15+10]
       call      System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+10],rcx
M01_L24:
       mov       rcx,r15
       call      System.GC.SuppressFinalize(System.Object)
M01_L25:
       nop
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
       sub       rsp,48
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-48],0
       je        short M01_L26
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFA98B55218]; System.IO.MemoryStream.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC.SuppressFinalize(System.Object)
M01_L26:
       nop
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
; Total bytes of code 2087
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,[rsi+1A0]
       mov       r8,[rsi+198]
       call      qword ptr [7FFA975177B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0D0],xmm4
       vmovdqa   xmmword ptr [rbp-0C0],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0E8],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L01
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA975AB450]
       mov       rbx,rax
       mov       ecx,0CCE
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975A9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975AB078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFA975AB330]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        near ptr M01_L21
       lea       rcx,[r14+0C]
       mov       rdx,2A77B008B60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[r14+12]
       mov       rdx,2A77B002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r14+8],0
       je        short M01_L06
       mov       rcx,r14
M01_L04:
       test      rcx,rcx
       jne       short M01_L05
       mov       eax,1
       jmp       near ptr M01_L23
M01_L05:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L23
M01_L06:
       mov       rax,2A77B002028
       mov       rcx,[rax]
       jmp       short M01_L04
M01_L07:
       test      rdi,rdi
       jne       near ptr M01_L10
       call      qword ptr [7FFA975AB330]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],2
       jl        near ptr M01_L25
       lea       rcx,[rdi+0C]
       mov       rdx,2A77B002148
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L26
       lea       rcx,[rdi+10]
       mov       rdx,2A77B002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2A77B002028
       mov       rdx,[rdx]
       call      qword ptr [7FFA971B1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L27
       mov       eax,1
M01_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L09
       call      qword ptr [7FFA975AB450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975A9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975AB078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975AB078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA975AD0A8]; System.IO.MemoryStream..ctor(Int32)
       mov       [rbp-68],r14
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97785630]; System.Security.Cryptography.Aes..ctor()
       mov       r12,r15
       add       r12,40
       mov       r13,r12
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       mov       [r13+10],rcx
       mov       [r13+18],ecx
       mov       [rbp-70],r15
       mov       rcx,[r12]
       mov       r11,7FFA96F70740
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r12]
       mov       r11,7FFA96F70748
       call      qword ptr [r11]
       mov       [rbp-3C],eax
       mov       rcx,[r12]
       mov       r11,7FFA96F70750
       call      qword ptr [r11]
       mov       [rbp-40],eax
       mov       rcx,r12
       mov       edx,[rbp-3C]
       mov       r8d,eax
       call      qword ptr [7FFA97785870]; System.Security.Cryptography.CngSymmetricAlgorithmCore.ValidateFeedbackSize(System.Security.Cryptography.CipherMode, Int32)
       lea       rcx,[rsi+10]
       mov       edx,[rsi+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       mov       rcx,r12
       lea       rdx,[rbp-60]
       call      qword ptr [7FFA97785888]; System.Security.Cryptography.CngSymmetricAlgorithmCore.CopyAndValidateKey(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       mov       eax,[rdi+8]
       mov       [rbp-0CC],eax
       mov       rcx,[r12]
       mov       r11,7FFA96F70758
       call      qword ptr [r11]
       add       eax,7
       mov       ecx,eax
       sar       ecx,1F
       and       ecx,7
       add       ecx,eax
       sar       ecx,3
       mov       eax,[rbp-0CC]
       cmp       eax,ecx
       jne       near ptr M01_L12
       mov       ecx,[rbp-3C]
       mov       rdx,rdi
       call      qword ptr [7FFA97787420]; Internal.Cryptography.Helpers.GetCipherIv(System.Security.Cryptography.CipherMode, Byte[])
       mov       rcx,rax
       call      qword ptr [7FFA977873A8]; Internal.Cryptography.Helpers.CloneByteArray(Byte[])
       mov       rdi,rax
       mov       rcx,[r12]
       mov       r11,7FFA96F70760
       call      qword ptr [r11]
       add       eax,7
       mov       r9d,eax
       sar       r9d,1F
       and       r9d,7
       add       eax,r9d
       sar       eax,3
       mov       [rbp-44],eax
       mov       rcx,[r12]
       mov       r8d,[rbp-40]
       mov       edx,[rbp-3C]
       mov       r11,7FFA96F70768
       call      qword ptr [r11]
       mov       [rbp-88],rax
       mov       rcx,[r12]
       mov       r8d,[rbp-40]
       mov       edx,[rbp-3C]
       mov       r11,7FFA96F70770
       call      qword ptr [r11]
       mov       r12d,eax
       test      rsi,rsi
       je        near ptr M01_L13
       lea       rax,[rsi+10]
       mov       [rbp-0A8],rax
       mov       ecx,[rsi+8]
       mov       esi,ecx
M01_L11:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-90],rax
       mov       r8,[rbp-0A8]
       mov       [rbp-0B0],r8
       mov       ecx,[rbp-3C]
       mov       rdx,rdi
       call      qword ptr [7FFA97787420]; Internal.Cryptography.Helpers.GetCipherIv(System.Security.Cryptography.CipherMode, Byte[])
       mov       rdi,[rbp-90]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-44]
       mov       [rdi+10],eax
       test      r12d,r12d
       jg        near ptr M01_L15
       mov       [rbp-44],eax
       mov       ecx,eax
       jmp       near ptr M01_L16
M01_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,213D
       mov       rdx,7FFA975687B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9784F018]
       mov       rdi,rax
       mov       ecx,41A3
       mov       rdx,7FFA975687B8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA971BBBD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-0A8],rsi
       mov       esi,eax
       jmp       near ptr M01_L11
M01_L14:
       xor       edx,edx
       xor       r8d,r8d
       mov       [rbp-0B8],rdx
       mov       [rbp-48],r8d
       jmp       short M01_L17
M01_L15:
       mov       ecx,r12d
       mov       [rbp-44],eax
M01_L16:
       mov       [rdi+14],ecx
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        short M01_L14
       lea       rdx,[rcx+10]
       mov       [rbp-0B8],rdx
       mov       r8d,[rcx+8]
       mov       [rbp-48],r8d
M01_L17:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherLiteBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       mov       r8,[rbp-0B8]
       mov       r9d,[rbp-48]
       mov       r10,[rbp-0B0]
       mov       [rbp-0C8],r10
       mov       [rbp-0C0],r8
       mov       [rbp-4C],r9d
       test      r9d,r9d
       je        short M01_L18
       movsxd    rdx,r9d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       [rbp-0A0],rdx
       lea       rcx,[rdx+10]
       mov       r8d,[rbp-4C]
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbp-0A0]
       mov       rax,[rbp-98]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L18:
       mov       rax,[rbp-98]
       mov       ecx,[rbp-44]
       mov       [rax+18],ecx
       mov       [rax+1C],r12d
       mov       byte ptr [rax+20],1
       mov       [rbp-98],rax
       lea       rcx,[rax+8]
       mov       [rbp-0D8],rcx
       mov       r12,[rbp-88]
       mov       r10,[rbp-0C8]
       mov       [rbp-60],r10
       mov       [rbp-58],esi
       mov       rcx,r12
       lea       rdx,[rbp-60]
       call      qword ptr [7FFA9776D4C8]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-0D8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.UniversalCryptoEncryptor
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsi+10],r13d
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdi
       mov       rdx,r14
       mov       r8,rsi
       mov       r9d,1
       call      qword ptr [7FFA97785BA0]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-78],rdi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,2A77B001588
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r9d,400
       call      qword ptr [7FFA973256F0]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-80],rcx
       mov       rdx,rbx
       call      qword ptr [7FFA973197C0]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFA97319728]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFA9777FD70]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,rdi
       call      System.GC._SuppressFinalize(System.Object)
       mov       rcx,r14
       call      qword ptr [7FFA975C8CD0]; System.IO.MemoryStream.ToArray()
       mov       rcx,rax
       call      qword ptr [7FFA9755BDB0]; System.Convert.ToBase64String(Byte[])
       mov       rdi,rax
       mov       rcx,[r15+8]
       test      rcx,rcx
       je        short M01_L19
       call      qword ptr [7FFA970990A8]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+8],rcx
M01_L19:
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L20
       call      qword ptr [7FFA970990A8]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+10],rcx
M01_L20:
       mov       rcx,r15
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       byte ptr [r14+2B],0
       mov       byte ptr [r14+29],0
       mov       byte ptr [r14+28],0
       xor       ecx,ecx
       mov       [r14+30],rcx
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,rdi
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97351C78]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA97351C78]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L24
       call      qword ptr [7FFA975AB450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975A9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975AB078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975AB078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L27:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L08
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+110]
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFA97319728]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+110]
       mov       rcx,[rbp-78]
       mov       edx,1
       call      qword ptr [7FFA9777FD70]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-78]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+110]
       mov       r15,[rbp-70]
       cmp       qword ptr [r15+8],0
       je        short M01_L28
       mov       rcx,[r15+8]
       call      qword ptr [7FFA970990A8]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+8],rcx
M01_L28:
       cmp       qword ptr [r15+10],0
       je        short M01_L29
       mov       rcx,[r15+10]
       call      qword ptr [7FFA970990A8]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+10],rcx
M01_L29:
       mov       rcx,r15
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+110]
       mov       rcx,[rbp-68]
       mov       byte ptr [rcx+2B],0
       mov       byte ptr [rcx+29],0
       mov       byte ptr [rcx+28],0
       xor       eax,eax
       mov       [rcx+30],rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2815
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,[rsi+1A0]
       mov       r8,[rsi+198]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-78],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
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
       jne       near ptr M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,9AB
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        short M01_L03
       lea       rcx,[r14+0C]
       mov       rdx,210DF4B9B20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[r14+0C]
       add       rcx,6
       mov       rdx,210DF4B3090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L07
       mov       rax,210DF4B3020
       mov       rcx,[rax]
M01_L02:
       test      rcx,rcx
       je        near ptr M01_L12
       jmp       near ptr M01_L11
M01_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       dword ptr [r14+8],2
       jl        near ptr M01_L15
       lea       rcx,[r14+0C]
       mov       rdx,210DF4B3150
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[r14+0C]
       add       rcx,4
       mov       rdx,210DF4B3090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       mov       rdx,210DF4B3020
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L18
       jmp       near ptr M01_L17
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,r14
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp-48],r14
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       mov       r12,r15
       add       r12,40
       mov       r13,r12
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       mov       [r13+10],rcx
       mov       [r13+18],ecx
       mov       [rbp-50],r15
       mov       rcx,[r12]
       mov       r11,7FFA986C0748
       call      qword ptr [7FFA986C0748]
       mov       r13d,eax
       mov       rcx,[r12]
       mov       r11,7FFA986C0750
       call      qword ptr [7FFA986C0750]
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[r12]
       mov       r11,7FFA986C0758
       call      qword ptr [7FFA986C0758]
       mov       [rsp+30],eax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,r12
       mov       [rsp+20],r13d
       mov       edi,[rbp-3C]
       mov       [rsp+28],edi
       mov       r9d,1
       call      Internal.Cryptography.CngSymmetricAlgorithmCore.CreateCryptoTransform(Byte[], Byte[], Boolean, System.Security.Cryptography.PaddingMode, System.Security.Cryptography.CipherMode, Int32)
       mov       r8,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rbp-68]
       mov       rdx,r14
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       rdi,[rbp-68]
       mov       [rbp-58],rdi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,210DF4B2580
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rbx
       mov       [rbp-60],rcx
       mov       rdx,rsi
       call      qword ptr [7FFA98922948]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFA989228B0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFA98D1DB28]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,r14
       call      qword ptr [7FFA98B552E8]; System.IO.MemoryStream.ToArray()
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rdi,rax
       mov       rcx,[r15+8]
       test      rcx,rcx
       je        short M01_L09
       call      System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+8],rcx
M01_L09:
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L10
       call      System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+10],rcx
M01_L10:
       mov       rcx,r15
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFA98B55218]; System.IO.MemoryStream.Dispose(Boolean)
       mov       rcx,r14
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rdi
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       cmp       dword ptr [rcx+8],0
       je        short M01_L12
       xor       eax,eax
       jmp       short M01_L13
M01_L12:
       mov       eax,1
M01_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L14
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       cmp       dword ptr [rcx+8],0
       je        short M01_L18
       xor       eax,eax
       jmp       short M01_L19
M01_L18:
       mov       eax,1
M01_L19:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L20
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-60],0
       je        short M01_L21
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFA989228B0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      System.GC.SuppressFinalize(System.Object)
M01_L21:
       nop
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
       sub       rsp,48
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-58],0
       je        short M01_L22
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFA98D1DB28]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      System.GC.SuppressFinalize(System.Object)
M01_L22:
       nop
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
       sub       rsp,48
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-50],0
       je        short M01_L25
       mov       r15,[rbp-50]
       cmp       qword ptr [r15+8],0
       je        short M01_L23
       mov       rcx,[r15+8]
       call      System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+8],rcx
M01_L23:
       cmp       qword ptr [r15+10],0
       je        short M01_L24
       mov       rcx,[r15+10]
       call      System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+10],rcx
M01_L24:
       mov       rcx,r15
       call      System.GC.SuppressFinalize(System.Object)
M01_L25:
       nop
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
       sub       rsp,48
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-48],0
       je        short M01_L26
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFA98B55218]; System.IO.MemoryStream.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC.SuppressFinalize(System.Object)
M01_L26:
       nop
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
; Total bytes of code 2087
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,[rsi+1A0]
       mov       r8,[rsi+198]
       call      qword ptr [7FFA975177B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0D0],xmm4
       vmovdqa   xmmword ptr [rbp-0C0],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0E8],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L01
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L02
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA975AB450]
       mov       rbx,rax
       mov       ecx,0CCE
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975A9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975AB078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       test      rsi,rsi
       jne       near ptr M01_L07
       call      qword ptr [7FFA975AB330]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        near ptr M01_L21
       lea       rcx,[r14+0C]
       mov       rdx,2A14D008B60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L22
       lea       rcx,[r14+12]
       mov       rdx,2A14D002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r14+8],0
       je        short M01_L06
       mov       rcx,r14
M01_L04:
       test      rcx,rcx
       jne       short M01_L05
       mov       eax,1
       jmp       near ptr M01_L23
M01_L05:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L23
M01_L06:
       mov       rax,2A14D002028
       mov       rcx,[rax]
       jmp       short M01_L04
M01_L07:
       test      rdi,rdi
       jne       near ptr M01_L10
       call      qword ptr [7FFA975AB330]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],2
       jl        near ptr M01_L25
       lea       rcx,[rdi+0C]
       mov       rdx,2A14D002148
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L26
       lea       rcx,[rdi+10]
       mov       rdx,2A14D002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,2A14D002028
       mov       rdx,[rdx]
       call      qword ptr [7FFA971B1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L27
       mov       eax,1
M01_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L09
       call      qword ptr [7FFA975AB450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975A9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975AB078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975AB078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA975AD0A8]; System.IO.MemoryStream..ctor(Int32)
       mov       [rbp-68],r14
       mov       rcx,offset MT_System.Security.Cryptography.AesCng
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97783E10]; System.Security.Cryptography.Aes..ctor()
       mov       r12,r15
       add       r12,40
       mov       r13,r12
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       mov       [r13+10],rcx
       mov       [r13+18],ecx
       mov       [rbp-70],r15
       mov       rcx,[r12]
       mov       r11,7FFA96F706E0
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rcx,[r12]
       mov       r11,7FFA96F706E8
       call      qword ptr [r11]
       mov       [rbp-3C],eax
       mov       rcx,[r12]
       mov       r11,7FFA96F706F0
       call      qword ptr [r11]
       mov       [rbp-40],eax
       mov       rcx,r12
       mov       edx,[rbp-3C]
       mov       r8d,eax
       call      qword ptr [7FFA977851E0]; System.Security.Cryptography.CngSymmetricAlgorithmCore.ValidateFeedbackSize(System.Security.Cryptography.CipherMode, Int32)
       lea       rcx,[rsi+10]
       mov       edx,[rsi+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       mov       rcx,r12
       lea       rdx,[rbp-60]
       call      qword ptr [7FFA977851F8]; System.Security.Cryptography.CngSymmetricAlgorithmCore.CopyAndValidateKey(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       mov       eax,[rdi+8]
       mov       [rbp-0CC],eax
       mov       rcx,[r12]
       mov       r11,7FFA96F706F8
       call      qword ptr [r11]
       add       eax,7
       mov       ecx,eax
       sar       ecx,1F
       and       ecx,7
       add       ecx,eax
       sar       ecx,3
       mov       eax,[rbp-0CC]
       cmp       eax,ecx
       jne       near ptr M01_L12
       mov       ecx,[rbp-3C]
       mov       rdx,rdi
       call      qword ptr [7FFA97785D68]; Internal.Cryptography.Helpers.GetCipherIv(System.Security.Cryptography.CipherMode, Byte[])
       mov       rcx,rax
       call      qword ptr [7FFA97785CF0]; Internal.Cryptography.Helpers.CloneByteArray(Byte[])
       mov       rdi,rax
       mov       rcx,[r12]
       mov       r11,7FFA96F70700
       call      qword ptr [r11]
       add       eax,7
       mov       r9d,eax
       sar       r9d,1F
       and       r9d,7
       add       eax,r9d
       sar       eax,3
       mov       [rbp-44],eax
       mov       rcx,[r12]
       mov       r8d,[rbp-40]
       mov       edx,[rbp-3C]
       mov       r11,7FFA96F70708
       call      qword ptr [r11]
       mov       [rbp-88],rax
       mov       rcx,[r12]
       mov       r8d,[rbp-40]
       mov       edx,[rbp-3C]
       mov       r11,7FFA96F70710
       call      qword ptr [r11]
       mov       r12d,eax
       test      rsi,rsi
       je        near ptr M01_L13
       lea       rax,[rsi+10]
       mov       [rbp-0A8],rax
       mov       ecx,[rsi+8]
       mov       esi,ecx
M01_L11:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-90],rax
       mov       r8,[rbp-0A8]
       mov       [rbp-0B0],r8
       mov       ecx,[rbp-3C]
       mov       rdx,rdi
       call      qword ptr [7FFA97785D68]; Internal.Cryptography.Helpers.GetCipherIv(System.Security.Cryptography.CipherMode, Byte[])
       mov       rdi,[rbp-90]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-44]
       mov       [rdi+10],eax
       test      r12d,r12d
       jg        near ptr M01_L15
       mov       [rbp-44],eax
       mov       ecx,eax
       jmp       near ptr M01_L16
M01_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,213D
       mov       rdx,7FFA975687B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9784F018]
       mov       rdi,rax
       mov       ecx,41A3
       mov       rdx,7FFA975687B8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA971BBBD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-0A8],rsi
       mov       esi,eax
       jmp       near ptr M01_L11
M01_L14:
       xor       edx,edx
       xor       r8d,r8d
       mov       [rbp-0B8],rdx
       mov       [rbp-48],r8d
       jmp       short M01_L17
M01_L15:
       mov       ecx,r12d
       mov       [rbp-44],eax
M01_L16:
       mov       [rdi+14],ecx
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        short M01_L14
       lea       rdx,[rcx+10]
       mov       [rbp-0B8],rdx
       mov       r8d,[rcx+8]
       mov       [rbp-48],r8d
M01_L17:
       mov       rcx,offset MT_System.Security.Cryptography.BasicSymmetricCipherLiteBCrypt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       mov       r8,[rbp-0B8]
       mov       r9d,[rbp-48]
       mov       r10,[rbp-0B0]
       mov       [rbp-0C8],r10
       mov       [rbp-0C0],r8
       mov       [rbp-4C],r9d
       test      r9d,r9d
       je        short M01_L18
       movsxd    rdx,r9d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       [rbp-0A0],rdx
       lea       rcx,[rdx+10]
       mov       r8d,[rbp-4C]
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbp-0A0]
       mov       rax,[rbp-98]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L18:
       mov       rax,[rbp-98]
       mov       ecx,[rbp-44]
       mov       [rax+18],ecx
       mov       [rax+1C],r12d
       mov       byte ptr [rax+20],1
       mov       [rbp-98],rax
       lea       rcx,[rax+8]
       mov       [rbp-0D8],rcx
       mov       r12,[rbp-88]
       mov       r10,[rbp-0C8]
       mov       [rbp-60],r10
       mov       [rbp-58],esi
       mov       rcx,r12
       lea       rdx,[rbp-60]
       call      qword ptr [7FFA9776BD08]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rbp-0D8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.UniversalCryptoEncryptor
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsi+10],r13d
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdi
       mov       rdx,r14
       mov       r8,rsi
       mov       r9d,1
       call      qword ptr [7FFA97785510]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-78],rdi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,2A14D001588
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r9d,400
       call      qword ptr [7FFA973256F0]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,rsi
       mov       [rbp-80],rcx
       mov       rdx,rbx
       call      qword ptr [7FFA973197C0]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFA97319728]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFA9777ED20]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,rdi
       call      System.GC._SuppressFinalize(System.Object)
       mov       rcx,r14
       call      qword ptr [7FFA975C8CD0]; System.IO.MemoryStream.ToArray()
       mov       rcx,rax
       call      qword ptr [7FFA9755BDB0]; System.Convert.ToBase64String(Byte[])
       mov       rdi,rax
       mov       rcx,[r15+8]
       test      rcx,rcx
       je        short M01_L19
       call      qword ptr [7FFA970990A8]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+8],rcx
M01_L19:
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L20
       call      qword ptr [7FFA970990A8]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+10],rcx
M01_L20:
       mov       rcx,r15
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       byte ptr [r14+2B],0
       mov       byte ptr [r14+29],0
       mov       byte ptr [r14+28],0
       xor       ecx,ecx
       mov       [r14+30],rcx
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,rdi
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97351C78]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA97351C78]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L23:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L24
       call      qword ptr [7FFA975AB450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975A9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975AB078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975AB078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L26:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L27:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L08
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+110]
       mov       rcx,[rbp-80]
       mov       edx,1
       call      qword ptr [7FFA97319728]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-80]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+110]
       mov       rcx,[rbp-78]
       mov       edx,1
       call      qword ptr [7FFA9777ED20]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-78]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+110]
       mov       r15,[rbp-70]
       cmp       qword ptr [r15+8],0
       je        short M01_L28
       mov       rcx,[r15+8]
       call      qword ptr [7FFA970990A8]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+8],rcx
M01_L28:
       cmp       qword ptr [r15+10],0
       je        short M01_L29
       mov       rcx,[r15+10]
       call      qword ptr [7FFA970990A8]; System.Array.Clear(System.Array)
       xor       ecx,ecx
       mov       [r15+10],rcx
M01_L29:
       mov       rcx,r15
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
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
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+110]
       mov       rcx,[rbp-68]
       mov       byte ptr [rcx+2B],0
       mov       byte ptr [rcx+29],0
       mov       byte ptr [rcx+28],0
       xor       eax,eax
       mov       [rcx+30],rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 2815
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,1EB42E511D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
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
       jne       near ptr M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,987
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,99D
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       lea       rcx,[rsp+30]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       near ptr M01_L02
; Total bytes of code 506
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
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,2B528C00200
       mov       rdx,[rdx]
       call      qword ptr [7FFA97507810]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977D3FA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 80
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
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
       call      qword ptr [7FFA9759B450]
       mov       rsi,rax
       mov       ecx,0CAA
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,32C
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
M01_L04:
       test      edx,edx
       jne       near ptr M01_L05
       call      qword ptr [7FFA9759B450]
       mov       rdi,rax
       mov       ecx,0CC0
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       lea       rcx,[rsp+30]
       mov       rdx,rdi
       call      qword ptr [7FFA97507780]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       r8,[rsp+38]
       call      qword ptr [7FFA97507798]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 507
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
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,1D8507C11D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
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
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
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
       jne       near ptr M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,9AB
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,99D
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       lea       rcx,[rsp+30]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       r8,[rsp+38]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       near ptr M01_L02
; Total bytes of code 506
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
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,16473808DF8
       mov       rdx,[rdx]
       call      qword ptr [7FFA97507828]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977E1FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
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
       call      qword ptr [7FFA9759B450]
       mov       rsi,rax
       mov       ecx,0CCE
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,32C
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
M01_L04:
       test      edx,edx
       jne       near ptr M01_L05
       call      qword ptr [7FFA9759B450]
       mov       rdi,rax
       mov       ecx,0CC0
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       lea       rcx,[rsp+30]
       mov       rdx,rdi
       call      qword ptr [7FFA97507780]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       r8,[rsp+38]
       call      qword ptr [7FFA975077B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 507
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

