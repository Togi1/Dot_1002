int sayi1 = Convert.ToInt32(Console.ReadLine());
int sayi2 = Convert.ToInt32(Console.ReadLine());
string islem = Console.ReadLine();
int sonuc;
if (islem == "add")
{
    sonuc = sayi1 + sayi2;
    return;
}
if ( islem == "subtract")
{
    sonuc = sayi1 - sayi2;
    return;
}
Console.WriteLine(sonuc);