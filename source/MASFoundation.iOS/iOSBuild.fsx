#r @"packages/FAKE/tools/FakeLib.dll"
open Fake
open Fake.XamarinHelper

//Our variables such as project, solution, etc.
let solution = "MASFoundation.iOS"
let iOSproject = "MASFoundation.iOS"

Target "MASUnit.ios" (fun () ->
    iOSBuild (fun defaults ->
        {defaults with
            ProjectPath = solution
            Configuration = "Debug|iPhone"
            Target = "Build"
        })
    TeamCityHelper.PublishArtifact (iOSproject + "/bin/iPhone/Debug/*.ipa")
)