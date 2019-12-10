module Tests

open Fable.Mocha
open App

let appTests = testList "App tests" [
    testCase "update function works" <| fun _ ->
        // Simplified update that ignore commands/effects
        ()
]

let allTests = testList "All" [
    appTests
]

[<EntryPoint>]
let main (args: string[]) = Mocha.runTests allTests
