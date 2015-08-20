namespace Kakuro.Core

module BoardParser =
    open CellParser
    
    let parseLine (line:string) =
        line.Split [|'\t'|]
        |> Seq.map parseCell

    let parseBoard (filePath:string) (readFile: string -> seq<string>) =
        readFile filePath
        |> Seq.map parseLine
        