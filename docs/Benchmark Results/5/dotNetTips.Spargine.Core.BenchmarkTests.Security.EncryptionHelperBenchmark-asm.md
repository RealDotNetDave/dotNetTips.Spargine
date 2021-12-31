## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
; 			var result = EncryptionHelper.AesEncrypt(this._aesCypherText, this._aesKey, this._aesIv);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0A8]
       mov       rdx,[rsi+0C8]
       mov       r8,[rsi+0C0]
       call      dotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA8],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Security.Cryptography.AesManaged
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       lea       rcx,[r14+40]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD0],r14
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       [rbp+0FFC8],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFC0],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFC0]
       mov       r8,[rbp+0FFC8]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFB8],rdi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,244D2D92540
       mov       r8,[r8]
       mov       rcx,rdi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       [rbp+0FFB0],rdi
       mov       rcx,[rbp+0FFB0]
       mov       rdx,rsi
       call      qword ptr [7FF85D648118]
       nop
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF85D648080]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF85D649EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FF85D6499A0]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rsi,rax
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF85D6498D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF85D280578
       call      qword ptr [7FF85D640578]
       nop
M01_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D648E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D648E30]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF85D648080]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L01:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF85D649EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF85D6498D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L03:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF85D280578
       call      qword ptr [7FF85D640578]
M01_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L05
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D648E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D648E30]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 861
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
; 			var result = EncryptionHelper.AesEncrypt(LongTestString, this._aesKey, this._aesIv);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0C8]
       mov       r8,[rsi+0C0]
       mov       rcx,20F43479930
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
; dotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA8],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Security.Cryptography.AesManaged
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       lea       rcx,[r14+40]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD0],r14
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       [rbp+0FFC8],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFC0],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFC0]
       mov       r8,[rbp+0FFC8]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFB8],rdi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,20F43472540
       mov       r8,[r8]
       mov       rcx,rdi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       [rbp+0FFB0],rdi
       mov       rcx,[rbp+0FFB0]
       mov       rdx,rsi
       call      qword ptr [7FF85D618118]
       nop
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF85D618080]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF85D619EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FF85D6199A0]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rsi,rax
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF85D6198D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF85D2505B0
       call      qword ptr [7FF85D6105B0]
       nop
M01_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D618E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D618E30]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF85D618080]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L01:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF85D619EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF85D6198D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L03:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF85D2505B0
       call      qword ptr [7FF85D6105B0]
M01_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L05
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D618E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D618E30]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 861
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.HashPasswordWithPBKDF2()
; 			var result = EncryptionHelper.HashPasswordWithPBKDF2(Password);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,17F7C6F9940
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.HashPassword(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
; dotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.HashPassword(System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD8],rsp
       mov       rsi,rcx
       mov       rcx,offset MT_System.Security.Cryptography.Rfc2898DeriveBytes
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      dotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.get_HashAlgorithmName()
       mov       [rsp+20],rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,10
       mov       r9d,0C350
       call      System.Security.Cryptography.Rfc2898DeriveBytes..ctor(System.String, Int32, Int32, System.Security.Cryptography.HashAlgorithmName)
       mov       [rbp+0FFE0],rdi
       mov       rcx,[rbp+0FFE0]
       call      System.Security.Cryptography.Rfc2898DeriveBytes.get_Salt()
       mov       rsi,rax
       mov       rcx,[rbp+0FFE0]
       mov       edx,20
       call      qword ptr [7FF85D617150]
       mov       rdi,rax
       mov       rcx,[rbp+0FFE0]
       mov       edx,1
       call      qword ptr [7FF85D617168]
       mov       rcx,[rbp+0FFE0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,offset MT_System.Byte[]
       mov       edx,31
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       byte ptr [rbx+10],1
       mov       dword ptr [rsp+20],10
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       mov       r9d,1
       call      System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       dword ptr [rsp+20],20
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       mov       r9d,11
       call      System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rbx
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       jmp       near ptr System.Convert.ToBase64String(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       edx,1
       call      qword ptr [7FF85D617168]
       mov       rcx,[rbp+0FFE0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 288
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.HashPasswordWithSHA256()
; 			var result = EncryptionHelper.HashPasswordWithSHA256(Password);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,2B2CC5D1560
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
; dotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPassword(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,10
       call      dotNetTips.Spargine.Core.Security.SHA256PasswordHasher.GenerateSalt(Int32)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      dotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
       mov       rsi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       add       edx,11
       jo        short M01_L00
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       cmp       dword ptr [rbp+8],0
       jbe       short M01_L01
       mov       byte ptr [rbp+10],1
       mov       dword ptr [rsp+20],10
       mov       rcx,rdi
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,1
       call      System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       mov       r9d,11
       call      System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Convert.ToBase64String(Byte[])
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 157
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
; 			var result = EncryptionHelper.SimpleSHA256Decrypt(this._cypherText, Key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,[rsi+0D0]
       mov       rdx,236BADD9938
       mov       rdx,[rdx]
       lea       rcx,[rsp+28]
       call      dotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rdi
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      dotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```
```assembly
; dotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,236BADD19F8
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Security.Cryptography.SHA256CryptoServiceProvider
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.SHA256CryptoServiceProvider..ctor()
       mov       [rbp+0FFD0],r14
       mov       rcx,rbx
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF85D618D98]
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF85D618D98]
       mov       rdi,rax
       mov       rcx,[rbp+0FFD0]
       mov       rdx,r14
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rbx,rax
       mov       rcx,[rbp+0FFD0]
       mov       rdx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       [rbp+0FFD8],rax
       lea       rcx,[rbp+0FFD8]
       mov       edx,10
       call      System.Array.Resize[[System.Byte, System.Private.CoreLib]](Byte[] ByRef, Int32)
       mov       rdi,[rbp+0FFD8]
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D615EE0]
       mov       rcx,[rbp+0FFD0]
       mov       byte ptr [rcx+18],1
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
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
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D615EE0]
       mov       rcx,[rbp+0FFD0]
       mov       byte ptr [rcx+18],1
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 300
```
```assembly
; dotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp+0FFB8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Security.Cryptography.AesManaged
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       lea       rcx,[r14+40]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD0],r14
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       [rbp+0FFC8],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFC0],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       rdx,[rbp+0FFC0]
       mov       r8,[rbp+0FFC8]
       xor       r9d,r9d
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFB8],rsi
       mov       rcx,offset MT_System.IO.StreamReader
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsp+20],400
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,236BADD1AD8
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,1
       call      System.IO.StreamReader..ctor(System.IO.Stream, System.Text.Encoding, Boolean, Int32, Boolean)
       mov       [rbp+0FFB0],rsi
       mov       rcx,[rbp+0FFB0]
       call      qword ptr [7FF85D61D9F0]
       mov       rsi,rax
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF85D61D9C8]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF85D619EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF85D6198D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF85D250598
       call      qword ptr [7FF85D610598]
       nop
M02_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D618E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D618E30]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF85D61D9C8]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L01:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L02
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF85D619EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
M02_L02:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L03
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF85D6198D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L03:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L04
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF85D250598
       call      qword ptr [7FF85D610598]
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M02_L05
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D618E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D618E30]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 860
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
; 			var result = EncryptionHelper.SimpleSHA256Encrypt(LongTestString, Key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,2AC3AB29938
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      dotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,2AC3AB29930
       mov       rcx,[rcx]
       mov       rdx,[rsp+20]
       mov       r8,[rsp+28]
       call      dotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 96
```
```assembly
; dotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,2AC3AB219F8
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Security.Cryptography.SHA256CryptoServiceProvider
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.SHA256CryptoServiceProvider..ctor()
       mov       [rbp+0FFD0],r14
       mov       rcx,rbx
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF85D648D98]
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF85D648D98]
       mov       rdi,rax
       mov       rcx,[rbp+0FFD0]
       mov       rdx,r14
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rbx,rax
       mov       rcx,[rbp+0FFD0]
       mov       rdx,rdi
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       [rbp+0FFD8],rax
       lea       rcx,[rbp+0FFD8]
       mov       edx,10
       call      System.Array.Resize[[System.Byte, System.Private.CoreLib]](Byte[] ByRef, Int32)
       mov       rdi,[rbp+0FFD8]
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D645EE0]
       mov       rcx,[rbp+0FFD0]
       mov       byte ptr [rcx+18],1
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
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
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D645EE0]
       mov       rcx,[rbp+0FFD0]
       mov       byte ptr [rcx+18],1
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 300
```
```assembly
; dotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFA8],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Security.Cryptography.AesManaged
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       lea       rcx,[r14+40]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD0],r14
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       [rbp+0FFC8],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFC0],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFC0]
       mov       r8,[rbp+0FFC8]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFB8],rdi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,2AC3AB22540
       mov       r8,[r8]
       mov       rcx,rdi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       [rbp+0FFB0],rdi
       mov       rcx,[rbp+0FFB0]
       mov       rdx,rsi
       call      qword ptr [7FF85D648118]
       nop
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF85D648080]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF85D649EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FF85D6499A0]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rsi,rax
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF85D6498D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF85D2805A8
       call      qword ptr [7FF85D6405A8]
       nop
M02_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D648E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D648E30]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF85D648080]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L01:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M02_L02
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF85D649EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
M02_L02:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L03
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF85D6498D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L03:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L04
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF85D2805A8
       call      qword ptr [7FF85D6405A8]
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M02_L05
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF85D648E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D648E30]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 861
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.VerifyPBKDF2HashedPassword()
; 			var result = EncryptionHelper.VerifyPBKDF2HashedPassword(this._hashedPasswordPBKDF2, Password);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,194A5289940
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.VerifyHashedPassword(System.String, System.String)
       mov       [rsp+28],eax
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       rdx,[rsp+28]
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[dotNetTips.Spargine.Core.Security.PasswordVerificationResult, dotNetTips.Spargine.5.Core]](dotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; dotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.VerifyHashedPassword(System.String, System.String)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC8],rsp
       mov       rsi,rdx
       test      rcx,rcx
       je        near ptr M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L00
       call      System.Convert.FromBase64String(System.String)
       mov       rdi,rax
       mov       ecx,[rdi+8]
       test      ecx,ecx
       jle       near ptr M01_L00
       cmp       ecx,0
       jbe       near ptr M01_L02
       movzx     ecx,byte ptr [rdi+10]
       cmp       ecx,1
       jg        near ptr M01_L00
       mov       rcx,offset MT_System.Byte[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       dword ptr [rsp+20],10
       mov       rcx,rdi
       mov       r8,rbx
       mov       edx,1
       xor       r9d,r9d
       call      System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rsp+20],20
       mov       rcx,rdi
       mov       r8,r14
       mov       edx,11
       xor       r9d,r9d
       call      System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,offset MT_System.Security.Cryptography.Rfc2898DeriveBytes
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      dotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.get_HashAlgorithmName()
       mov       r15,rax
       mov       rcx,194A5281AD8
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF85D60C978]
       mov       rdx,rax
       mov       [rsp+20],r15
       mov       rcx,rdi
       mov       r8,rbx
       mov       r9d,0C350
       call      System.Security.Cryptography.Rfc2898DeriveBytes..ctor(Byte[], Byte[], Int32, System.Security.Cryptography.HashAlgorithmName)
       mov       [rbp+0FFD0],rdi
       mov       rcx,[rbp+0FFD0]
       mov       edx,20
       call      qword ptr [7FF85D617150]
       mov       rsi,rax
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D617168]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,r14
       mov       rdx,rsi
       call      dotNetTips.Spargine.Core.Security.PBKDF2PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       test      eax,eax
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       mov       eax,1
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF85D617168]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L03:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 427
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[dotNetTips.Spargine.Core.Security.PasswordVerificationResult, dotNetTips.Spargine.5.Core]](dotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       ret
; Total bytes of code 1
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.VerifySHA256HashedPassword()
; 			var result = EncryptionHelper.VerifySHA256HashedPassword(this._hashedPasswordPBKDF2, Password);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0B0]
       mov       rdx,1F54A997948
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Security.SHA256PasswordHasher.VerifyHashedPassword(System.String, System.String)
       mov       [rsp+28],eax
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       rdx,[rsp+28]
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[dotNetTips.Spargine.Core.Security.PasswordVerificationResult, dotNetTips.Spargine.5.Core]](dotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; dotNetTips.Spargine.Core.Security.SHA256PasswordHasher.VerifyHashedPassword(System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L04
       call      System.Convert.FromBase64String(System.String)
       test      rax,rax
       jne       short M01_L00
       xor       edi,edi
       xor       ebx,ebx
       jmp       short M01_L01
M01_L00:
       lea       rdi,[rax+10]
       mov       ebx,[rax+8]
M01_L01:
       test      ebx,ebx
       jle       near ptr M01_L04
       cmp       ebx,0
       jbe       near ptr M01_L07
       movzx     edx,byte ptr [rdi]
       cmp       edx,1
       jg        near ptr M01_L04
       mov       edx,ebx
       cmp       rdx,11
       jb        near ptr M01_L06
       lea       rbp,[rdi+1]
       mov       edx,10
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rbp
       mov       r8d,10
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbp,rdi
       lea       edx,[rbx+0FFEF]
       mov       ecx,edx
       add       rcx,11
       mov       eax,ebx
       cmp       rcx,rax
       ja        short M01_L06
       add       rbp,11
       test      edx,edx
       jne       short M01_L02
       mov       rdx,1F52A992C88
       mov       rdi,[rdx]
       jmp       short M01_L03
M01_L02:
       movsxd    rdi,edx
       mov       rdx,rdi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8,rdi
       mov       rdx,rbp
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,rbx
M01_L03:
       mov       rcx,rsi
       mov       rdx,r14
       call      dotNetTips.Spargine.Core.Security.SHA256PasswordHasher.HashPasswordWithSalt(System.String, Byte[])
       mov       rcx,rax
       mov       rdx,rdi
       call      dotNetTips.Spargine.Core.Security.SHA256PasswordHasher.FixedTimeEquals(Byte[], Byte[])
       test      eax,eax
       jne       short M01_L05
M01_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 292
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[dotNetTips.Spargine.Core.Security.PasswordVerificationResult, dotNetTips.Spargine.5.Core]](dotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       ret
; Total bytes of code 1
```

