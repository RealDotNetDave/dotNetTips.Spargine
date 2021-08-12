## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
; 			var result = this._person.As<IPerson>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0D8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.As(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1F2A5241028
       mov       r8,[r8]
       mov       rdx,1F295243158
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      CORINFO_HELP_CHKCASTARRAY
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Clone01()
; 			var result = this._person.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0D8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,15F48C61028
       mov       r8,[r8]
       mov       rdx,15F58C61160
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9EA2C2110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Clone03()
; 			var result = this._personRecord with { };
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E0]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
; 			var result = this._person.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       r8,145407F1028
       mov       r8,[r8]
       mov       rdx,145307F3158
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD0],rdi
       mov       rcx,145307F1AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0E1248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
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
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L02
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,145307F1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,145307F3160
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L04
       call      System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L03
       cmp       r14d,ebx
       jg        short M01_L00
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9EA0E7D20]
       mov       r15,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       jmp       short M01_L01
M01_L05:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA0E4A90]
       mov       rax,r15
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA0E4A90]
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 382
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
; 			var result = this._personRecord.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E0]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       r8,11FBD5F3020
       mov       r8,[r8]
       mov       rdx,11FCD5F1978
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD0],rdi
       mov       rcx,11FBD5F1AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA101248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
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
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L02
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,11FBD5F1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,11FCD5F1980
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L04
       call      System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L03
       cmp       r14d,ebx
       jg        short M01_L00
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9EA107D20]
       mov       r15,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       jmp       short M01_L01
M01_L05:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA105058]
       mov       rax,r15
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA105058]
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 382
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
; 			var disposableType = new DataTable("TEST");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			disposableType.DisposeFields();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rdx,1F683CB1160
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Data.DataTable..ctor(System.String)
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
; Total bytes of code 57
```
```assembly
; System.Data.DataTable..ctor(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Data.DataTable..ctor()
       test      rdi,rdi
       je        short M01_L00
       mov       rdx,rdi
       jmp       short M01_L01
M01_L00:
       mov       rdx,1F653CB3020
       mov       rdx,[rdx]
M01_L01:
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 60
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L00
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,rsi
       call      00007FFA4995F070
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeFields(System.Type)
       mov       rdi,rax
       mov       rcx,7FF9EA154430
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F673CB9860
       mov       r8,[rcx]
       test      r8,r8
       jne       short M02_L01
       mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F673CB9858
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M02_L08
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<DisposeFields>b__4_0(System.Reflection.FieldInfo)
       mov       [rbx+18],rdx
       mov       rcx,1F673CB9860
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M02_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L02
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       near ptr M02_L06
M02_L03:
       cmp       ebx,[rdi+10]
       jae       near ptr M02_L09
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       near ptr M02_L10
       movsxd    rdx,ebx
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rbp,rax
       test      rbp,rbp
       je        short M02_L05
       mov       rdx,rbp
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L04
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       jmp       short M02_L05
M02_L04:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L05
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ProcessCollectionToDispose(System.Collections.IEnumerable)
M02_L05:
       add       ebx,1
       jo        short M02_L07
       cmp       ebx,[rdi+10]
       jl        short M02_L03
M02_L06:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
M02_L08:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M02_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 404
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty()
; 			var result = this._person.HasProperty("City");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
       mov       rdx,29FE9541160
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,29FD9543020
       mov       r8,[r8]
       mov       rdx,29FE9541168
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FFA4995F070
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass5_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull()
; 			var result = this._person.IsNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0D8]
       test      rax,rax
       setne     al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull()
; 			var result = this._person.IsNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0D8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
; 			var result = this._personRecord with { Id = "12345678" };
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+0E0]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdi,rax
       mov       rdx,19CC0F31160
       mov       rdx,[rdx]
       lea       rcx,[rdi+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 77
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
; 			var person = this._person;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
       mov       rdx,23207A81028
       mov       rdx,[rdx]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF50],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,23207A81028
       mov       r8,[r8]
       mov       rdx,231F7A83158
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,23207A81028
       mov       r8,[r8]
       mov       rdx,231F7A83160
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rdi,rdi
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L00
       mov       r8,231F7A83168
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,rdi
       call      00007FFA4995F070
       mov       r15,rax
       mov       rcx,7FF9EA161C28
       mov       edx,2A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23207A89A28
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L09
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FF9E9D104B8
       call      qword ptr [7FF9EA1204B8]
       mov       [rbp+0FF88],rax
M01_L02:
       mov       rcx,[rbp+0FF88]
       mov       r11,7FF9E9D104C0
       call      qword ptr [7FF9EA1204C0]
       test      eax,eax
       je        near ptr M01_L07
       mov       rcx,[rbp+0FF88]
       mov       r11,7FF9E9D104C8
       call      qword ptr [7FF9EA1204C8]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L05
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,231F7A81340
       mov       r8,[r8]
       mov       rax,231F7A83170
       mov       rax,[rax]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],r12
       mov       [r9+10],rdx
       mov       [r9+18],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,7FF9EA164430
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23207A89C80
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,23207A89C70
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L06
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,23207A89C80
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,23207A89C88
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,23207A89C70
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L06
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rdx
       mov       rcx,23207A89C88
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r15
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r15d,ebx
       jmp       near ptr M01_L02
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L07:
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L08
       mov       rcx,rax
       mov       r11,7FF9E9D104D0
       call      qword ptr [7FF9EA1204D0]
M01_L08:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FFB0]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       lea       rcx,[rbp+0FFB0]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r15,rax
       mov       rcx,23207A81028
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       short M01_L10
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       word ptr [rax+8],2E
       xor       r8d,r8d
       mov       rdx,231F7A81340
       mov       rdx,[rdx]
       mov       rcx,231F7A83178
       mov       rcx,[rcx]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],rax
       mov       [r9+10],r8
       mov       [r9+18],rdx
       lea       r8,[rbp+0FF90]
       mov       rdx,rcx
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       r12,rax
M01_L10:
       xor       esi,esi
       mov       r13d,[r15+8]
       test      r13d,r13d
       jle       near ptr M01_L16
M01_L11:
       movsxd    rcx,esi
       mov       rax,[r15+rcx*8+10]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       mov       [rbp+0FF80],rax
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+30]
       test      bl,bl
       je        near ptr M01_L18
       mov       [rbp+0FF78],rax
       test      rax,rax
       je        near ptr M01_L15
M01_L12:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp+0FF70],rax
       mov       rcx,[rbp+0FF80]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,231F7A81340
       mov       r8,[r8]
       mov       r9,[rbp+0FF70]
       mov       r10,231F7A83178
       mov       r10,[r10]
       lea       r11,[rbp+0FF90]
       mov       [r11],rcx
       mov       [r11+8],rax
       mov       [r11+10],rdx
       mov       [r11+18],r8
       mov       rcx,r9
       mov       rdx,r10
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp+0FF78]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r14,rax
       mov       rcx,7FF9EA164430
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23207A89C90
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L13
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,23207A89C70
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L19
       mov       [rbp+0FF58],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp+0FF58]
       mov       [rax+18],rdx
       mov       rcx,23207A89C90
       mov       [rbp+0FF58],rax
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+0FF58]
M01_L13:
       mov       rcx,23207A89C98
       mov       r9,[rcx]
       mov       [rbp+0FF68],rax
       test      r9,r9
       jne       near ptr M01_L17
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       rdx,23207A89C70
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L19
       mov       [rbp+0FF60],r9
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF60]
       mov       [r9+18],rdx
       mov       rcx,23207A89C98
       mov       [rbp+0FF60],r9
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp+0FF60]
       mov       rax,[rbp+0FF68]
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L15:
       inc       esi
       cmp       r13d,esi
       jg        near ptr M01_L11
M01_L16:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rax,[rbp+0FF68]
       jmp       short M01_L14
M01_L18:
       mov       [rbp+0FF78],rax
       jmp       near ptr M01_L12
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L20
       mov       rcx,rax
       mov       r11,7FF9E9D104D0
       call      qword ptr [7FF9EA1204D0]
M01_L20:
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
; Total bytes of code 1778
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
; 			var person = this._person;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
       mov       rdx,214F12F3020
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF50],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,214F12F3020
       mov       r8,[r8]
       mov       rdx,214E12F1160
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,214F12F3020
       mov       r8,[r8]
       mov       rdx,214E12F1168
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rdi,rdi
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L00
       mov       r8,214E12F1170
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,rdi
       call      00007FFA4995F070
       mov       r15,rax
       mov       rcx,7FF9EA141C28
       mov       edx,2A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,214F12FBA20
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L09
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FF9E9CF04B8
       call      qword ptr [7FF9EA1004B8]
       mov       [rbp+0FF88],rax
M01_L02:
       mov       rcx,[rbp+0FF88]
       mov       r11,7FF9E9CF04C0
       call      qword ptr [7FF9EA1004C0]
       test      eax,eax
       je        near ptr M01_L07
       mov       rcx,[rbp+0FF88]
       mov       r11,7FF9E9CF04C8
       call      qword ptr [7FF9EA1004C8]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L05
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,214F12F1340
       mov       r8,[r8]
       mov       rax,214E12F1178
       mov       rax,[rax]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],r12
       mov       [r9+10],rdx
       mov       [r9+18],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,7FF9EA144430
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,214F12FBC78
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,214F12FBC68
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L06
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,214F12FBC78
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,214F12FBC80
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,214F12FBC68
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L06
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rdx
       mov       rcx,214F12FBC80
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r15
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r15d,ebx
       jmp       near ptr M01_L02
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L07:
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L08
       mov       rcx,rax
       mov       r11,7FF9E9CF04D0
       call      qword ptr [7FF9EA1004D0]
M01_L08:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FFB0]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       lea       rcx,[rbp+0FFB0]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r15,rax
       mov       rcx,214F12F3020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       short M01_L10
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       word ptr [rax+8],2E
       xor       r8d,r8d
       mov       rdx,214F12F1340
       mov       rdx,[rdx]
       mov       rcx,214E12F1180
       mov       rcx,[rcx]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],rax
       mov       [r9+10],r8
       mov       [r9+18],rdx
       lea       r8,[rbp+0FF90]
       mov       rdx,rcx
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       r12,rax
M01_L10:
       xor       esi,esi
       mov       r13d,[r15+8]
       test      r13d,r13d
       jle       near ptr M01_L16
M01_L11:
       movsxd    rcx,esi
       mov       rax,[r15+rcx*8+10]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       mov       [rbp+0FF80],rax
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+30]
       test      bl,bl
       je        near ptr M01_L18
       mov       [rbp+0FF78],rax
       test      rax,rax
       je        near ptr M01_L15
M01_L12:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp+0FF70],rax
       mov       rcx,[rbp+0FF80]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,214F12F1340
       mov       r8,[r8]
       mov       r9,[rbp+0FF70]
       mov       r10,214E12F1180
       mov       r10,[r10]
       lea       r11,[rbp+0FF90]
       mov       [r11],rcx
       mov       [r11+8],rax
       mov       [r11+10],rdx
       mov       [r11+18],r8
       mov       rcx,r9
       mov       rdx,r10
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp+0FF78]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r14,rax
       mov       rcx,7FF9EA144430
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,214F12FBC88
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L13
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,214F12FBC68
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L19
       mov       [rbp+0FF58],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp+0FF58]
       mov       [rax+18],rdx
       mov       rcx,214F12FBC88
       mov       [rbp+0FF58],rax
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+0FF58]
M01_L13:
       mov       rcx,214F12FBC90
       mov       r9,[rcx]
       mov       [rbp+0FF68],rax
       test      r9,r9
       jne       near ptr M01_L17
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       rdx,214F12FBC68
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L19
       mov       [rbp+0FF60],r9
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF60]
       mov       [r9+18],rdx
       mov       rcx,214F12FBC90
       mov       [rbp+0FF60],r9
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp+0FF60]
       mov       rax,[rbp+0FF68]
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L15:
       inc       esi
       cmp       r13d,esi
       jg        near ptr M01_L11
M01_L16:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rax,[rbp+0FF68]
       jmp       short M01_L14
M01_L18:
       mov       [rbp+0FF78],rax
       jmp       near ptr M01_L12
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L20
       mov       rcx,rax
       mov       r11,7FF9E9CF04D0
       call      qword ptr [7FF9EA1004D0]
M01_L20:
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
; Total bytes of code 1778
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E0]
       mov       rdx,23A15B93020
       mov       rdx,[rdx]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF50],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,23A15B93020
       mov       r8,[r8]
       mov       rdx,23A25B91160
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,23A15B93020
       mov       r8,[r8]
       mov       rdx,23A25B91168
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rdi,rdi
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L00
       mov       r8,23A25B91170
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,rdi
       call      00007FFA4995F070
       mov       r15,rax
       mov       rcx,7FF9EA161C28
       mov       edx,2A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23A05B97618
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L09
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FF9E9D104B8
       call      qword ptr [7FF9EA1204B8]
       mov       [rbp+0FF88],rax
M01_L02:
       mov       rcx,[rbp+0FF88]
       mov       r11,7FF9E9D104C0
       call      qword ptr [7FF9EA1204C0]
       test      eax,eax
       je        near ptr M01_L07
       mov       rcx,[rbp+0FF88]
       mov       r11,7FF9E9D104C8
       call      qword ptr [7FF9EA1204C8]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L05
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,23A15B91340
       mov       r8,[r8]
       mov       rax,23A25B91178
       mov       rax,[rax]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],r12
       mov       [r9+10],rdx
       mov       [r9+18],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,7FF9EA164430
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23A05B97870
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,23A05B97860
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L06
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,23A05B97870
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,23A05B97878
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,23A05B97860
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L06
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rdx
       mov       rcx,23A05B97878
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r15
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r15d,ebx
       jmp       near ptr M01_L02
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L07:
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L08
       mov       rcx,rax
       mov       r11,7FF9E9D104D0
       call      qword ptr [7FF9EA1204D0]
M01_L08:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FFB0]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       lea       rcx,[rbp+0FFB0]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r15,rax
       mov       rcx,23A15B93020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       short M01_L10
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       word ptr [rax+8],2E
       xor       r8d,r8d
       mov       rdx,23A15B91340
       mov       rdx,[rdx]
       mov       rcx,23A25B91180
       mov       rcx,[rcx]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],rax
       mov       [r9+10],r8
       mov       [r9+18],rdx
       lea       r8,[rbp+0FF90]
       mov       rdx,rcx
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       r12,rax
M01_L10:
       xor       esi,esi
       mov       r13d,[r15+8]
       test      r13d,r13d
       jle       near ptr M01_L16
M01_L11:
       movsxd    rcx,esi
       mov       rax,[r15+rcx*8+10]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       mov       [rbp+0FF80],rax
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+30]
       test      bl,bl
       je        near ptr M01_L18
       mov       [rbp+0FF78],rax
       test      rax,rax
       je        near ptr M01_L15
M01_L12:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp+0FF70],rax
       mov       rcx,[rbp+0FF80]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,23A15B91340
       mov       r8,[r8]
       mov       r9,[rbp+0FF70]
       mov       r10,23A25B91180
       mov       r10,[r10]
       lea       r11,[rbp+0FF90]
       mov       [r11],rcx
       mov       [r11+8],rax
       mov       [r11+10],rdx
       mov       [r11+18],r8
       mov       rcx,r9
       mov       rdx,r10
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp+0FF78]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r14,rax
       mov       rcx,7FF9EA164430
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23A05B97880
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L13
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,23A05B97860
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L19
       mov       [rbp+0FF58],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp+0FF58]
       mov       [rax+18],rdx
       mov       rcx,23A05B97880
       mov       [rbp+0FF58],rax
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+0FF58]
M01_L13:
       mov       rcx,23A05B97888
       mov       r9,[rcx]
       mov       [rbp+0FF68],rax
       test      r9,r9
       jne       near ptr M01_L17
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       rdx,23A05B97860
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L19
       mov       [rbp+0FF60],r9
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF60]
       mov       [r9+18],rdx
       mov       rcx,23A05B97888
       mov       [rbp+0FF60],r9
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp+0FF60]
       mov       rax,[rbp+0FF68]
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L15:
       inc       esi
       cmp       r13d,esi
       jg        near ptr M01_L11
M01_L16:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rax,[rbp+0FF68]
       jmp       short M01_L14
M01_L18:
       mov       [rbp+0FF78],rax
       jmp       near ptr M01_L12
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L20
       mov       rcx,rax
       mov       r11,7FF9E9D104D0
       call      qword ptr [7FF9EA1204D0]
M01_L20:
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
; Total bytes of code 1778
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E0]
       mov       rdx,234F9323020
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF50],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,234F9323020
       mov       r8,[r8]
       mov       rdx,23509321160
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,234F9323020
       mov       r8,[r8]
       mov       rdx,23509321168
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rdi,rdi
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L00
       mov       r8,23509321170
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,rdi
       call      00007FFA4995F070
       mov       r15,rax
       mov       rcx,7FF9EA171C28
       mov       edx,2A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,234F932BA20
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L09
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FF9E9D204B8
       call      qword ptr [7FF9EA1304B8]
       mov       [rbp+0FF88],rax
M01_L02:
       mov       rcx,[rbp+0FF88]
       mov       r11,7FF9E9D204C0
       call      qword ptr [7FF9EA1304C0]
       test      eax,eax
       je        near ptr M01_L07
       mov       rcx,[rbp+0FF88]
       mov       r11,7FF9E9D204C8
       call      qword ptr [7FF9EA1304C8]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr M01_L05
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,234F9321340
       mov       r8,[r8]
       mov       rax,23509321178
       mov       rax,[rax]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],r12
       mov       [r9+10],rdx
       mov       [r9+18],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,7FF9EA174430
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,234F932BC78
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,234F932BC68
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L06
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,234F932BC78
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,234F932BC80
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,234F932BC68
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L06
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rdx
       mov       rcx,234F932BC80
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r15
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r15d,ebx
       jmp       near ptr M01_L02
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L07:
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L08
       mov       rcx,rax
       mov       r11,7FF9E9D204D0
       call      qword ptr [7FF9EA1304D0]
M01_L08:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FFB0]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       lea       rcx,[rbp+0FFB0]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r15,rax
       mov       rcx,234F9323020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       short M01_L10
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       word ptr [rax+8],2E
       xor       r8d,r8d
       mov       rdx,234F9321340
       mov       rdx,[rdx]
       mov       rcx,23509321180
       mov       rcx,[rcx]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],rax
       mov       [r9+10],r8
       mov       [r9+18],rdx
       lea       r8,[rbp+0FF90]
       mov       rdx,rcx
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       r12,rax
M01_L10:
       xor       esi,esi
       mov       r13d,[r15+8]
       test      r13d,r13d
       jle       near ptr M01_L16
M01_L11:
       movsxd    rcx,esi
       mov       rax,[r15+rcx*8+10]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       mov       [rbp+0FF80],rax
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+30]
       test      bl,bl
       je        near ptr M01_L18
       mov       [rbp+0FF78],rax
       test      rax,rax
       je        near ptr M01_L15
M01_L12:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp+0FF70],rax
       mov       rcx,[rbp+0FF80]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,234F9321340
       mov       r8,[r8]
       mov       r9,[rbp+0FF70]
       mov       r10,23509321180
       mov       r10,[r10]
       lea       r11,[rbp+0FF90]
       mov       [r11],rcx
       mov       [r11+8],rax
       mov       [r11+10],rdx
       mov       [r11+18],r8
       mov       rcx,r9
       mov       rdx,r10
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp+0FF78]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r14,rax
       mov       rcx,7FF9EA174430
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,234F932BC88
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L13
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,234F932BC68
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L19
       mov       [rbp+0FF58],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp+0FF58]
       mov       [rax+18],rdx
       mov       rcx,234F932BC88
       mov       [rbp+0FF58],rax
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+0FF58]
M01_L13:
       mov       rcx,234F932BC90
       mov       r9,[rcx]
       mov       [rbp+0FF68],rax
       test      r9,r9
       jne       near ptr M01_L17
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       rdx,234F932BC68
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L19
       mov       [rbp+0FF60],r9
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF60]
       mov       [r9+18],rdx
       mov       rcx,234F932BC90
       mov       [rbp+0FF60],r9
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp+0FF60]
       mov       rax,[rbp+0FF68]
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L15:
       inc       esi
       cmp       r13d,esi
       jg        near ptr M01_L11
M01_L16:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rax,[rbp+0FF68]
       jmp       short M01_L14
M01_L18:
       mov       [rbp+0FF78],rax
       jmp       near ptr M01_L12
M01_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L20
       mov       rcx,rax
       mov       r11,7FF9E9D204D0
       call      qword ptr [7FF9EA1304D0]
M01_L20:
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
; Total bytes of code 1778
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
; 			var person = this._person;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,24CFB1C1650
       mov       r9,[r9]
       mov       rdx,24CFB1B3020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,24CFB1B3020
       mov       r8,[r8]
       mov       rdx,24CDB1B1160
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,24CFB1B3020
       mov       r8,[r8]
       mov       rdx,24CDB1B1168
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,24CDB1B1170
       mov       rdx,[rdx]
       mov       r8,24CFB1B3020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFA4995F070
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,4
       call      System.String.Compare(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L00
       mov       r8,24CDB1B1178
       mov       rbx,[r8]
       jmp       short M01_L01
M01_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L01
       mov       r8,24CFB1B3020
       mov       rbx,[r8]
M01_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 418
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString02()
; 			var person = this._person;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9,15D016D12D8
       mov       r9,[r9]
       mov       rdx,15D216D3020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,15D216D3020
       mov       r8,[r8]
       mov       rdx,15D116D1160
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,15D216D3020
       mov       r8,[r8]
       mov       rdx,15D116D1168
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,15D116D1170
       mov       rdx,[rdx]
       mov       r8,15D216D3020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFA4995F070
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,4
       call      System.String.Compare(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L00
       mov       r8,15D116D1178
       mov       rbx,[r8]
       jmp       short M01_L01
M01_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L01
       mov       r8,15D216D3020
       mov       rbx,[r8]
M01_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 418
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0E0]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,248D3AE1650
       mov       r9,[r9]
       mov       rdx,248D3AD3020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,248D3AD3020
       mov       r8,[r8]
       mov       rdx,248D3AE1CF0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,248D3AD3020
       mov       r8,[r8]
       mov       rdx,248D3AE1CF8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,248D3AE1D00
       mov       rdx,[rdx]
       mov       r8,248D3AD3020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFA4995F070
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,4
       call      System.String.Compare(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L00
       mov       r8,248D3AE1D08
       mov       rbx,[r8]
       jmp       short M01_L01
M01_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L01
       mov       r8,248D3AD3020
       mov       rbx,[r8]
M01_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 418
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString04()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0E0]
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9,1FA5B071650
       mov       r9,[r9]
       mov       rdx,1FA5B063020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,1FA5B063020
       mov       r8,[r8]
       mov       rdx,1FA3B061160
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1FA5B063020
       mov       r8,[r8]
       mov       rdx,1FA3B061168
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,1FA3B061170
       mov       rdx,[rdx]
       mov       r8,1FA5B063020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFA4995F070
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,4
       call      System.String.Compare(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L00
       mov       r8,1FA3B061178
       mov       rbx,[r8]
       jmp       short M01_L01
M01_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L01
       mov       r8,1FA5B063020
       mov       rbx,[r8]
M01_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 418
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
; 			var result = this._person.StripNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
       test      rcx,rcx
       je        short M00_L00
       call      qword ptr [7FF9EA1122D0]
       jmp       short M00_L01
M00_L00:
       mov       rax,2539C3D3020
       mov       rax,[rax]
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; dotNetTips.Spargine.Tester.Models.PersonProper.ToString()
; 		public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);
; 		                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+48]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rsi],esi
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
; 			var result = this._person.ToJson();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rcx,rcx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       mov       rax,159C9401028
       mov       rax,[rax]
       ret
M01_L00:
       mov       rdx,rcx
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize(!!0, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       jmp       near ptr System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
; Total bytes of code 48
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
; 			var result = this._personRecord.ToJson();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E0]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rcx,rcx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       mov       rax,201B68D3020
       mov       rax,[rax]
       ret
M01_L00:
       mov       rdx,rcx
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize(!!0, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       jmp       near ptr System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
; Total bytes of code 48
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
; 			var disposableType = new DataTable("TEST");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			disposableType.TryDispose();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rdx,277E3C63570
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Data.DataTable..ctor(System.String)
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rsi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
; Total bytes of code 59
```
```assembly
; System.Data.DataTable..ctor(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Data.DataTable..ctor()
       test      rdi,rdi
       je        short M01_L00
       mov       rdx,rdi
       jmp       short M01_L01
M01_L00:
       mov       rdx,277E3C63020
       mov       rdx,[rdx]
M01_L01:
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 60
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       [rbp+18],edx
       mov       rsi,rcx
       test      rsi,rsi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L00
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IAsyncDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       lea       rdx,[rbp+0FFE8]
       mov       rcx,rax
       mov       r11,7FF9E9D104F0
       call      qword ptr [7FF9EA1204F0]
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       r11,7FF9E9D104E8
       call      qword ptr [7FF9EA1204E8]
       nop
M02_L02:
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       byte ptr [rbp+18],0
       je        short M02_L03
       call      CORINFO_HELP_RETHROW
M02_L03:
       lea       rax,[7FF9EA1282F7]
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 170
```

