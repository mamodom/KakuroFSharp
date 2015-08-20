namespace Kakuro.Libs

module FileReader =
    open System.IO
    
    let readFile filePath =
        File.ReadLines(filePath)