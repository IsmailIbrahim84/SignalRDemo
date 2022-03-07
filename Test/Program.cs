// See https://aka.ms/new-console-template for more information

//int solution(int param1, int param2) {
//    return param1 + param2;
//}

//Console.WriteLine(solution(-1000, -1000));;

//int solution(int year)
//{
//    int result = 0;
//    if (year % 100 == 0)
//    {
//        result = year / 100;
//    }
//    else
//    {
//        result = year / 100 + 1;
//    }
//    return result;
//}
//Console.WriteLine(solution(2004));;


bool solution(string inputString)
{
    //The following more faster:
    char[] charArray = inputString.ToCharArray();
    Array.Reverse( charArray );

    return inputString == new string(charArray);

    //char[] temp = inputString.ToCharArray();
    //string reversed = "";
    //for (int i = temp.Length-1; i >= 0; i--)
    //{
    //    reversed += temp[i].ToString();
    //}
    
    
}

Console.WriteLine(solution("aabaa"));

