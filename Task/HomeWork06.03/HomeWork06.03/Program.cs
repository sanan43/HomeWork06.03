//task4
//int num = 9347;
//int Maxdigit = 0;

//while (num > 0)
//{
//    int digit = num % 10;
//    if (digit > Maxdigit)
//    {
//        Maxdigit = digit;
//    }
//    num = num / 10;
//}

//Console.WriteLine("En boyuk reqem: " + Maxdigit);




//task3

int num = 4; 
int quvvet = 2; 

while (num % quvvet == 0)
{
    num /= quvvet;
}

if (num == 1)
{
    Console.WriteLine("2nin quvvetidir");
}
else
{
    Console.WriteLine("2nin quvveti deyil");
}






