// See https://aka.ms/new-console-template for more information


var kvadratas = new Staciakampis(4, 4);

Console.WriteLine(kvadratas.Plotas);
Console.WriteLine(kvadratas.PlotasMetodas());

Console.WriteLine(kvadratas.Length);
kvadratas.SumazintIlgi(2);
Console.WriteLine(kvadratas.Length);


struct Staciakampis
{
    private double Length;
    public double Width;
    public double Plotas;

    public Staciakampis(int length, int width)
    {
        Length = length;
        Width = width;
        Plotas = length * width;
    }

    public double PlotasMetodas()
    {
        
        return Length * Width;
    }

    public void SumazintIlgi(int nTimes)
    {
        Length = Length / nTimes;
    }
}




