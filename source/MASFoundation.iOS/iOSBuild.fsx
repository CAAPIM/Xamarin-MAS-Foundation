#r @"packages/FAKE/tools/FakeLib.dll"
open Fake
open Fake.Core

//Our variables such as project, solution, etc.
let solution = "MASFoundation.iOS"
let iOSproject = "MASFoundation.iOS"

Fake.Core.Target(fun() ->

)


Fake.Core.Target "MASFoundation.iOS" (fun () ->
    iOSBuild (fun defaults ->
        {defaults with
            ProjectPath = solution
            Configuration = "Debug|iPhone"
            Target = "Build"
        })
)