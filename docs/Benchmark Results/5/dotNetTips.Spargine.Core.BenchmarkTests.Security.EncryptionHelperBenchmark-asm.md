## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
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
       mov       r8,2183A8C2540
       mov       r8,[r8]
       mov       rcx,rdi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       [rbp+0FFB0],rdi
       mov       rcx,[rbp+0FFB0]
       mov       rdx,rsi
       call      qword ptr [7FF7AD237918]
       nop
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF7AD237880]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF7AD239EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FF7AD2399A0]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rsi,rax
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF7AD2398D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF7ACE70550
       call      qword ptr [7FF7AD230550]
       nop
M01_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD238E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF7AD238E30]
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
       call      qword ptr [7FF7AD237880]
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
       call      qword ptr [7FF7AD239EE0]
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
       call      qword ptr [7FF7AD2398D0]
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
       mov       r11,7FF7ACE70550
       call      qword ptr [7FF7AD230550]
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
       call      qword ptr [7FF7AD238E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF7AD238E30]
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,22F625D1550
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
       mov       r8,22F825D2540
       mov       r8,[r8]
       mov       rcx,rdi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       [rbp+0FFB0],rdi
       mov       rcx,[rbp+0FFB0]
       mov       rdx,rsi
       call      qword ptr [7FF7AD257918]
       nop
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF7AD257880]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF7AD259EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FF7AD2599A0]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rsi,rax
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF7AD2598D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF7ACE90588
       call      qword ptr [7FF7AD250588]
       nop
M01_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD258E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF7AD258E30]
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
       call      qword ptr [7FF7AD257880]
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
       call      qword ptr [7FF7AD259EE0]
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
       call      qword ptr [7FF7AD2598D0]
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
       mov       r11,7FF7ACE90588
       call      qword ptr [7FF7AD250588]
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
       call      qword ptr [7FF7AD258E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF7AD258E30]
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleDecrypt()
; 			var result = EncryptionHelper.SimpleDecrypt(this._cypherText, Key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,1E535DB3968
       mov       rdx,[rdx]
       lea       rcx,[rsp+28]
       call      dotNetTips.Spargine.Core.Security.EncryptionHelper.GetHashKeys(System.String)
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
; dotNetTips.Spargine.Core.Security.EncryptionHelper.GetHashKeys(System.String)
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
       mov       rcx,1E535DB19F8
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
       call      qword ptr [7FF7AD258D98]
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF7AD258D98]
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
       call      qword ptr [7FF7AD255EE0]
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
       call      qword ptr [7FF7AD255EE0]
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
       mov       r8,1E535DB1AD8
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,1
       call      System.IO.StreamReader..ctor(System.IO.Stream, System.Text.Encoding, Boolean, Int32, Boolean)
       mov       [rbp+0FFB0],rsi
       mov       rcx,[rbp+0FFB0]
       call      qword ptr [7FF7AD24D1C8]
       mov       rsi,rax
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF7AD24D1A0]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF7AD259EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF7AD2598D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF7ACE90568
       call      qword ptr [7FF7AD250568]
       nop
M02_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD258E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF7AD258E30]
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
       call      qword ptr [7FF7AD24D1A0]
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
       call      qword ptr [7FF7AD259EE0]
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
       call      qword ptr [7FF7AD2598D0]
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
       mov       r11,7FF7ACE90568
       call      qword ptr [7FF7AD250568]
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
       call      qword ptr [7FF7AD258E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF7AD258E30]
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
; 			var result = EncryptionHelper.SimpleEncrypt(LongTestString, Key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,21DDFF89938
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      dotNetTips.Spargine.Core.Security.EncryptionHelper.GetHashKeys(System.String)
       mov       rcx,21DDFF89930
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
; dotNetTips.Spargine.Core.Security.EncryptionHelper.GetHashKeys(System.String)
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
       mov       rcx,21DDFF819F8
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
       call      qword ptr [7FF7AD258D98]
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF7AD258D98]
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
       call      qword ptr [7FF7AD255EE0]
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
       call      qword ptr [7FF7AD255EE0]
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
       mov       r8,21DDFF82540
       mov       r8,[r8]
       mov       rcx,rdi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       [rbp+0FFB0],rdi
       mov       rcx,[rbp+0FFB0]
       mov       rdx,rsi
       call      qword ptr [7FF7AD257918]
       nop
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF7AD257880]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF7AD259EE0]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FF7AD2599A0]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rsi,rax
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF7AD2598D0]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF7ACE90590
       call      qword ptr [7FF7AD250590]
       nop
M02_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF7AD258E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF7AD258E30]
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
       call      qword ptr [7FF7AD257880]
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
       call      qword ptr [7FF7AD259EE0]
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
       call      qword ptr [7FF7AD2598D0]
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
       mov       r11,7FF7ACE90590
       call      qword ptr [7FF7AD250590]
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
       call      qword ptr [7FF7AD258E28]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF7AD258E30]
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

