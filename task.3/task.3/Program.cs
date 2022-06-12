while (true)
{
    Console.WriteLine("please enter text");
    string targetName = Console.ReadLine();
    Console.WriteLine("please enter  char");
    char targetLetter = Convert.ToChar(Console.ReadLine());

    Console.WriteLine(Isletterhere(targetName, targetLetter));

}


static string Isletterhere(string targetName, char targetLetter)
{
    for (int i = 0; i < targetName.Length; i++)
    {
        if (targetName[i] == targetLetter)
        {
            return "he";
        }


    }


    return "yox";


}
