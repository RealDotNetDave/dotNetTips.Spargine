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
       mov       rcx,[rsi+0B8]
       mov       rdx,[rsi+0C8]
       mov       r8,[rsi+0C0]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       rcx,[rsi+20]
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
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF98],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rsi,rsi
       je        short M01_L02
       cmp       dword ptr [rsi+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,145B2072698
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L01:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L03
       lea       rdx,[rbp+0FFD8]
       mov       rcx,rdi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M01_L03
       cmp       dword ptr [rbp+0FFD8],0
       setg      al
       movzx     eax,al
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
M01_L04:
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,145C2071700
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       test      rbx,rbx
       je        short M01_L06
       lea       rdx,[rbp+0FFD0]
       mov       rcx,rbx
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
       jne       short M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,145D20732C0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L08:
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,r14
       mov       [rbp+0FFC8],rcx
       mov       rdx,rdi
       call      qword ptr [7FFED0B4BEB0]
       mov       rcx,[rbp+0FFC8]
       mov       rdx,rbx
       call      qword ptr [7FFED0B4BEA0]
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFED0B4D3B8]
       mov       [rbp+0FFC0],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFB8],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,[rbp+0FFC0]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFB0],rbx
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,145D2072578
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rbx
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp+0FFA8],rcx
       mov       rdx,rsi
       call      qword ptr [7FFED0B49BC0]
       nop
       mov       rcx,[rbp+0FFA8]
       mov       edx,1
       call      qword ptr [7FFED0B49B28]
       mov       rcx,[rbp+0FFA8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFED0B4C770]
       mov       rcx,rbx
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rdi
       call      qword ptr [7FFED0B43648]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rbx,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFED0B43578]
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp+0FFC0]
       test      r8,r8
       je        short M01_L09
       mov       rcx,r8
       mov       r11,7FFED07A05D0
       call      qword ptr [7FFED0B405D0]
       nop
M01_L09:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFED0B4BF18]
       mov       rax,rbx
       add       rsp,70
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L10
       mov       rcx,[rbp+0FFA8]
       mov       edx,1
       call      qword ptr [7FFED0B49B28]
       mov       rcx,[rbp+0FFA8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L10:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M01_L11
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FFED0B4C770]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L11:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L12
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FFED0B43578]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L12:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L13
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFED07A05D0
       call      qword ptr [7FFED0B405D0]
M01_L13:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L14
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFED0B4BF18]
M01_L14:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 955
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
       mov       rdx,[rsi+0C8]
       mov       r8,[rsi+0C0]
       mov       rcx,25892B21180
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       rcx,[rsi+20]
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
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF98],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rsi,rsi
       je        short M01_L02
       cmp       dword ptr [rsi+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,25892B22698
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L01:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L03
       lea       rdx,[rbp+0FFD8]
       mov       rcx,rdi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M01_L03
       cmp       dword ptr [rbp+0FFD8],0
       setg      al
       movzx     eax,al
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
M01_L04:
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,25862B21700
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L05:
       test      rbx,rbx
       je        short M01_L06
       lea       rdx,[rbp+0FFD0]
       mov       rcx,rbx
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
       jne       short M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,25882B232C0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L08:
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,r14
       mov       [rbp+0FFC8],rcx
       mov       rdx,rdi
       call      qword ptr [7FFED0B3BEB0]
       mov       rcx,[rbp+0FFC8]
       mov       rdx,rbx
       call      qword ptr [7FFED0B3BEA0]
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFED0B3D3B8]
       mov       [rbp+0FFC0],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFB8],rdi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,[rbp+0FFC0]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFB0],rbx
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,25882B22578
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rbx
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp+0FFA8],rcx
       mov       rdx,rsi
       call      qword ptr [7FFED0B39BC0]
       nop
       mov       rcx,[rbp+0FFA8]
       mov       edx,1
       call      qword ptr [7FFED0B39B28]
       mov       rcx,[rbp+0FFA8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFED0B3C770]
       mov       rcx,rbx
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rdi
       call      qword ptr [7FFED0B43648]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rbx,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFED0B43578]
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp+0FFC0]
       test      r8,r8
       je        short M01_L09
       mov       rcx,r8
       mov       r11,7FFED07A0548
       call      qword ptr [7FFED0B40548]
       nop
M01_L09:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFED0B3BF18]
       mov       rax,rbx
       add       rsp,70
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M01_L10
       mov       rcx,[rbp+0FFA8]
       mov       edx,1
       call      qword ptr [7FFED0B39B28]
       mov       rcx,[rbp+0FFA8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L10:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M01_L11
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FFED0B3C770]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L11:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L12
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FFED0B43578]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L12:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L13
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFED07A0548
       call      qword ptr [7FFED0B40548]
M01_L13:
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
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L14
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFED0B3BF18]
M01_L14:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 955
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
       mov       rcx,[rsi+0D0]
       mov       rdx,27C67ED1188
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
       mov       rcx,[rsi+20]
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,rdx
       test      rsi,rsi
       je        near ptr M01_L04
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,27C37ED1A80
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L01:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L05
       cmp       dword ptr [rdi+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,27C57ED9AE0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L03:
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
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
       mov       rcx,2B82A181998
       mov       rcx,[rcx]
       mov       rdx,2B82A1819A0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
       mov       rcx,[rsi+20]
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,rdx
       test      rsi,rsi
       je        near ptr M01_L04
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,2B82A182EB0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L01:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rdi,rdi
       je        short M01_L05
       cmp       dword ptr [rdi+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,2B82A181700
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L03:
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
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 223
```

