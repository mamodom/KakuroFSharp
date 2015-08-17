namespace Kakuro.Core.Tests

module ``Kakuro cell parser`` =
    open NUnit.Framework
    open FsUnit
    open Kakuro.Core.Parser

    [<Test>]
    let `` parses an empty sum cell`` () =
        (parseCell "\\" ).ToString() 
        |> should equal "X"
        