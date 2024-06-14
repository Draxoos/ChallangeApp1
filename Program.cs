{
    string name = "Ewa"; 
    string gender = "Female"; 
    var age = 30; 

    
    if (gender == "Female" && age <= 30) 
    {
        Console.WriteLine("Kobieta poniżej 30 lat"); 
    }

    else if (name == "Ewa" && age == 30)
    {
        Console.WriteLine("Ewa, lat 30"); 
    }
    
    else if (gender == "Male" && age < 18) 
    {
        Console.WriteLine("Niepełnoletni mężczyzna"); 
    }

    else
    {
        Console.WriteLine("DANE NIEPOPRAWNE"); 
    }
}