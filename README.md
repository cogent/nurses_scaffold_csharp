# Nurses Rostering

## Challenge

In a hospital environment, nurses work a rotating shift system. There are three work shifts per day; a morning shift, an evening shift and a night shift. Each day, all three shift needs to be filled.

You have been tasked with developing a rostering system which can calculate and output the nursing roster for any specified month.

A list of rosterable nurses has been provided in the file [Nurses.Tests/SampleData/nurses.csv](Nurses.Tests/SampleData/nurses.csv).

## Considerations

- 5 nurses need to be on staff for each shift.
- Nurses must not be expected to work more than one shift per day.
- To maintain a healthy work/life balance, no nurse can be asked to work for more than 5 days in a row.
- Similarly, no nurse can be expected to work more than five night shifts per month.
- Days off must occur in groups of two or more.

## Scaffold Code

Some code has already been provided to help save you time. This focusses on the following areas.

1. Providing a command line interface so that this app can be called with parameters and provide help information.
2. Handling of input and output, such as parsing a file of nurses, and formatting the resulting roster to text, for printing to standard out.
3. A few basic data classes such as Roster and Nurse, mainly provided so that the input and output handling code has something to work with.

You're welcome to change any of this code if you like, but the goal is to save you time so you can show us how you'd like to solve the interesting parts of this problem, not spend your time formatting strings for output.

## Development

### prerequisites

- [dotnet core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)

check the version you have installed with

```bash
$ dotnet --version
```

### run the app

The application is intended to be used as a command line interface (CLI) tool. You can invoke it with the dotnet CLI.

```bash
$ cd Nurses

$ dotnet run --start 2020-04-10 --end 2020-05-10 --input-file ../Nurses.Tests/SampleData/nurses.csv

# or, run it from the root of the repository by specifying the Nurses project using the --project flag

$ dotnet run --project Nurses --start 2020-04-10 --end 2020-05-10 --input-file Nurses.Tests/SampleData/nurses.csv
```

### run the tests

```bash
$ dotnet test
```

## Pairing Opportunities

- Implement the Rostering logic.
- Add support for another type of input file (maybe JSON). The app currently only supports CSV.
- What if we introduced more validation on the arguments that have been supplied to the main program? How might we better handle validations and make the concept of argument validation more extendable in this code?
