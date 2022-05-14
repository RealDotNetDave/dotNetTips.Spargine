## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
; 			var result = EncryptionHelper.AesEncrypt(this._aesCypherText, this._aesKey, this._aesIv);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0A8]
       mov       rdx,[rsi+0B8]
       mov       r8,[rsi+0B0]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FF98],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rax,1FDBA703020
       mov       r14,[rax]
       mov       r15,r14
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
       cmp       dword ptr [r15+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r15,rcx
M01_L04:
       mov       rdx,1FDBA7060F0
       mov       rdx,[rdx]
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       r15,r14
       test      rsi,rsi
       je        short M01_L06
       lea       rdx,[rbp+0FFD0]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M01_L06
       cmp       dword ptr [rbp+0FFD0],0
       setg      al
       movzx     eax,al
       jmp       short M01_L07
M01_L06:
       xor       eax,eax
M01_L07:
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [r15+8],0
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       r15,rcx
M01_L09:
       mov       rdx,1FDBA705B08
       mov       rdx,[rdx]
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       mov       r15,r14
       test      rdi,rdi
       je        short M01_L11
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rdi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M01_L11
       cmp       dword ptr [rbp+0FFC8],0
       setg      al
       movzx     eax,al
       jmp       short M01_L12
M01_L11:
       xor       eax,eax
M01_L12:
       movzx     eax,al
       test      eax,eax
       jne       short M01_L14
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [r15+8],0
       je        short M01_L13
       mov       rcx,r15
       jmp       short M01_L13
M01_L13:
       mov       rdx,1FDBA7032C0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L14:
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,r15
       mov       [rbp+0FFC0],rcx
       mov       rdx,rsi
       call      qword ptr [7FFE646325D8]
       mov       rcx,[rbp+0FFC0]
       mov       rdx,rdi
       call      qword ptr [7FFE646325C8]
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FFE646340F8]
       mov       [rbp+0FFB8],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFB0],rsi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,[rbp+0FFB8]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFA8],rdi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,1FDBA702578
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rdi
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp+0FFA0],rcx
       mov       rdx,rbx
       call      qword ptr [7FFE64629BC0]
       nop
       mov       rcx,[rbp+0FFA0]
       mov       edx,1
       call      qword ptr [7FFE64629B28]
       mov       rcx,[rbp+0FFA0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFE646334B0]
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rsi
       call      qword ptr [7FFE64632EE8]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       r15,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE64632E18]
       mov       rcx,rsi
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp+0FFB8]
       test      r8,r8
       je        short M01_L15
       mov       rcx,r8
       mov       r11,7FFE64290560
       call      qword ptr [7FFE64630560]
       nop
M01_L15:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FFE64632640]
       mov       rax,r15
       add       rsp,68
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFA0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFA0]
       mov       edx,1
       call      qword ptr [7FFE64629B28]
       mov       rcx,[rbp+0FFA0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L16:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L17
       mov       rcx,[rbp+0FFA8]
       mov       edx,1
       call      qword ptr [7FFE646334B0]
       mov       rcx,[rbp+0FFA8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L17:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M01_L18
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FFE64632E18]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L18:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFE64290560
       call      qword ptr [7FFE64630560]
M01_L19:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L20
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FFE64632640]
M01_L20:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1050
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
; 			var result = EncryptionHelper.AesEncrypt(LongTestString, this._aesKey, this._aesIv);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       r8,[rsi+0B0]
       mov       rcx,205AAD59558
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FF98],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rax,205AAD53020
       mov       r14,[rax]
       mov       r15,r14
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
       cmp       dword ptr [r15+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r15,rcx
M01_L04:
       mov       rdx,205AAD5A8C8
       mov       rdx,[rdx]
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       r15,r14
       test      rsi,rsi
       je        short M01_L06
       lea       rdx,[rbp+0FFD0]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M01_L06
       cmp       dword ptr [rbp+0FFD0],0
       setg      al
       movzx     eax,al
       jmp       short M01_L07
M01_L06:
       xor       eax,eax
M01_L07:
       movzx     eax,al
       test      eax,eax
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [r15+8],0
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       r15,rcx
M01_L09:
       mov       rdx,2058AD51700
       mov       rdx,[rdx]
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       mov       r15,r14
       test      rdi,rdi
       je        short M01_L11
       lea       rdx,[rbp+0FFC8]
       mov       rcx,rdi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M01_L11
       cmp       dword ptr [rbp+0FFC8],0
       setg      al
       movzx     eax,al
       jmp       short M01_L12
M01_L11:
       xor       eax,eax
M01_L12:
       movzx     eax,al
       test      eax,eax
       jne       short M01_L14
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [r15+8],0
       je        short M01_L13
       mov       rcx,r15
       jmp       short M01_L13
M01_L13:
       mov       rdx,205AAD532C0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L14:
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,r15
       mov       [rbp+0FFC0],rcx
       mov       rdx,rsi
       call      qword ptr [7FFE646125D8]
       mov       rcx,[rbp+0FFC0]
       mov       rdx,rdi
       call      qword ptr [7FFE646125C8]
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FFE646140F8]
       mov       [rbp+0FFB8],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFB0],rsi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,[rbp+0FFB8]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFA8],rdi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,205AAD52578
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rdi
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp+0FFA0],rcx
       mov       rdx,rbx
       call      qword ptr [7FFE64609BC0]
       nop
       mov       rcx,[rbp+0FFA0]
       mov       edx,1
       call      qword ptr [7FFE64609B28]
       mov       rcx,[rbp+0FFA0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFE646134B0]
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rsi
       call      qword ptr [7FFE64612EE8]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       r15,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE64612E18]
       mov       rcx,rsi
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp+0FFB8]
       test      r8,r8
       je        short M01_L15
       mov       rcx,r8
       mov       r11,7FFE64270560
       call      qword ptr [7FFE64610560]
       nop
M01_L15:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FFE64612640]
       mov       rax,r15
       add       rsp,68
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFA0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFA0]
       mov       edx,1
       call      qword ptr [7FFE64609B28]
       mov       rcx,[rbp+0FFA0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L16:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L17
       mov       rcx,[rbp+0FFA8]
       mov       edx,1
       call      qword ptr [7FFE646134B0]
       mov       rcx,[rbp+0FFA8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L17:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M01_L18
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FFE64612E18]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L18:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L19
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFE64270560
       call      qword ptr [7FFE64610560]
M01_L19:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L20
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FFE64612640]
M01_L20:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1050
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
; 			var result = EncryptionHelper.SimpleSHA256Decrypt(this._cypherText, Key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       mov       rdx,23438FB1180
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
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
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,23448FB1028
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
       mov       rdx,23428FB40E8
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
       mov       rdx,23428FB36F8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rsi
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 264
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
; 			var result = EncryptionHelper.SimpleSHA256Encrypt(LongTestString, Key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1B62CAC5150
       mov       rcx,[rcx]
       mov       rdx,1B62CAC5158
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rax,1B5FCAC3020
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
       mov       rdx,1B5FCAC60F0
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
       mov       rdx,1B5FCAC5B08
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L10:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
       mov       rcx,rsi
       mov       rdx,[rsp+28]
       mov       r8,[rsp+30]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 264
```

