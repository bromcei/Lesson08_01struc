// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Gyvunas gyvunas1 = new Gyvunas("Liutas Karalius", "Liutas");
Gyvunas gyvunas2 = new Gyvunas("Simba", "Liutas");
Gyvunas gyvunas3 = new Gyvunas("simba JR", "Liutas");
Gyvunas gyvunas4 = new Gyvunas("Mike", "Meska");
Gyvunas gyvunas5 = new Gyvunas("Knisliukas", "Parsiukas");

ZologijosSodas Zoo = new ZologijosSodas("Tvartelis");
Zoo.PridetiGyvuna(gyvunas1);
Zoo.PridetiGyvuna(gyvunas2);
Zoo.PridetiGyvuna(gyvunas3);
Zoo.PridetiGyvuna(gyvunas4);
Zoo.PridetiGyvuna(gyvunas5);

Console.WriteLine($"Zologijos sodas: {Zoo.Pavadinimas}");
Console.WriteLine($"Zologijos sode esanciu zveriu skaicius: {Zoo.GyvunuSkaicius()}");
Console.WriteLine($"Zologijos sode esanciu Liutu Skaicius: {Zoo.GyvunuSkaiciusPagalRusi("Liutas")}");


struct Gyvunas
{
    public string Vardas;
    public string Rusis;

    public Gyvunas(string vardas, string rusis)
    {
        Vardas = vardas;
        Rusis = rusis;
    }
}

struct ZologijosSodas
{
    public string Pavadinimas;
    List<Gyvunas> GyvunuSarasas = new List<Gyvunas>();

    public ZologijosSodas(string pavadinimas)
    {
        Pavadinimas = pavadinimas; 
    }

    public void PridetiGyvuna(Gyvunas gyvunas)
    {
        GyvunuSarasas.Add(gyvunas);
    }

    public int GyvunuSkaicius()
    {
        return GyvunuSarasas.Count;
    }

    public int GyvunuSkaiciusPagalRusi(string rusis)
    {
        int counter = 0;
        foreach (Gyvunas gyvunas in GyvunuSarasas)
        {
            if (gyvunas.Rusis == rusis)
            {
                counter += 1;
            }
        }

        return counter;
    }
}
