namespace ListasDoblementeEnlazadas.Components.Services
{
    public class Persona
    {
        int Id { get; set; }
        public string Nombre { get; set; }

        public Persona(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public int getId()
        {
            return this.Id;
        }

        public string getNombre() 
        { 
            return this.Nombre; 
        }
    }
}
