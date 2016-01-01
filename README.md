grnline.fs
===

A command line tool for Gronga on .NET 4.5.

## Build Status

| Windows Server 2012 R2 (Appveyor) | Mono 4.2.1 or later, OSX (Travis) |
|:------------:|:------------:|
| [![Build status](https://ci.appveyor.com/api/projects/status/80nv02co2akud13t/branch/master?svg=true)](https://ci.appveyor.com/project/cosmo0920/grnline-fs/branch/master) | [![Build Status](https://travis-ci.org/cosmo0920/grnline.fs.svg?branch=master)](https://travis-ci.org/cosmo0920/grnline.fs) |


## Try it

* You have to install .NET 4.5. (Not client profile)

* Unpack grnline.fs-VERSION.zip

* Execute grnline.fs.exe via cmd.exe or powershell.exe

## Usage

```cmd
cmd> grnline.fs.exe --groonga-path GROONGA_PATH --db-path GROONGA_DB [--encoding ENCODING] [--pretty true]
```

### Example

```cmd
cmd> grnline.fs.exe --groonga-path "C:\\groonga-5.1.0-x64\\groonga-5.1.0-x64\\bin\\groonga.exe" --db-path "test.db" --encoding UTF-8 --pretty true
```

### Detail

`grnline.fs` create child Groonga process and Groonga child process redirects stdin/stdout to its parent.

You can use pritty printing with adding `--pretty true` to command line arguments.

#### Note

If you enconter space contained path, you can get MS-DOS 8.3 style path with `dir /x` and use it such as `--db-path` arguments.

## Developing

### For Windows

* Install Visual Studio 2013. (Including Express Edition and not VS 2015)
* Use nuget to restore dependent libraries.
  * Argu (for command line arguments parser)
  * Json.NET (for pretty printing JSON)

### For OS X (experimental)

* Install Xamarin Studio 5.10.2 or later
* Restore dependent libraries.
  * Argu (for command line arguments parser)
  * Json.NET (for pretty printing JSON)

## Testing

Note that this project uses [Persimmon](https://github.com/persimmon-projects/Persimmon) as a testing library.

### For Windows

* Run `RunTests.ps1` on PowerShell. You have to set `Remote-Signed` PowerShell security level with `Set-ExecutionPolicy` Cmdlet.

### For OS X

* Run `RunTests.sh`.

## LICENSE

[MIT](LICENSE).
