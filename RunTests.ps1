.\.nuget\NuGet.exe Install Persimmon.Console -Pre -OutputDirectory packages -ExcludeVersion

C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe grnline.fs.sln /property:Configuration=Debug /property:VisualStudioVersion=12.0 /target:rebuild

$inputs = @(
  ".\grnline.fs.Tests\bin\Debug\grnline.fs.Tests.dll"
)

.\packages\Persimmon.Console\tools\Persimmon.Console.exe $inputs
