namespace Kakuro.Core

module Utils =
    let indexOf (delimiter: char) (s: string): int =
        s.IndexOf(delimiter)
    
    let length (s: string) =
        s.Length

    let subString (s: string)  (startIndex: int)  (length: int) : string =
        s.Substring(startIndex, length)

        
    let intOption (s: string) =
        match s with
        |"" -> None
        |s -> Some (int s)