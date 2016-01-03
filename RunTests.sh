#!/bin/sh

xbuild grnline.fs.sln /property:Configuration=Debug /property:VisualStudioVersion=12.0 /target:rebuild

inputs="./grnline.fs.Tests/bin/Debug/grnline.fs.Tests.dll"

mono ./packages/Persimmon.Console/tools/Persimmon.Console.exe $inputs
