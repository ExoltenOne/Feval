namespace Feval.Tests

open Feval
open Xunit

type Class2() = 
    member this.X = "F#"

    [<Fact>]
    member this.``Test`` () =
        let c = new Class1()
        c.X = "F#"
