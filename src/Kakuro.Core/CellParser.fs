namespace Kakuro.Core   

module CellParser =
    open Kakuro.Core.Utils
    
    let parseValueCell (s: string) =
        match s with 
        |"" -> None
        | s -> Some (int s)
        |> Value
        
    let parseColumnSumCell (slashIndex: int) (s: string) =
        subString s 0 slashIndex
        |> intOption
    
    let parseRowSumCell (slashIndex: int) (s: string) =
        length s - (slashIndex + 1)
        |> subString s (slashIndex + 1)
        |> intOption
        
    let parseSumCell (slashIndex: int) (s: string) =
        Sums(parseColumnSumCell slashIndex s, parseRowSumCell slashIndex s)

    let parseCell (s: string) =
        match (indexOf '\\' s) with
        | -1 -> parseValueCell s
        | i -> parseSumCell i s