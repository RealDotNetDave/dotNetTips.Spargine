## DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark-20231026-201120
**Diff for AesDecrypt method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesDecrypt()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+190]
        mov       rdx,[rsi+1A0]
        mov       r8,[rsi+198]
-       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
+       call      qword ptr [7FF9CE4597B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
-; Total bytes of code 76
+; Total bytes of code 77
 ; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
        push      rbp
        sub       rsp,0B0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        vmovdqa   xmmword ptr [rbp-70],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-88],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
-       cmp       dword ptr [7FF9C7866D08],0
+       cmp       dword ptr [7FF9CE309F50],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
-       mov       r9,2388F1118F0
+       mov       r9,1BF73C00950
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2389F113020
+       mov       r9,1BF63C02028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CE4CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-30],rax
        mov       r9,[rbp-30]
        mov       [rbp+10],r9
-       mov       r9,2389F119B70
+       mov       r9,1BF63C04BC0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2389F113020
+       mov       r9,1BF63C02028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE4CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-38],rax
        mov       r9,[rbp-38]
        mov       [rbp+18],r9
-       mov       r9,2389F113150
+       mov       r9,1BF63C02148
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2389F113020
+       mov       r9,1BF63C02028
        mov       r9,[r9]
        mov       rdx,[rbp+20]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE4CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
        mov       [rbp+20],rcx
        mov       rcx,offset MT_System.IO.MemoryStream
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
-       call      System.IO.MemoryStream..ctor()
+       call      qword ptr [7FF9CE4CF2D0]; System.IO.MemoryStream..ctor()
        mov       rcx,[rbp-48]
        mov       [rbp-8],rcx
        nop
        mov       rcx,offset MT_System.Security.Cryptography.AesCng
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      System.Security.Cryptography.AesCng..ctor()
+       call      qword ptr [7FF9CE6C9210]; System.Security.Cryptography.AesCng..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-58],rcx
        mov       rcx,[rbp-10]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
        mov       rax,[rbp-10]
        mov       rax,[rax]
        mov       rax,[rax+50]
        call      qword ptr [rax+38]
        mov       [rbp-60],rax
        mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       rdx,[rbp-58]
        mov       r8,[rbp-60]
        mov       r9d,1
-       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode)
+       call      qword ptr [7FF9CE6C94F8]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode)
        mov       rcx,[rbp-68]
        mov       [rbp-18],rcx
        nop
        mov       rcx,offset MT_System.IO.StreamWriter
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-70],rax
        mov       rcx,[rbp-70]
        mov       rdx,[rbp-18]
-       call      System.IO.StreamWriter..ctor(System.IO.Stream)
+       call      qword ptr [7FF9CE2656A8]; System.IO.StreamWriter..ctor(System.IO.Stream)
        mov       rcx,[rbp-70]
        mov       [rbp-20],rcx
        nop
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+10]
        mov       rax,[rbp-20]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        nop
        nop
        nop
-       jmp       short M01_L02
-M01_L02:
        mov       rcx,rsp
-       call      M01_L05
+       call      M01_L02
        nop
        nop
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rcx,rsp
-       call      M01_L07
+       call      M01_L04
        nop
        mov       rcx,[rbp-8]
        mov       rax,[rbp-8]
        mov       rax,[rax]
        mov       rax,[rax+68]
        call      qword ptr [rax+30]
        mov       [rbp-78],rax
        mov       rcx,[rbp-78]
-       call      System.Convert.ToBase64String(Byte[])
+       call      qword ptr [7FF9CE49F5B8]; System.Convert.ToBase64String(Byte[])
        mov       [rbp-80],rax
        mov       rcx,[rbp-80]
        mov       [rbp-28],rcx
        nop
-       jmp       short M01_L04
-M01_L04:
        mov       rcx,rsp
-       call      M01_L09
+       call      M01_L06
        nop
        mov       rcx,rsp
-       call      M01_L11
+       call      M01_L08
        nop
        mov       rax,[rbp-28]
        add       rsp,0B0
        pop       rbp
        ret
-M01_L05:
+M01_L02:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0B0]
        cmp       qword ptr [rbp-20],0
-       je        short M01_L06
+       je        short M01_L03
        mov       rcx,[rbp-20]
-       mov       r11,7FF9C75B0500
-       call      qword ptr [7FF9C75B0500]
+       mov       r11,7FF9CDEB0460
+       call      qword ptr [r11]
        nop
-M01_L06:
+M01_L03:
        nop
        add       rsp,30
        pop       rbp
        ret
-M01_L07:
+M01_L04:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0B0]
        cmp       qword ptr [rbp-18],0
-       je        short M01_L08
+       je        short M01_L05
        mov       rcx,[rbp-18]
-       mov       r11,7FF9C75B0508
-       call      qword ptr [7FF9C75B0508]
+       mov       r11,7FF9CDEB0468
+       call      qword ptr [r11]
        nop
-M01_L08:
+M01_L05:
        nop
        add       rsp,30
        pop       rbp
        ret
-M01_L09:
+M01_L06:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0B0]
        cmp       qword ptr [rbp-10],0
-       je        short M01_L10
+       je        short M01_L07
        mov       rcx,[rbp-10]
-       mov       r11,7FF9C75B0510
-       call      qword ptr [7FF9C75B0510]
+       mov       r11,7FF9CDEB0470
+       call      qword ptr [r11]
        nop
-M01_L10:
+M01_L07:
        nop
        add       rsp,30
        pop       rbp
        ret
-M01_L11:
+M01_L08:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0B0]
        cmp       qword ptr [rbp-8],0
-       je        short M01_L12
+       je        short M01_L09
        mov       rcx,[rbp-8]
-       mov       r11,7FF9C75B0518
-       call      qword ptr [7FF9C75B0518]
+       mov       r11,7FF9CDEB0478
+       call      qword ptr [r11]
        nop
-M01_L12:
+M01_L09:
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 841
+; Total bytes of code 831
```
**Diff for AesEncrypt method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesEncrypt()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
        mov       rdx,[rsi+1A0]
        mov       r8,[rsi+198]
-       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
+       call      qword ptr [7FF9CE4697B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
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
-; Total bytes of code 73
+; Total bytes of code 74
 ; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
        push      rbp
        sub       rsp,0B0
        lea       rbp,[rsp+0B0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-80],xmm4
        vmovdqa   xmmword ptr [rbp-70],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-88],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
-       cmp       dword ptr [7FF9C7886D08],0
+       cmp       dword ptr [7FF9CE319F50],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
-       mov       r9,20FA92A18F0
+       mov       r9,19EB7400950
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20F492A3020
+       mov       r9,19EA5402028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CE4DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-30],rax
        mov       r9,[rbp-30]
        mov       [rbp+10],r9
-       mov       r9,20F492A9B70
+       mov       r9,19EA5408B98
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20F492A3020
+       mov       r9,19EA5402028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE4DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-38],rax
        mov       r9,[rbp-38]
        mov       [rbp+18],r9
-       mov       r9,20F492A3150
+       mov       r9,19EA5402148
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20F492A3020
+       mov       r9,19EA5402028
        mov       r9,[r9]
        mov       rdx,[rbp+20]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE4DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
        mov       [rbp+20],rcx
        mov       rcx,offset MT_System.IO.MemoryStream
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
-       call      System.IO.MemoryStream..ctor()
+       call      qword ptr [7FF9CE4DF2D0]; System.IO.MemoryStream..ctor()
        mov       rcx,[rbp-48]
        mov       [rbp-8],rcx
        nop
        mov       rcx,offset MT_System.Security.Cryptography.AesCng
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-50],rax
        mov       rcx,[rbp-50]
-       call      System.Security.Cryptography.AesCng..ctor()
+       call      qword ptr [7FF9CE6D78A0]; System.Security.Cryptography.AesCng..ctor()
        mov       rcx,[rbp-50]
        mov       [rbp-10],rcx
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-58],rcx
        mov       rcx,[rbp-10]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
        mov       rax,[rbp-10]
        mov       rax,[rax]
        mov       rax,[rax+50]
        call      qword ptr [rax+38]
        mov       [rbp-60],rax
        mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       rdx,[rbp-58]
        mov       r8,[rbp-60]
        mov       r9d,1
-       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode)
+       call      qword ptr [7FF9CE6D7B88]; System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode)
        mov       rcx,[rbp-68]
        mov       [rbp-18],rcx
        nop
        mov       rcx,offset MT_System.IO.StreamWriter
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-70],rax
        mov       rcx,[rbp-70]
        mov       rdx,[rbp-18]
-       call      System.IO.StreamWriter..ctor(System.IO.Stream)
+       call      qword ptr [7FF9CE2756A8]; System.IO.StreamWriter..ctor(System.IO.Stream)
        mov       rcx,[rbp-70]
        mov       [rbp-20],rcx
        nop
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+10]
        mov       rax,[rbp-20]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        nop
        nop
        nop
-       jmp       short M01_L02
-M01_L02:
        mov       rcx,rsp
-       call      M01_L05
+       call      M01_L02
        nop
        nop
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rcx,rsp
-       call      M01_L07
+       call      M01_L04
        nop
        mov       rcx,[rbp-8]
        mov       rax,[rbp-8]
        mov       rax,[rax]
        mov       rax,[rax+68]
        call      qword ptr [rax+30]
        mov       [rbp-78],rax
        mov       rcx,[rbp-78]
-       call      System.Convert.ToBase64String(Byte[])
+       call      qword ptr [7FF9CE4AF5B8]; System.Convert.ToBase64String(Byte[])
        mov       [rbp-80],rax
        mov       rcx,[rbp-80]
        mov       [rbp-28],rcx
        nop
-       jmp       short M01_L04
-M01_L04:
        mov       rcx,rsp
-       call      M01_L09
+       call      M01_L06
        nop
        mov       rcx,rsp
-       call      M01_L11
+       call      M01_L08
        nop
        mov       rax,[rbp-28]
        add       rsp,0B0
        pop       rbp
        ret
-M01_L05:
+M01_L02:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0B0]
        cmp       qword ptr [rbp-20],0
-       je        short M01_L06
+       je        short M01_L03
        mov       rcx,[rbp-20]
-       mov       r11,7FF9C75D0500
-       call      qword ptr [7FF9C75D0500]
+       mov       r11,7FF9CDEC0460
+       call      qword ptr [r11]
        nop
-M01_L06:
+M01_L03:
        nop
        add       rsp,30
        pop       rbp
        ret
-M01_L07:
+M01_L04:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0B0]
        cmp       qword ptr [rbp-18],0
-       je        short M01_L08
+       je        short M01_L05
        mov       rcx,[rbp-18]
-       mov       r11,7FF9C75D0508
-       call      qword ptr [7FF9C75D0508]
+       mov       r11,7FF9CDEC0468
+       call      qword ptr [r11]
        nop
-M01_L08:
+M01_L05:
        nop
        add       rsp,30
        pop       rbp
        ret
-M01_L09:
+M01_L06:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0B0]
        cmp       qword ptr [rbp-10],0
-       je        short M01_L10
+       je        short M01_L07
        mov       rcx,[rbp-10]
-       mov       r11,7FF9C75D0510
-       call      qword ptr [7FF9C75D0510]
+       mov       r11,7FF9CDEC0470
+       call      qword ptr [r11]
        nop
-M01_L10:
+M01_L07:
        nop
        add       rsp,30
        pop       rbp
        ret
-M01_L11:
+M01_L08:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
        lea       rbp,[rbp+0B0]
        cmp       qword ptr [rbp-8],0
-       je        short M01_L12
+       je        short M01_L09
        mov       rcx,[rbp-8]
-       mov       r11,7FF9C75D0518
-       call      qword ptr [7FF9C75D0518]
+       mov       r11,7FF9CDEC0478
+       call      qword ptr [r11]
        nop
-M01_L12:
+M01_L09:
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 841
+; Total bytes of code 831
```
**Diff for SimpleSHA256Decrypt method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleSHA256Decrypt()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       mov       rdx,2CC5EDC9E08
+       mov       rdx,2032E800228
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
+       call      qword ptr [7FF9CE469810]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CE743BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 78
+; Total bytes of code 80
 ; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Decrypt(System.String, System.String)
        push      rbp
        sub       rsp,70
        vzeroupper
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C7876D08],0
+       cmp       dword ptr [7FF9CE319F50],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,2CCCEDC1CA8
+       mov       r9,20344800CE0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2CC5EDC3020
+       mov       r9,20332800030
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CE4DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-20],rax
        mov       r9,[rbp-20]
        mov       [rbp+10],r9
-       mov       r9,2CC5EDC9B70
+       mov       r9,20332806BA0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2CC5EDC3020
+       mov       r9,20332800030
        mov       r9,[r9]
        mov       rcx,[rbp+18]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CE4DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        lea       rcx,[rbp-38]
        mov       rdx,[rbp+18]
-       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
+       call      qword ptr [7FF9CE469780]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
        vmovdqu   xmm0,xmmword ptr [rbp-38]
        vmovdqu   xmmword ptr [rbp-10],xmm0
        mov       rcx,[rbp+10]
        mov       rdx,[rbp-10]
        mov       r8,[rbp-8]
-       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
+       call      qword ptr [7FF9CE469798]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesDecrypt(System.String, Byte[], Byte[])
        mov       [rbp-40],rax
        mov       rax,[rbp-40]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L01
-M01_L01:
        mov       rax,[rbp-18]
        add       rsp,70
        pop       rbp
        ret
-; Total bytes of code 245
+; Total bytes of code 247
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
**Diff for SimpleEncrypt method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.SimpleEncrypt()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,1B17B4B9E08
+       mov       rdx,1813A000228
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
+       call      qword ptr [7FF9CE5F9828]; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CE8D1330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Core.Security.EncryptionHelper.SimpleSHA256Encrypt(System.String, System.String)
        push      rbp
        sub       rsp,70
        vzeroupper
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C7896D08],0
+       cmp       dword ptr [7FF9CE4A9F50],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,1B1DB4B18F0
+       mov       r9,1814A000950
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1B17B4B3020
+       mov       r9,18138002028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CE66BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-20],rax
        mov       r9,[rbp-20]
        mov       [rbp+10],r9
-       mov       r9,1B17B4B9B70
+       mov       r9,18138008B98
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1B17B4B3020
+       mov       r9,18138002028
        mov       r9,[r9]
        mov       rcx,[rbp+18]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CE66BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        lea       rcx,[rbp-38]
        mov       rdx,[rbp+18]
-       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
+       call      qword ptr [7FF9CE5F9780]; DotNetTips.Spargine.Core.Security.EncryptionHelper.GetSHA256HashKeys(System.String)
        vmovdqu   xmm0,xmmword ptr [rbp-38]
        vmovdqu   xmmword ptr [rbp-10],xmm0
        mov       rcx,[rbp+10]
        mov       rdx,[rbp-10]
        mov       r8,[rbp-8]
-       call      DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
+       call      qword ptr [7FF9CE5F97B0]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
        mov       [rbp-40],rax
        mov       rax,[rbp-40]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L01
-M01_L01:
        mov       rax,[rbp-18]
        add       rsp,70
        pop       rbp
        ret
-; Total bytes of code 245
+; Total bytes of code 247
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
