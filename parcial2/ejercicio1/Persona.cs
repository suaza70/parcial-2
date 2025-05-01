public class Persona
{
    public string Nombre { get; set; }
    public string Nif { get; set; }
    public string FechaNac { get; set; }

    public Persona(string nombre, string nif, string fechaNac)
    {
        Nombre = nombre;
        Nif = nif;
        FechaNac = fechaNac;
    }
}
