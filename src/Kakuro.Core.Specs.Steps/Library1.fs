namespace Kakuro.Core.Specs.Steps

module boardParserSteps = 
    open TechTalk.SpecFlow
    open FsUnit
    open NUnit

    let [<Given>] ``this board named Kakuro exists`` () =
        Assert.NotNull null