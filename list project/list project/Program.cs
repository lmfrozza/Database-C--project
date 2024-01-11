Console.WriteLine("Welcome to this DataBase!");
Console.WriteLine("https://github.com/lmfrozza to acess README file");

TestArrayInt();
void TestArrayInt()
{
    int[] age = new int[5];
    age[0] = 30;
    age[1] = 71;
    age[2] = 69;
    age[3] = 34;
    age[4] = 21;

    //Console.WriteLine($"Array Lengh: {age.Length}");

    int upage = 0;
    
    for (int i = 0; i < age.Length; i++)
    {
        Console.WriteLine($"Age Slot {i+1}: {age[i]}" );
        
        upage = upage + age[i];
       
    }
    Console.WriteLine($"The Average Age is: {upage/age.Length}");
};