namespace Kakuro.Core

type Dimension(height: int, width:int) =
    member this.Height = height
    member this.Width = width

type Board(size: Dimension ) = 
    member this.Height = size.Height
    member this.Width = size.Width
    
type Sums(downSum:int option, rightSum:int option) =
    member this.DownSum = downSum
    member this.RightSum = rightSum

type Content = 
    |Empty
    |Value of int
    |Sum of Sums

type Element(content: Content) =
    let Content = content
    
module  Foo =
    let LoadBoard  (path:string) = 
        System.IO.File.ReadLines(path)
        |> Seq.iter(fun x -> printfn  "%s" x) 