// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Uniformes persona = new Uniformes();
persona.id=01;
persona.Nombre_Equipo="Depotes fc ";
persona.Color="Verde";
persona.NumeroCamiseta=10;
persona.TallaMedias=5;
persona.TallaGuayos=35;

public class Uniformes{
    public int id;
    public String? Nombre_Equipo;
    public String Color;
    public int NumeroCamiseta;
    public int TallaMedias;
    public int TallaGuayos;
}
public class Balones{
    public String Marca;
    public String Color;
    public decimal Precio;
}
public class Cono{
    public int ID_cono;
    public decimal Altura;
    public bool Funcionan;
}

public class Deportes{
    public int ID;
    public DateTime FechaTorneo;
    public String TipoBalon;
}
