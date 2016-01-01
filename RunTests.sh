#!/bin/sh

mono ./.nuget/NuGet.exe Install Persimmon.Console -Pre -OutputDirectory packages -ExcludeVersion

xbuild grnline.fs.sln /property:Configuration=Debug /property:VisualStudioVersion=12.0 /target:rebuild

inputs="./grnline.fs.Tests/bin/Debug/grnline.fs.Tests.dll"

mono ./packages/Persimmon.Console.1.0.1/tools/Persimmon.Console.exe $inputs