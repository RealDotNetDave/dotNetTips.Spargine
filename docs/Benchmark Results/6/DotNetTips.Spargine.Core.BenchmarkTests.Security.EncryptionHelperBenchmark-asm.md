## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
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
       mov       rdx,285E7817108
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
       mov       rdx,285E7815B08
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
       mov       rdx,285E78132C0
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
       call      qword ptr [7FFF28D625D8]
       mov       rcx,[rbp+0FFC8]
       mov       rdx,rbx
       call      qword ptr [7FFF28D625C8]
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFF28D640F8]
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
       mov       r8,285E7812578
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rbx
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp+0FFA8],rcx
       mov       rdx,rsi
       call      qword ptr [7FFF28D59BC0]
       nop
       mov       rcx,[rbp+0FFA8]
       mov       edx,1
       call      qword ptr [7FFF28D59B28]
       mov       rcx,[rbp+0FFA8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF28D634B0]
       mov       rcx,rbx
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rdi
       call      qword ptr [7FFF28D62EE8]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rbx,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFF28D62E18]
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp+0FFC0]
       test      r8,r8
       je        short M01_L09
       mov       rcx,r8
       mov       r11,7FFF289B0538
       call      qword ptr [7FFF28D60538]
       nop
M01_L09:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFF28D62640]
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
       call      qword ptr [7FFF28D59B28]
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
       call      qword ptr [7FFF28D634B0]
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
       call      qword ptr [7FFF28D62E18]
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
       mov       r11,7FFF289B0538
       call      qword ptr [7FFF28D60538]
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
       call      qword ptr [7FFF28D62640]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       r8,[rsi+0B0]
       mov       rcx,271477B3988
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
       mov       rdx,271477B4CF8
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
       mov       rdx,271477B36F8
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
       mov       rdx,271377B12C8
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
       call      qword ptr [7FFF28D325D8]
       mov       rcx,[rbp+0FFC8]
       mov       rdx,rbx
       call      qword ptr [7FFF28D325C8]
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFF28D340F8]
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
       mov       r8,271477B2578
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rbx
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       rcx,r14
       mov       [rbp+0FFA8],rcx
       mov       rdx,rsi
       call      qword ptr [7FFF28D39BC0]
       nop
       mov       rcx,[rbp+0FFA8]
       mov       edx,1
       call      qword ptr [7FFF28D39B28]
       mov       rcx,[rbp+0FFA8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF28D334B0]
       mov       rcx,rbx
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,rdi
       call      qword ptr [7FFF28D32EE8]
       mov       rcx,rax
       call      System.Convert.ToBase64String(Byte[])
       mov       rbx,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFF28D32E18]
       mov       rcx,rdi
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       r8,[rbp+0FFC0]
       test      r8,r8
       je        short M01_L09
       mov       rcx,r8
       mov       r11,7FFF28990510
       call      qword ptr [7FFF28D40510]
       nop
M01_L09:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFF28D42640]
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
       call      qword ptr [7FFF28D39B28]
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
       call      qword ptr [7FFF28D334B0]
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
       call      qword ptr [7FFF28D32E18]
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
       mov       r11,7FFF28990510
       call      qword ptr [7FFF28D40510]
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
       call      qword ptr [7FFF28D42640]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       mov       rdx,170A6823178
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
       mov       rdx,170C68220F0
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
       mov       rdx,170C6821700
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,22CAAB01178
       mov       rcx,[rcx]
       mov       rdx,22CAAB01180
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
       mov       rdx,22C9AB038E0
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
       mov       rdx,22CBAB036F8
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

