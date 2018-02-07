#r @"packages/FAKE/tools/FakeLib.dll"
open Fake
open Fake.XamarinHelper

//Our variables such as project, solution, etc.
let solution = "MASFoundation.Android"
let androidproject = "MASFoundation.Android"

let androidPrameters = [
    ("Configuration", "Debug")
//    ("AndroidKeyStore", "True")
//    ("AndroidSigningKeyStore", "PathToOurKeystore.keystore")
//    ("AndroidSigningStorePass", "OurPassword")
//    ("AndroidSigningKeyAlias", "OurKeyAlias")
//    ("AndroidSigningKeyPass", "OurPassword")
]
//Other variables

Target "android" (fun () ->
    MSBuild "" "SignAndroidPackage" androidPrameters [ androidproject ] |> ignore
    TeamCityHelper.PublishArtifact (androidproject + "/bin/Debug/*-Signed.apk")
)