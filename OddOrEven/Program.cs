

using System.ComponentModel.Design;

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());
//convert on vaja kasutada sellepärast, et int ei saa salvestada console.readline teksti ehk sõne
//convert konverteerib writeline sisu int jaoks numbriks

//kontrollime kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

Console.WriteLine(result);

if(result != 0) //!= ei ole võrdne 
{
    Console.WriteLine("user number is odd.");
} else
{
    Console.WriteLine("User name is even.");
}
//== tähendab, et kontrollib, et oleksid võrdsed
//!= tähendab, et kontrollib, et ei oleks võrdsed