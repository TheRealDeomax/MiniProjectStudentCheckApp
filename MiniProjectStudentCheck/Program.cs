// Requirements
// Ask the user for their name and age

Console.Write(value:"What is your name:");
string? name=Console.ReadLine();

Console.Write(value: "How old are you:");

bool inputValid = int.TryParse(Console.ReadLine(), out int age);
// example bool isValidInt = int.TryParse(ageText, out int age);

if (name.Length == 0) inputValid = false;


switch (inputValid)
{
    case true: 
        
            if ( ((name.ToLower() == "sue") || (name.ToLower() == "bob") ) && age >= 21 )
                    {
            // if their name is Bob or Sue address them as Profrerssor, otherwise address them by nameConsole.WriteLine(value: "Your age is invalid. I'm sorry.  You cannot attend.");
            Console.WriteLine(value:"Welcome to the class Profressor!");
            }
            else if (age < 21)
            {
            // if the person is under 21, recommend they wait X years until their 21 to start this class
            Console.WriteLine(value:$"I'm sorry. You must wait {21 - age} years to attend.");
            }
            else
            {
            Console.WriteLine(value:$"Welcome to the class {name}!");
            }

        break;
     case false:
        Console.WriteLine(value: "I'm sorry.  Either you did't enter your name or your age is invalid. You cannot attend this class.");
        break;

}





// 

