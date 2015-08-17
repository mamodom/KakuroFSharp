﻿namespace Kakuro.Core

module Parser =
    let subString (s: string)  (startIndex: int)  (length: int) : string =
        s.Substring(startIndex, length)

    let indexOf (delimiter: char) (s: string): int =
        s.IndexOf(delimiter)

    let lenght (s: string) =
        s.Length

    let parseValue (s: string) =
        match s with
        |"" -> None
        |s -> Some (int s)
    
    type cell = 
        |Value of int option
        |Sums of columnSum: int option * rowSum: int option
        override m.ToString() = 
            match m with
            | Value (None) -> ""
            | Value (i) -> i.Value.ToString()
            | Sums(None, None) -> "X"//System.Convert.ToChar(187).ToString()
            | Sums(None, r) -> "\\" + r.Value.ToString()
            | Sums(c, None) -> c.Value.ToString() + "\\"
            | Sums(c, r) -> c.Value.ToString() + "\\" + r.Value.ToString()

    let parseValueCell (s: string) =
        match s with 
        |"" -> None
        | s -> Some (int s)
        |> Value

    let parseColumnSumCell (slashIndex: int) (s: string) =
        subString s 0 slashIndex
        |> parseValue
    
    let parseRowSumCell (slashIndex: int) (s: string) =
        lenght s - (slashIndex + 1)
        |> subString s (slashIndex + 1)
        |> parseValue
        

    let parseSumCell (slashIndex: int) (s: string) =
        Sums(parseColumnSumCell slashIndex s, parseRowSumCell slashIndex s)

    
    let parseCell (s: string) =
        match (indexOf '\\' s) with
        | -1 -> parseValueCell s
        | i -> parseSumCell i s
