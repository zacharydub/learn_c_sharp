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
  - float, double, decimal (from least accurate to most accurate - for most use cases double is fine. if need to be extremely accurate, like with money, then use decimal)
boolean

  - can convert using Convert.ToInt or Convert.ToDouble

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

- ARRAYS
  - all elements need to be of same type
  - 2d arrays -> int [,]
    - if need 3d -> int [,,]

- METHODS
  
- IF statements
    -- operators: && and || and negation operator (!)
    -- comparisons < and > and <= and == 

- SWITCH statements

- WHILE / DO LOOPS

- FOR LOOPS

- EXCEPTION HANDLING
  - try/catch

-CLASSES & OBJECTS
  - allow you to create custom data types
    - class = specification for new data type

    rt click on program (Giraffe) in sidebar and click add new item then select class and name it 'Book'
      - then in that file, within class Book brackets, give it attributes:
        public string title;
        public string author;
        public int pages;

    - object == instance of class
  - CONSTRUCTORS = method that gets called whenever we create object of that class
    public NameOfClass(){}
    - can have multiple constructors
  - OBJECT METHODS
  - GETTERS & SETTERS - 2 types of methods that control access to attributes of the class - lets you make data more secure, and to define what data is valid vs. invalid i.e. enforcing certain data
    - Ex: how to enforce that movie ratings are valid
      1. list the rating attribute as private
      2. define getters/setters
      3. adjust attr name to match getter/setter
  - STATIC CLASS ATTRIBUTES
    - belongs to class, not object
    - not unique to each object, rather common across all objects
    - inaccessible to objects by itself - need to access via separate (public) method
  - STATIC METHODS AND CLASSES
    - i.e. Math.Sqrt(81)
    - Math is a static class and so we cant create an instance of Math
      i.e. it's coded under the hood as static class Math{}
  - INHERITANCE
    - use virtual (super-class)+ override (sub-class) keywords to enable overriding polymorphism
