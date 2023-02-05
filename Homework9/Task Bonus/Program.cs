// Поиск можно ли создать предложение из 1 го во втором.
using static System.Console;
Clear();

Write("Введите первое предложение => ");
string enterText1=ReadLine()!;

Write("Введите второе предложение => ");
string enterText2=ReadLine()!;

WriteLine();
ComparisonOfOffers(enterText1, enterText2);
WriteLine();

void ComparisonOfOffers (string text1, string text2)
{
    text1=text1.Replace(" ","").ToLower();
    text2=text2.Replace(" ","").ToLower();
    int[] arrayResult = new int[text2.Length];

   for (int i2 = 0; i2 < text2.Length; i2++)
    {
        int sumCharText1=0;
        int sumCharText2=0;

        char charText2 = text2[i2];

        for (int i = 0; i < text2.Length; i++)
        {
            if (text2[i]==charText2) sumCharText2++;
        }

        for (int i = 0; i < text1.Length; i++)
        {
            if (text1[i]==charText2) sumCharText1++;
        }
        if(sumCharText2<=sumCharText1) arrayResult[i2]=1;
        else arrayResult[i2]=0;

    }

    // WriteLine($" [ {string.Join(" ", arrayResult)} ] "); // проверка массива
    int sumArrayResult =0;
    foreach (int item in arrayResult)
    {
        sumArrayResult=sumArrayResult+item;
    }

    if (sumArrayResult==arrayResult.Length) WriteLine("Да, можно из первого предложения получить второе");
    else WriteLine("Нет, нельзя из первого предложения получить второе");
}