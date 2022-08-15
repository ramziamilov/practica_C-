int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void SetN(int num)
{
 int i=1;   
    while(i<=num)

    {
        
        System.Console.Write(i*i*i+" ");
        i++;
        
    }


}


SetN(Prompt("Введите число : "));