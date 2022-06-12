while (true)
{


    char[] bigLetter = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'X', 'C', 'V', 'B', 'N', 'M' };
    char[] smallLetter = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
    Console.WriteLine("please entertxt");
    string textTxT = Console.ReadLine();

    string result = Islettercapital(textTxT, bigLetter, smallLetter);


    Console.WriteLine(result);


}


static string Islettercapital(string textTxT, char[] bigLetter, char[] smallLetter)
{
    for (int i = 0; i < smallLetter.Length; i++)
    {
        textTxT = textTxT.Replace(bigLetter[i], smallLetter[i]);



    }

    return textTxT;


}