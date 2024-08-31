//#region A,B ededleri arasindaki 3 e tam bolunenler


////for (int i = 1; i < 100; i++)
////{
////    if (i % 3 == 0)
////    {
////        Console.WriteLine(i); ;
////    }
////}
//#endregion
#region Ededin 2nin quvveti olub, olmamasi
int num = 37;
bool result = false;
for (int i = 2; i < num; i++)
{
    if (num % i == 0)
    {
        result = true;
        break;
    }

}   
if (result)
{
    Console.WriteLine("2 nin quvvetidir");
}
else
{
    Console.WriteLine("Quvveti deyil");
}
#endregion


