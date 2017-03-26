MSBuild.exe grnline.fs.sln /property:Configuration=Debug /property:VisualStudioVersion=14.0 /target:rebuild

$inputs = @(
  ".\grnline.fs.Tests\bin\Debug\grnline.fs.Tests.dll"
)

.\packages\Persimmon.Console\tools\Persimmon.Console.exe $inputs
