namespace grnline.fs.Tests

open Persimmon
open Type
open CommandLineParser

module CommandLineParserTest =
    let groonga_path = "C:\\groonga-5.1.0-x64\\groonga-5.1.0-x64\\bin\\groonga.exe"
    let db_path = "test.db"
    let parsed = parseArgv [|"--groonga-path"; groonga_path; "--db-path"; db_path|]
    let config = {
        Config.Path = groonga_path;
        DBPath = db_path;
        DBEncoding = "UTF-8";
        Pretty = false
    }

    let ``commandline argument default config test`` =
        test "commandline argument default config test" {
            do! assertEquals config parsed
        }

    let full_parsed = parseArgv [|"--groonga-path"; groonga_path; "--db-path"; db_path; 
                                  "--encoding"; "SHIFT_JIS"; "--pretty"; "true" |]
    let full_config = {
        Config.Path = groonga_path;
        DBPath = db_path;
        DBEncoding = "SHIFT_JIS";
        Pretty = true
    }

    let ``commandline argument full specified config test`` =
        test "commandline argument full specified config test" {
            do! assertEquals full_config full_parsed
        }

    let ``commandline argument parser exception test`` =
        test "commandline argument parser exception test" {
            let f () =
                parseArgv [|"--groonga-path"; groonga_path;|] |> ignore
            let! e = trap { it (f ()) }
            do! assertEquals typeof<System.ArgumentException> (e.GetType())
        }