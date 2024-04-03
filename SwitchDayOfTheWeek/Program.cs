//SWITCH DAY OF THE WEEK

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0 - 6
//sobib selleks, et kontrollida ainult ühte väärtust
//vahemik on 0-6 ni ja väärtus on ainult üks number sellest vahemikust
//switch saab kasutada ainult siis kui on üks kindel väärtus
//JA SIIS kui neid väärtusi on rohkem kui 2

switch(weekDay) //väärtus, mida kontrollitakse
{
    case 0: //case 0: on tegelikult sama  kui if kontroll if(weekDay == 0)
        Console.WriteLine("It's Sunday!");
        break;
    case 1:
        Console.WriteLine("It's Monday!");
        break;
    case 2:
        Console.WriteLine("It's Tuesday!");
        break;
    case 3:
        Console.WriteLine("It's Wednesday!");
        break;
    case 4:
        Console.WriteLine("It's Thursday!");
        break;
    case 5:
        Console.WriteLine("It's Friday!");
        break;
    case 6:
        Console.WriteLine("It's Saturday");
        break;
    default:
        Console.WriteLine("Oops. Your calender must be broken.");
}
Console.WriteLine("have a nice day!");