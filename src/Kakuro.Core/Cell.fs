namespace Kakuro.Core

type cell = 
    |Value of int option
    |Sums of columnSum: int option * rowSum: int option
    override m.ToString() = 
        match m with
        | Value (None) -> ""
        | Value (i) -> i.Value.ToString()
        | Sums(None, None) -> "X"
        | Sums(None, r) -> "\\" + r.Value.ToString()
        | Sums(c, None) -> c.Value.ToString() + "\\"
        | Sums(c, r) -> c.Value.ToString() + "\\" + r.Value.ToString()