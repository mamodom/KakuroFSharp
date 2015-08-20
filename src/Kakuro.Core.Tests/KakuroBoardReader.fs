namespace Kakuro.Core.Tests

module ``Kakuro board reader`` =
    open NUnit.Framework
    open FsUnit
    open Kakuro.Core.BoardParser
    open Kakuro.Core
    open Kakuro.Libs.FileReader
       
    [<Test>]
    let ``Should read a board entirely`` () =
        parseBoard "board1-4x4.kakuro" readFile
        |> should equal [
        [Sums(None, None);Sums(Some(16), None);Sums(Some(15), None);Sums(None, None)];
        [Sums(None, Some(17));Value(None);Value(None);Sums(Some(4), None)];
        [Sums(None, Some(15));Value(None);Value(None);Value(None)];
        [Sums(None, None);Sums(None, Some(3));Value(None);Value(None)]
        ]

    [<Test>]
    let ``Read File`` () =
        readFile "board1-4x4.kakuro"
        |> should equal [
            """\	16\	15\	\""";
            """\17			4\""";
            """\15			""";
            """\	\3		"""]