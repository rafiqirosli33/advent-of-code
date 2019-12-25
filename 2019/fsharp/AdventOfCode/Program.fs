﻿namespace AdventOfCode

module Main =

    open AdventOfCode.Days

    [<EntryPoint>]
    let main argv =
        // let day1 = Day1.Day.Day1("Days\Day1\input.txt")
        // (day1 :> DataStructure.IAdventDay).PrintResults

        // let day2 = Day2.Day.Day2("Days\Day2\input.txt")
        // (day2 :> DataStructure.IAdventDay).PrintResults

        // let day3 = Day3.Day.Day3("Days\Day3\input.txt")
        // (day3 :> DataStructure.IAdventDay).PrintResults

        // let day4 = Day4.Day.Day4("Days\Day4\input.txt")
        // (day4 :> DataStructure.IAdventDay).PrintResults

        let day5 = Day5.Entry.Day5("Days\Day5\input.txt")
        (day5 :> DataStructure.IAdventDay).PrintResults

        0