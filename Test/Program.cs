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


//bool solution(string inputString)
//{
//    var watch1 = new System.Diagnostics.Stopwatch();
//    var watch2 = new System.Diagnostics.Stopwatch();
//    string reversed = "";        
//    watch1.Start();

//    //More faster in the huge amount of string:
//    char[] charArray = inputString.ToCharArray();
//    Array.Reverse( charArray );
//    reversed = new string(charArray);
//    //----------------------------
//    watch1.Stop();

//    //Slower
//    reversed = "";
//    watch2.Start();
    
//    char[] temp = inputString.ToCharArray();
    
//    for (int i = temp.Length - 1; i >= 0; i--)
//    {
//        reversed += temp[i].ToString();
//    }
//    watch2.Stop();
//    Console.WriteLine($"Execution Time-Watch1: {watch1.Elapsed} ElapsedTime, Execution Time-Watch2: {watch2.Elapsed} ElapsedTime");
//   // if (watch1.)
//    //return inputString == new string(charArray);
//    return inputString == reversed;

//}

//Console.WriteLine(solution("saippuakivikauppias"));



//////////////////////////////////////////////////////

//int[] inputArray = {-23, 4, -3, 8, -12};

//int Solution(int[] inputArray){
//    int result= Int32.MinValue;
//    for (int i = 0; i < inputArray.Length-1; i++)
//    {
        
//        if (inputArray[i] * inputArray[i + 1] > result)
//            result = inputArray[i] * inputArray[i + 1];
        
        
//    }
    
//    return result;
//}
//Console.WriteLine(Solution(inputArray));
/////////////////////////////////////////////////////////
//int Solution(int n)
//{

//    if (n <0)
//    {
//        return 0;
//    }
//    else
//    {
//        return (n * n) + ((n - 1) * (n - 1));
//    }

    
//}
//Console.WriteLine(Solution(3));

///////////////////////////////////////////////////////////
//int[] inputArray = {6, 2, 3, 8};
//int Solution(int[] statues)
//{
    
//    int max = statues.Max();
//    int count = 0;
//    Array.Sort(statues);
//    for (int i = 0; i < statues.Length-1; i++)
//    {
//        count += statues[i + 1] - statues[i] - 1;

//    }

//    return count;
//}
//Console.WriteLine(Solution(inputArray));

//////
int[] inputArray = { 1, 3, 2,1};
Array.Sort(inputArray);
bool Solution(int[] sequence)
{
    int count = 0;
    for (int i = 0; i < sequence.Length-1; i++)
    {
        if (sequence[i + 1] > sequence[i])
        {
            count++;
        }


    }

    return count > 1;
}

Console.WriteLine(Solution(inputArray));