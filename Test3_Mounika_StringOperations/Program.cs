// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string str = "A quick brown fox jumps over the lazy dog";

string str2=str.Substring(37,4);
Console.WriteLine("1get the word :" +str2);
string reverse = "";
for (int i = str2.Length - 1; i >= 0; i--)
{
    reverse = reverse + str2[i];

}
Console.WriteLine("Reverse of a dog is :"+reverse);
string substring1 = str.Substring(14, 3);
string substring2 = str.Substring(22, 19);
Console.WriteLine("2.substring is: " + substring1 + substring2);
Console.WriteLine("3.Index of Fox is:"+str.IndexOf("fox"));

int Count=0 ;
for(int i=0;i < str.Length; i++)
{
    if (str[i] == 'u')
    {
        Count++;
    }
}
Console.WriteLine("4.u letter count is:"+Count);
Console.WriteLine("5. Length of string is:"+str.Length);
string str_Replace= str.Replace('a','1').Replace('e','1') .Replace('i','1').Replace('o','1').Replace('u','1').Replace('A','1');
Console.WriteLine("6.Vowels replace with 1 is  :" +str_Replace);