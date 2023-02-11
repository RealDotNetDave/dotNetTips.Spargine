## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-58],rsp
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
       mov       ecx,951
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
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
       mov       rdx,1E886FB7710
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
       mov       rdx,1E876FB3090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L07
       mov       rax,1E876FB3020
       mov       rcx,[rax]
M01_L02:
       test      rcx,rcx
       je        near ptr M01_L11
       jmp       near ptr M01_L10
M01_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rdi
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
       jl        near ptr M01_L14
       lea       rcx,[r14+0C]
       mov       rdx,1E876FB3150
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[r14+0C]
       add       rcx,4
       mov       rdx,1E876FB3090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       mov       rdx,1E876FB3020
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L17
       jmp       near ptr M01_L16
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,r14
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,r14
       mov       [rbp-28],rcx
       mov       rdx,rdi
       call      qword ptr [7FF7B9D5BC28]; System.Security.Cryptography.SymmetricAlgorithm.set_Key(Byte[])
       mov       rcx,[rbp-28]
       mov       rdx,rbx
       call      qword ptr [7FF7B9D5BC18]; System.Security.Cryptography.SymmetricAlgorithm.set_IV(Byte[])
       mov       rcx,[rbp-28]
       call      qword ptr [7FF7B9D5CF90]; Internal.Cryptography.AesImplementation.CreateEncryptor()
       mov       [rbp-30],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp-38],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,[rbp-30]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-40],rbx
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,1E876FB2578
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rbx
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp-48],rcx
       mov       rdx,rsi
       call      qword ptr [7FF7B9B62278]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FF7B9B621E0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF7B9D5CB00]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rdi
       call      qword ptr [7FF7B9D5C538]; System.IO.MemoryStream.ToArray()
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rbx,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF7B9D5C468]; System.IO.MemoryStream.Dispose(Boolean)
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp-30]
       test      r8,r8
       je        short M01_L09
       mov       rcx,r8
       mov       r11,7FF7B98F05A8
       call      qword ptr [7FF7B98F05A8]
       nop
M01_L09:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF7B9D5BC90]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       mov       rax,rbx
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L10:
       cmp       dword ptr [rcx+8],0
       je        short M01_L11
       xor       eax,eax
       jmp       short M01_L12
M01_L11:
       mov       eax,1
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
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
M01_L13:
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
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
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
       cmp       dword ptr [rcx+8],0
       je        short M01_L17
       xor       eax,eax
       jmp       short M01_L18
M01_L17:
       mov       eax,1
M01_L18:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L19
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
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
M01_L19:
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
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       je        short M01_L20
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FF7B9B621E0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC.SuppressFinalize(System.Object)
M01_L20:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-40],0
       je        short M01_L21
       mov       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF7B9D5CB00]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-40]
       call      System.GC.SuppressFinalize(System.Object)
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-38],0
       je        short M01_L22
       mov       rcx,[rbp-38]
       mov       edx,1
       call      qword ptr [7FF7B9D5C468]; System.IO.MemoryStream.Dispose(Boolean)
       mov       rcx,[rbp-38]
       call      System.GC.SuppressFinalize(System.Object)
M01_L22:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-30],0
       je        short M01_L23
       mov       rcx,[rbp-30]
       mov       r11,7FF7B98F05A8
       call      qword ptr [7FF7B98F05A8]
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-28],0
       je        short M01_L24
       mov       rcx,[rbp-28]
       call      qword ptr [7FF7B9D5BC90]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
M01_L24:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 1933
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F2277B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 72
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-58],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFF7F26BEA0]
       mov       rsi,rax
       mov       ecx,951
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        near ptr M01_L11
       lea       rcx,[r14+0C]
       mov       rdx,16507408B60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[r14+12]
       mov       rdx,16507402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r14+8],0
       je        short M01_L05
       mov       rcx,r14
M01_L03:
       test      rcx,rcx
       jne       short M01_L04
       mov       eax,1
       jmp       near ptr M01_L13
M01_L04:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L13
M01_L05:
       mov       rax,16507402028
       mov       rcx,[rax]
       jmp       short M01_L03
M01_L06:
       test      rbx,rbx
       jne       near ptr M01_L09
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L15
       lea       rcx,[rbx+0C]
       mov       rdx,16507402148
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[rbx+10]
       mov       rdx,16507402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,16507402028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7EEB1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L17
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F26BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,offset MT_System.Security.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFF7F2A3E10]; System.Security.Cryptography.Aes..ctor()
       mov       rcx,r14
       mov       [rbp-28],rcx
       mov       rdx,rdi
       call      qword ptr [7FFF7F2B1158]; System.Security.Cryptography.SymmetricAlgorithm.set_Key(Byte[])
       mov       rcx,[rbp-28]
       mov       rdx,rbx
       call      qword ptr [7FFF7F2B1148]; System.Security.Cryptography.SymmetricAlgorithm.set_IV(Byte[])
       mov       rcx,[rbp-28]
       call      qword ptr [7FFF7F2B23D8]; System.Security.Cryptography.AesImplementation.CreateEncryptor()
       mov       [rbp-30],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFF7F2A5018]; System.IO.MemoryStream..ctor(Int32)
       mov       [rbp-38],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,[rbp-30]
       mov       r9d,1
       call      qword ptr [7FFF7F2A5420]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-40],rbx
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,16507401588
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rbx
       mov       r9d,400
       call      qword ptr [7FFF7F0356F0]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp-48],rcx
       mov       rdx,rsi
       call      qword ptr [7FFF7F028E08]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFF7F028D70]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F2B1F30]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       mov       rcx,rdi
       call      qword ptr [7FFF7F2B1968]; System.IO.MemoryStream.ToArray()
       mov       rcx,rax
       call      qword ptr [7FFF7F2675B8]; System.Convert.ToBase64String(Byte[])
       mov       rbx,rax
       mov       byte ptr [rdi+2B],0
       mov       byte ptr [rdi+29],0
       mov       byte ptr [rdi+28],0
       xor       ecx,ecx
       mov       [rdi+30],rcx
       mov       rcx,rdi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp-30]
       test      r8,r8
       je        short M01_L10
       mov       rcx,r8
       mov       r11,7FFF7EC70618
       call      qword ptr [r11]
       nop
M01_L10:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFF7F2B11C0]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       mov       rax,rbx
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF7F26BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFF7F028D70]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFF7F2B1F30]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-40]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp-38]
       mov       byte ptr [rcx+2B],0
       mov       byte ptr [rcx+29],0
       mov       byte ptr [rcx+28],0
       xor       eax,eax
       mov       [rcx+30],rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-30],0
       je        short M01_L18
       mov       rcx,[rbp-30]
       mov       r11,7FFF7EC70618
       call      qword ptr [r11]
M01_L18:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp-28]
       call      qword ptr [7FFF7F2B11C0]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 1860
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-58],rsp
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
       mov       ecx,951
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
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
       mov       rdx,22E06D69B20
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
       mov       rdx,22E06D63090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L07
       mov       rax,22E06D63020
       mov       rcx,[rax]
M01_L02:
       test      rcx,rcx
       je        near ptr M01_L11
       jmp       near ptr M01_L10
M01_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rdi
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
       jl        near ptr M01_L14
       lea       rcx,[r14+0C]
       mov       rdx,22E06D63150
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L15
       lea       rcx,[r14+0C]
       add       rcx,4
       mov       rdx,22E06D63090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       mov       rdx,22E06D63020
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L17
       jmp       near ptr M01_L16
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,r14
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,r14
       mov       [rbp-28],rcx
       mov       rdx,rdi
       call      qword ptr [7FF7B9D4BC28]; System.Security.Cryptography.SymmetricAlgorithm.set_Key(Byte[])
       mov       rcx,[rbp-28]
       mov       rdx,rbx
       call      qword ptr [7FF7B9D4BC18]; System.Security.Cryptography.SymmetricAlgorithm.set_IV(Byte[])
       mov       rcx,[rbp-28]
       call      qword ptr [7FF7B9D4CF90]; Internal.Cryptography.AesImplementation.CreateEncryptor()
       mov       [rbp-30],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp-38],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,[rbp-30]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-40],rbx
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,22E06D62578
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rbx
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp-48],rcx
       mov       rdx,rsi
       call      qword ptr [7FF7B9B52278]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FF7B9B521E0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF7B9D4CB00]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rdi
       call      qword ptr [7FF7B9D4C538]; System.IO.MemoryStream.ToArray()
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rbx,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF7B9D4C468]; System.IO.MemoryStream.Dispose(Boolean)
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp-30]
       test      r8,r8
       je        short M01_L09
       mov       rcx,r8
       mov       r11,7FF7B98E05D0
       call      qword ptr [7FF7B98E05D0]
       nop
M01_L09:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF7B9D4BC90]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       mov       rax,rbx
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L10:
       cmp       dword ptr [rcx+8],0
       je        short M01_L11
       xor       eax,eax
       jmp       short M01_L12
M01_L11:
       mov       eax,1
M01_L12:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
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
M01_L13:
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
M01_L14:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
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
       cmp       dword ptr [rcx+8],0
       je        short M01_L17
       xor       eax,eax
       jmp       short M01_L18
M01_L17:
       mov       eax,1
M01_L18:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L19
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
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
M01_L19:
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
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       je        short M01_L20
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FF7B9B521E0]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC.SuppressFinalize(System.Object)
M01_L20:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-40],0
       je        short M01_L21
       mov       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF7B9D4CB00]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-40]
       call      System.GC.SuppressFinalize(System.Object)
M01_L21:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-38],0
       je        short M01_L22
       mov       rcx,[rbp-38]
       mov       edx,1
       call      qword ptr [7FF7B9D4C468]; System.IO.MemoryStream.Dispose(Boolean)
       mov       rcx,[rbp-38]
       call      System.GC.SuppressFinalize(System.Object)
M01_L22:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-30],0
       je        short M01_L23
       mov       rcx,[rbp-30]
       mov       r11,7FF7B98E05D0
       call      qword ptr [7FF7B98E05D0]
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-28],0
       je        short M01_L24
       mov       rcx,[rbp-28]
       call      qword ptr [7FF7B9D4BC90]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
M01_L24:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 1933
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F2277B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-58],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFF7F26BEA0]
       mov       rsi,rax
       mov       ecx,951
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rdi,rdi
       jne       near ptr M01_L06
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        near ptr M01_L11
       lea       rcx,[r14+0C]
       mov       rdx,21EA7808B60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L12
       lea       rcx,[r14+12]
       mov       rdx,21EA7802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r14+8],0
       je        short M01_L05
       mov       rcx,r14
M01_L03:
       test      rcx,rcx
       jne       short M01_L04
       mov       eax,1
       jmp       near ptr M01_L13
M01_L04:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L13
M01_L05:
       mov       rax,21EA7802028
       mov       rcx,[rax]
       jmp       short M01_L03
M01_L06:
       test      rbx,rbx
       jne       near ptr M01_L09
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,4
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],2
       jl        near ptr M01_L15
       lea       rcx,[rbx+0C]
       mov       rdx,21EA7802148
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,2
       cmp       ecx,2
       jl        near ptr M01_L16
       lea       rcx,[rbx+10]
       mov       rdx,21EA7802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,21EA7802028
       mov       rdx,[rdx]
       call      qword ptr [7FFF7EEB1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L17
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F26BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,offset MT_System.Security.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFF7F2A3E10]; System.Security.Cryptography.Aes..ctor()
       mov       rcx,r14
       mov       [rbp-28],rcx
       mov       rdx,rdi
       call      qword ptr [7FFF7F2B1158]; System.Security.Cryptography.SymmetricAlgorithm.set_Key(Byte[])
       mov       rcx,[rbp-28]
       mov       rdx,rbx
       call      qword ptr [7FFF7F2B1148]; System.Security.Cryptography.SymmetricAlgorithm.set_IV(Byte[])
       mov       rcx,[rbp-28]
       call      qword ptr [7FFF7F2B23D8]; System.Security.Cryptography.AesImplementation.CreateEncryptor()
       mov       [rbp-30],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFF7F2A5018]; System.IO.MemoryStream..ctor(Int32)
       mov       [rbp-38],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,[rbp-30]
       mov       r9d,1
       call      qword ptr [7FFF7F2A5420]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp-40],rbx
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,21EA7801588
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rbx
       mov       r9d,400
       call      qword ptr [7FFF7F0356F0]; System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp-48],rcx
       mov       rdx,rsi
       call      qword ptr [7FFF7F028E08]; System.IO.StreamWriter.Write(System.String)
       nop
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFF7F028D70]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF7F2B1F30]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       mov       rcx,rdi
       call      qword ptr [7FFF7F2B1968]; System.IO.MemoryStream.ToArray()
       mov       rcx,rax
       call      qword ptr [7FFF7F2675B8]; System.Convert.ToBase64String(Byte[])
       mov       rbx,rax
       mov       byte ptr [rdi+2B],0
       mov       byte ptr [rdi+29],0
       mov       byte ptr [rdi+28],0
       xor       ecx,ecx
       mov       [rdi+30],rcx
       mov       rcx,rdi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp-30]
       test      r8,r8
       je        short M01_L10
       mov       rcx,r8
       mov       r11,7FFF7EC70608
       call      qword ptr [r11]
       nop
M01_L10:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFF7F2B11C0]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       mov       rax,rbx
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF7F26BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFF7F028D70]; System.IO.StreamWriter.Dispose(Boolean)
       mov       rcx,[rbp-48]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFF7F2B1F30]; System.Security.Cryptography.CryptoStream.Dispose(Boolean)
       mov       rcx,[rbp-40]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp-38]
       mov       byte ptr [rcx+2B],0
       mov       byte ptr [rcx+29],0
       mov       byte ptr [rcx+28],0
       xor       eax,eax
       mov       [rcx+30],rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-30],0
       je        short M01_L18
       mov       rcx,[rbp-30]
       mov       r11,7FFF7EC70608
       call      qword ptr [r11]
M01_L18:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp-28]
       call      qword ptr [7FFF7F2B11C0]; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 1860
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,255DA1211D8
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
       mov       ecx,92D
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
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
       mov       ecx,943
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       mov       rdx,19AB4800200
       mov       rdx,[rdx]
       call      qword ptr [7FFF7F217810]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F321000]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BEA0]
       mov       rsi,rax
       mov       ecx,92D
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7F25BEA0]
       mov       rdi,rax
       mov       ecx,943
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       lea       rcx,[rsp+30]
       mov       rdx,rdi
       call      qword ptr [7FFF7F217780]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       r8,[rsp+38]
       call      qword ptr [7FFF7F217798]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,1AFB02811D8
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
       mov       ecx,951
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
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
       mov       ecx,943
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,26DC6408DF8
       mov       rdx,[rdx]
       call      qword ptr [7FFF7F237828]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F32BFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F27BEA0]
       mov       rsi,rax
       mov       ecx,951
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7F27BEA0]
       mov       rdi,rax
       mov       ecx,943
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       lea       rcx,[rsp+30]
       mov       rdx,rdi
       call      qword ptr [7FFF7F237780]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       r8,[rsp+38]
       call      qword ptr [7FFF7F2377B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

