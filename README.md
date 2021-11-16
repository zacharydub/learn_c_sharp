YT C# Tutorial
https://www.youtube.com/watch?v=GhQdlIFylQ8

- file setup - 'using xyz' + class{} + main{}

- class = container where we can put code

- need to end every line with semi-colon

- VARIABLES

- DATA TYPES
plain text
  - string - plain text - then use double quotes
  - char - single character - then use single quotes
numbers
  - int - then no quoets needed
  - float, double, decimal (from least accurate to most accurate - for most use cases double is fine. if need to be extremely accurate, like this money, then use decimal)
boolean

- WORKING WITH STRINGS
    - concatenating
    - new line character \n - i.e. Zach\nDubow
    - backslash escape character - i.e. to print out a quotation mark
    - methods - i.e. stringVariable.Length, phrase.ToUpper(), phrase.Contains("some string"), phrase.IndexOf("a"), phrase.Substring(3)
    - using index reference - phrase[2] - starts at 0

- WORKING WITH NUMBERS
    - diff between working with integer vs decimal numbers - 5.0 + 8.1 = 13.1 and 5 + 8.1 = 13.1 whereas 5 / 2 = 2 and 5 / 2.0 = 2.5 --> youll get back the type you put in
    - methods - Math.Abs(-40), Math.Max(4,90), Math.Pow(3,2), Math.Round(4.3)

- GETTING USER INPUT
    - Console.WriteLine() will print text and then go to new line, whereas Console.Write() will print on same line - so if youre using .Readline() afterward and want the user input to be on same line, use .Write()
    - string userInput = Console.ReadLine()

- Building a Mad Libs Game

--new info!
left off 1:15:28
