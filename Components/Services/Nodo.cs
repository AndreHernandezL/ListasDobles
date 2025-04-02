namespace ListasDoblementeEnlazadas.Components.Services
{
    public class Nodo
    {
        public object informacion;
        public Nodo NodoSig;
        public Nodo NodoAnt;
        public Nodo()
        {
            NodoSig = null;
            NodoAnt = null;
            informacion = null;
        }
        public Nodo(object Informacion)
        {
            informacion = Informacion;
            NodoAnt = null;
            NodoSig = null;
        }
        public Nodo(object Informacio, Nodo Ante, Nodo Sig)
        {
            informacion = Informacio;
            NodoAnt = Ante;
            NodoSig = Sig;
        }
        public object getInformacion()
        {
            return informacion;
        }
    }
}
