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
            do! assertEquals groonga_path config.Path
            do! assertEquals db_path config.DBPath
            do! assertEquals "UTF-8" config.DBEncoding
            do! assertEquals false config.Pretty
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
            do! assertEquals groonga_path full_config.Path
            do! assertEquals db_path full_config.DBPath
            do! assertEquals "SHIFT_JIS" full_config.DBEncoding
            do! assertEquals true full_config.Pretty
        }

    exception MyException

    let ``commandline argument parser exception test`` =
        test "commandline argument parser exception test" {
            let f () =
                parseArgv [|"--groonga-path"; groonga_path;|] |> ignore
            let! e = trap { it (f ()) }
            do! assertEquals typeof<System.ArgumentException> (e.GetType())
        }