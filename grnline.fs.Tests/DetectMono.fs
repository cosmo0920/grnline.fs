namespace grnline.fs.Tests
open System

module DetectMonoTestHelper =
    let is_mono =
        let t = Type.GetType "Mono.Runtime"
        t = null |> not