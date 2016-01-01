namespace grnline.fs.Tests
open System
open Persimmon
open Helper

module DetectMonoTest =
    let should_mono_platform =
        let os = Environment.OSVersion
        let pid = os.Platform
        match pid with
        | PlatformID.Win32NT | PlatformID.Win32S | PlatformID.Win32Windows | PlatformID.WinCE
            -> false
        | PlatformID.Unix
            -> true
        | _ -> false

    let ``should mono platform test`` = test "should mono platform test" {
        do! assertEquals should_mono_platform is_mono
    }