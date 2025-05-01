public class Jugador : Persona
{
    public int NumFed { get; set; }

    public Jugador(string nombre, string nif, string fechaNac, int numFed)
        : base(nombre, nif, fechaNac)
    {
        NumFed = numFed;
    }
}
