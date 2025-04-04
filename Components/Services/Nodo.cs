namespace ListasDoblementeEnlazadas.Components.Services
{
    public class Nodo
    {
        public Persona informacion;
        public Nodo NodoSig;
        public Nodo NodoAnt;
        public Nodo()
        {
            NodoSig = null;
            NodoAnt = null;
            informacion = null;
        }
        public Nodo(Persona Informacion)
        {
            informacion = Informacion;
            NodoAnt = null;
            NodoSig = null;
        }
        public Nodo(Persona Informacio, Nodo Ante, Nodo Sig)
        {
            informacion = Informacio;
            NodoAnt = Ante;
            NodoSig = Sig;
        }
    }
}
