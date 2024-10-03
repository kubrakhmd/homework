using System.ComponentModel.Design;
Console.Write("reqem yaz");
int num = Convert.ToInt32(Console.ReadLine());
//if (num >= 0)
//{
//    while (num > 1)
//    {
//        if (num % 2 == 0)
//        {
//            num /= 2;
//        }
//    }
//}
//Console.WriteLine("2-in quvvetidir"); 


#region 2 reqemli ededin reqemlerinin muqayisesi
//int temp = num % 10;
//int num1 = num / 10;
//if(num>=10 && num <= 99)
//{
//    if (temp > num1)
//    {
//        Console.WriteLine(temp);
//    }
//}
//else
//{
//    Console.WriteLine(c);
//} 
#endregion


if (num == 1)
{
    Console.WriteLine("sadedir");
}
else
{ 
    for (int i = 2; i < num; i++)
    {
        if (num % i != 0)

        {
           
        }



       
        }
        Console.WriteLine("sadedir");
    
    }
    
