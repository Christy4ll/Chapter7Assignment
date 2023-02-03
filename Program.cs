 using System;

namespace christian_chapter_7
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
     
                // chapter7
                //     No1
    // int[] myArrays14 = new int[20];
    
    // for(int i = 0; i < myArrays14.GetLength(0); i++)
    // {
    //    myArrays14[i] = 5 * i;

    //     Console.WriteLine(myArrays14[i]);
    // }
            //      No2
    // Console.WriteLine("Please enter a length");
    // int length = int.Parse(Console.ReadLine());
    // int[] myArrays15 = new int[length];
    // for(int i = 0; i < myArrays15.GetLength(0); i++)
    // {
    //     Console.WriteLine("Enter a number");
    //     int number = int.Parse(Console.ReadLine());
    //     myArrays15[i] = number;  
    // }
    //  Console.WriteLine("Please enter a length");
    // int length1 = int.Parse(Console.ReadLine());
    // int[] myArrays16 = new int[length];
    // for(int j = 0; j < myArrays16.GetLength(0); j++)
    // {
    //     Console.WriteLine("Enter a number");
    //     int number = int.Parse(Console.ReadLine());
    //     myArrays16[j] = number;
    // }


    // if(myArrays15.GetLength(0) == myArrays16.GetLength(0))
    // {
    //    for(int x =0; x < myArrays15.GetLength(0); x++)
    //    {
    //         if(myArrays15[x] != myArrays16[x])
    //         {
    //              Console.WriteLine("They are not equal");
    //              break;
    //         }
    //         else
    //         {
    //             if(x==myArrays15.Length-1){
    //                 Console.WriteLine("They are equal");
    //                 break;
    //             }
    //         }
    //    }

    // }
    // else
    // {
    //     Console.WriteLine("They are not equal");
    // }
    //               no3
    // char[] myArray1 = new char[4]{'a', 'b', 'c', 'd'};
    // char[] myArray2 = new char[4]{'a', 'b', 'c', 'd'};
    // bool numEqual = true;
    // if(myArray1.GetLength(0) > myArray2.GetLength(0))
    // {
    //     Console.WriteLine("myArray2 is first");
    // }
    // else if(myArray1.GetLength(0) < myArray2.GetLength(0))
    // {
    //     Console.WriteLine("myArray1 is lexicographically first ");
    // }
    // else
    // {
    //     for(int i = 0; i < myArray1.GetLength(0); i++)
    //     {
    //         if(myArray1[i] < myArray2[i])
    //         {
    //             Console.WriteLine("myArray1 is lexicographically first");
    //             numEqual = false;
    //             break;
    //         }
    //         if(myArray1[i] > myArray2[i])
    //         {
    //             Console.WriteLine("myArray2 is lexicographically first");
    //             numEqual = false;
    //             break; 
    //         }
    //     }
    //     if(numEqual)
    //     {
    //         Console.WriteLine("arrays are equal");
    //     }
    // }

        //               no10
        // int count = 0; int counter = 1; int numberfound = 0;
        // Console.WriteLine("Please enter your length");
        // int length = int.Parse(Console.ReadLine());
        // int[] myArrays5 = new int[length];

        // for(int i = 0; i < myArrays5.GetLength(0); i++)
        // {
        //     Console.WriteLine("Please enter your number");
        //     myArrays5[i] = int.Parse(Console.ReadLine());
        // }

        // for (int i = 0; i < length - 1; i++)
        // {
        //     if (myArrays5[i] == myArrays5[i + 1])
        //     {
        //         counter ++;
        //     }
        //     else
        //     {
        //         counter = 1;
        //     }
        //     if (counter > count)
        //     {
        //         count = counter;
        //         numberfound = myArrays5[i];
        //     }
        // }

        // Console.WriteLine("{0} waas found {1} times.", numberfound, count );

                    // no4
       
        // Console.WriteLine("Please input a length");
        // int length = int.Parse(Console.ReadLine());
        // int count = 1, intCount = 1, number = 0;
        // int[] myArray17 = new int[length];

        // for(int i = 0; i < myArray17.GetLength(0); i++)
        // {
        //     Console.WriteLine("Enter your number");
        //     myArray17[i] = int.Parse(Console.ReadLine());
        // }
        // for(int j = 0; j < myArray17.Length - 1; j++)
        // {
        //     if(myArray17[i] == myArray17[i + 1])
        //     {
        //         intCount++;
        //     }
        //     else
        //     {
        //         intCount = 1;
        //     }
        //     if(intCount > count)
        //     {
        //         count = intCount;
        //         number = myArray17[i];
        //     }
        // }
        // for(int i = 0; i < count; i++)
        // {
        //     Console.WriteLine("{0} ," , number);
        // }

        // No 5
            
            Console.WriteLine("enter the length");
            int length = int.Parse(Console.ReadLine());
            int[] myArrays1 = new int[length];
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;
            for(int i = 0; i < myArrays1.Length; i++)
            {
                Console.WriteLine($"Input element {i}");
                myArrays1[i] = int.Parse(Console.ReadLine());  
            }
            for(int j = 0; j < myArrays1.Length-1; j++)
            {
                if(myArrays1[j] + 1 == myArrays1[j+1])
                {
                    sames++;
                }
                if(sames > bestSames)
                {
                    bestSames = sames;
                    lastElement = j + 1;
                    bestStart = lastElement - bestSames + 1;

                }
                    else
                {
                    sames = 1;
                }
            } 
            
            for(int j = bestStart; j < bestSames + bestStart; j++)
            {
                Console.WriteLine($"{j}," , myArrays1[j]);
            }

            
            // number 15
            // char[] alphabet = {'a','b','c','d','e','f','g','i','j','k','l','m','n','p','q','r','s','t','u','v','w','x','y','z'};
            // Console.WriteLine("Enter a word");
            // string word = Console.ReadLine().ToLower();
            //   for(int i = 0; i < alphabet.Length; i++)
            // {
            //    for (int x = 0; x < word.Length; x++)
            //    {
            //         if (alphabet[i] == word[x])
            //         {
            //             Console.WriteLine($"{alphabet[i]}, {x}");    
            //         }
            //    }
                
            // }
                   
            //         No 16
            // Console.WriteLine("Enter length");
            // int length = int.Parse(Console.ReadLine());
            // int [] myArrays = new int[length];
            // bool numberIsFound = true;
            // for(int i = 0; i <length; i++)
            // {
            //     Console.WriteLine("Enter element:",i);
            //     myArrays[i] = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("Enter searched number");
            // int num1 = int.Parse(Console.ReadLine());
            
            // for(int j = 0; j < length; j++)
            // {
            //     if(myArrays[j] == num1)
            //     {
            //         numberIsFound = true;
            //         break;
            //     }
            //     else
            //     {
            //         numberIsFound= false;
            //     }
            // }
            // if (numberIsFound == true)
            // {
            //     Console.WriteLine("Number is found");
            // }
            // else
            // {
            //     Console.WriteLine("Number is not found");
            // }
            //

                //  Number 11
            // Console.WriteLine("Enter the length");
            // int length = int.Parse(Console.ReadLine());
            // int[] myArrays1 = new int[length];
            // int sum = 0;
            // int start = 0;
            // int end = 0;
            // bool sumFound = false;
            // Console.WriteLine("Enter number s");
            // int s = int.Parse(Console.ReadLine());
            // for(int i = 0; i < myArrays1.Length; i++)
            // {
            //     Console.WriteLine("Enter {0} element:",i);
            //     myArrays1[i] = int.Parse(Console.ReadLine()); 
                
            // }
            // for(int j = 0; j < myArrays1.Length-1; j++)
            // {
            //     sum = myArrays1[j];
            //     for(int x = 1; x < myArrays1.Length - j ; x++)
            //     {
            //         sum = sum + myArrays1[j + x];
            //         if(sum == s)
            //         {
            //             start = j;
            //             end = x;
            //             Console.Write("{");
            //             for (int i = 0; i <= end; i++)
            //             {
            //                 Console.Write(myArrays1[start + i] +",");
            //             }
            //             Console.Write("}");
                        // break;

                            // No 9
            // Console.WriteLine("Enter the length");
            // int length = int.Parse(Console.ReadLine());
            // int[] myArrays5 = new int[length];
            // int sum = 0;
            // int tempSum = 0;
            // for(int i = 0; i < length; i++)
            // {
            //    Console.WriteLine($"Enter {i} element");
            //    myArrays5[i] = int.Parse(Console.ReadLine());
               
            // }
            // for(int j = 0; j < length - 2; j++)
            //    {
            //         tempSum = myArrays5[j];
            //         for(int x = 1; x < 3 ; x++)
            //         {
            //             tempSum += myArrays5[j + x];
            //             if(tempSum > sum)
            //             {
            //                 sum = tempSum;
            //             }

            //         }
            //    }  
            // Console.WriteLine(sum);

                //   number13
            // int row = 0;
            // int colunm = 0;
            // int sum = 0;
            // Console.WriteLine("Enter N");
            // int n = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter M");
            // int m = int.Parse(Console.ReadLine());
            // int[,] arrays = new int[n,m];
            // for(int i = 0; i < n; i++)
            // for(int j = 0; j < m; j++)
            // {
            //   Console.WriteLine("arrays[{0},{1}] =", i,j);
            //   arrays[i,j] = int.Parse(Console.ReadLine());  
            // }
            //  for(int x = 0; x < arrays.GetLength(0)-2; x++)
            //  {
            //     for(int t = 0; t < arrays.GetLength(1)-2; t++)
            //     {
            //         int bestSum = arrays[x,t] + arrays[x,t+1] + arrays[x,t+2] + arrays[x+1,t] + arrays[x+1,t+1] + arrays[x+1,t+2] + arrays[x+2,t] + arrays[x+2,t+1] + arrays[x+2,t+2];
            //         if(bestSum > sum)
            //         {
            //             sum = bestSum;
            //             row = x;
            //             colunm =t;
            //         }

            //     }
            //  }
            // Console.WriteLine(arrays[row,colunm] + " ");
            // Console.WriteLine("{0} {1} {2}", arrays[row,colunm] + arrays[row,colunm+1] + arrays[row,colunm+2]);
            // Console.WriteLine("{0} {1} {2}", arrays[row +1,colunm] + arrays[row +1,colunm+1] + arrays[row+1,colunm+2]);
            // Console.WriteLine("{0} {1} {2}", arrays[row+2,colunm] + arrays[row+2,colunm+1] + arrays[row+2,colunm+2]);
            // Console.WriteLine("The maximal sum is : {0}", sum);

            
                    
                
            
            
            
        }
    }
}
