grnline.fs
===

A command line tool for Gronga on .NET 4.5.

## Build Status

| Windows Server 2012 R2 (Appveyor) | Mono 4.2.1 or later, OSX (Travis) | Mono 4.2.1 or later, Ubuntu Trusty (Wercker) |
|:------------:|:------------:|:------------:|
| [![Build status](https://ci.appveyor.com/api/projects/status/80nv02co2akud13t/branch/master?svg=true)](https://ci.appveyor.com/project/cosmo0920/grnline-fs/branch/master) | [![Build Status](https://travis-ci.org/cosmo0920/grnline.fs.svg?branch=master)](https://travis-ci.org/cosmo0920/grnline.fs) | [![wercker status](https://app.wercker.com/status/18234624443f2d24c195eabaf16b4f2a/s/master "wercker status")](https://app.wercker.com/project/bykey/18234624443f2d24c195eabaf16b4f2a)


## Try it

### For Windows (.NET Framework)

* You have to install .NET 4.5. (Not client profile)

* Unpack grnline.fs-VERSION.zip

* Execute grnline.fs.exe via cmd.exe or powershell.exe

### For mono platform (Non Windows environment)

* You have to install mono-runtime 4.2.1 or later and fsharp packages from mono repository. In more detail, please refer to .travis.yml(OS X) or wercker.yml(Ubuntu Trusty).

* Unpack grnline.fs-VERSION.zip

* Execute grnline.fs.exe via bash or zsh or other posix like shell.

## Usage

```cmd
cmd> grnline.fs.exe --groonga-path GROONGA_PATH --db-path GROONGA_DB [--encoding ENCODING] [--pretty true]
```

For non-Windows environment, execute this command via `mono` like this:

```bash
$ mono grnline.fs.exe --groonga-path GROONGA_PATH --db-path GROONGA_DB [--encoding ENCODING] [--pretty true]
```

### Example

For Windows:

```cmd
cmd> grnline.fs.exe --groonga-path "C:\\groonga-5.1.0-x64\\groonga-5.1.0-x64\\bin\\groonga.exe" --db-path "test.db" --encoding UTF-8 --pretty true
```

For *nix like environment:

```bash
mono grnline.fs.exe --groonga-path `which groonga` --db-path test.db --encoding UTF-8 --pretty true
```

### Detail

`grnline.fs` create child Groonga process and Groonga child process redirects stdin/stdout to its parent.

You can use pretty printing with adding `--pretty true` to command line arguments.

#### Note

If you enconter space contained path, you can get MS-DOS 8.3 style path with `dir /x` and use it such as `--db-path` arguments.

## Developing

### For Windows

* Install Visual Studio 2015 Community.
* Use paket-bootstrap.exe and paket.exe to restore dependent libraries.
  * Argu (for command line arguments parser)
  * Json.NET (for pretty printing JSON)

### For OS X (advanced)

* Install Xamarin Studio 5.10.2 or later and mono 4.2.1 or later
* Restore dependent libraries.
  * Argu (for command line arguments parser)
  * Json.NET (for pretty printing JSON)

### For Ubuntu Trusty (advanced)

* Install MonoDevelop 5.10 or later and fsharp from mono repository
* Restore dependent libraries.
  * Argu (for command line arguments parser)
  * Json.NET (for pretty printing JSON)

## Testing

Note that this project uses [Persimmon](https://github.com/persimmon-projects/Persimmon) as a testing library.

### For Windows

* Run `RunTests.ps1` on PowerShell. You have to set `Remote-Signed` PowerShell security level with `Set-ExecutionPolicy` Cmdlet.

### For OS X & Ubuntu Trusty

* Run `RunTests.sh`.

## LICENSE

[MIT](LICENSE).
