
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch(weekDay)
{
    case 0:    //case 0: == if(weekDay == 0)
        Console.WriteLine("Its Sunday!");
        break;
    case 1:
        Console.WriteLine("Its Monday!");
        break;
    case 2:
        Console.WriteLine("Its Tuesday!");
        break;
    case 3:
        Console.WriteLine("Its Wednesday!");
        break;
    default:
        Console.WriteLine("Oops, Your calander must be broken.");
        break;
}


//kui ei ole päev 0 siis soovib lis nice day
Console.WriteLine("Have a nice day!");