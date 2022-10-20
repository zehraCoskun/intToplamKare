internal class Program
{
    private static void Main(string[] args)
    {
    baslangic:
        Console.WriteLine("Aralarına virgül koyarak değerleri giriniz");

        string input = Console.ReadLine();
        string[] newinput = input.Split(",");
        int elemanSayisi = newinput.Count();
        if (elemanSayisi % 2 != 0)
        {
            Console.WriteLine("Lütfen çift sayıda değer giriniz");
            Console.WriteLine("------**-----");
            goto baslangic;
        }

        //diziyi int değerler taşıyan yeni bir diziye ekler ve aynı zamanda tğm değerlerin sayısal olduğunu kontrol eder
        int[] dizimiz = new int[elemanSayisi];
        
        int sayimiz;
        for (int i = 0; i < elemanSayisi; i++)
        {
            if(!Int32.TryParse(newinput[i], out sayimiz))
            {
                Console.WriteLine("Girilen bütün değerler sayısal olmalı");
                goto baslangic;
            }
            else{dizimiz[i] = sayimiz;}     
        }

        //değerlerin aynı olup olmasını kontrol ederek toplar ya da toplamın karesini alır
        for (int j = 0; j < elemanSayisi; j += 2)
        {
            if (dizimiz[j] == dizimiz[j + 1])
            {
                Console.WriteLine((dizimiz[j] + dizimiz[j + 1])*(dizimiz[j] + dizimiz[j + 1]));
            }
            else{Console.WriteLine(dizimiz[j] + dizimiz[j + 1]);}
        }
        Console.WriteLine("Yeni bir sorgulama yapabilirsiniz");
        Console.WriteLine("-----***-----");
        goto baslangic;


    }
}