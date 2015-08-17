namespace Kakuro.Core.Tests

module ``Kakuro cell parser`` =
    open NUnit.Framework
    open FsUnit
    open Kakuro.Core.Parser

    [<Test>]
    let ``parses an empty sum cell`` () =
        parseCell "\\"
        |> should equal (Sums(None, None))
    
    [<Test>]
    let ``parses a sum cell without column sum`` () =
        parseCell "\\45"
        |> should equal (Sums(None, Some(45)))
    
    [<Test>]
    let ``parses a sum cell without row sum`` () =
        parseCell "45\\"
        |> should equal (Sums(Some(45), None)) 
    
    [<Test>]
    let ``parses a sum cell`` () =
        parseCell "45\\34"
        |> should equal (Sums(Some(45), Some(34)))
    
    [<Test>]
    let ``parses an empty value cell`` () =
        parseCell ""
        |> should equal (Value(None)) 
    
    [<Test>]
    let ``parses a value cell`` () =
        parseCell "15"
        |> should equal (Value(Some(15)))
    
    