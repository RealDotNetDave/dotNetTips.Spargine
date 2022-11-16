dotnet clean D:\src\GitHub\dotNetTips.Spargine\source\dotNetTips.Spargine.6.sln

dotnet build D:\src\GitHub\dotNetTips.Spargine\source\dotNetTips.Spargine.6.sln --configuration Release

dotnet pack "D:\src\GitHub\dotNetTips.Spargine\source\6\dotNetTips.Spargine.6.Extensions\dotNetTips.Spargine.6.Extensions.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

dotnet pack "D:\src\GitHub\dotNetTips.Spargine\source\6\dotNetTips.Spargine.6.Core\dotNetTips.Spargine.6.Core.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

dotnet pack "D:\src\GitHub\dotNetTips.Spargine\source\6\dotNetTips.Spargine.6\dotNetTips.Spargine.6.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"

dotnet pack "D:\src\GitHub\dotNetTips.Spargine\source\6\dotNetTips.Spargine.6.Tester\dotNetTips.Spargine.6.Tester.csproj" --include-source --include-symbols --output  "c:\dotNetTips.com\NuGet"