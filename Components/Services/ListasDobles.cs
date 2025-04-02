namespace ListasDoblementeEnlazadas.Components.Services
{
    public class ListasDobles
    {
        public Nodo PrimerNodo;
        public Nodo UltimoNodo;
        Nodo NuevoNodo;
        int TotalNodos;
        public ListasDobles()
        {
            PrimerNodo = null;
            UltimoNodo = null;
            TotalNodos = 0;
        }
        public bool EstaVacia()
        {
            return PrimerNodo == null ? true : false;
        }
        public string AgregarAlinicio(object dato)
        {
            NuevoNodo = new Nodo(dato);
            if (EstaVacia())
            {
                PrimerNodo = UltimoNodo = NuevoNodo;
            }
            else
            {
                NuevoNodo.NodoSig = PrimerNodo;
                PrimerNodo.NodoAnt = NuevoNodo;
                PrimerNodo = NuevoNodo;
            }
            TotalNodos++;
            return "Nodo ingresado al inicio de la lista";
        }
        public string AgregarAlFinal(object dato)
        {
            NuevoNodo = new Nodo(dato);
            if (EstaVacia())
            {
                PrimerNodo = UltimoNodo = NuevoNodo;
            }
            else
            {
                UltimoNodo.NodoSig = NuevoNodo;
                NuevoNodo.NodoAnt = UltimoNodo;
                UltimoNodo = NuevoNodo;
            }
            TotalNodos++;
            return "Nodo ingresado al final de la lista";
        }

        public string AgregarAntesDatox(object Nuevodato, object DatoObjetivo)
        {
            if (EstaVacia())
            {
                return "No hay elementos en la lista";
            }
            else
            {
                Nodo NodActual = PrimerNodo;
                while (NodActual != null)
                {
                    if (NodActual.informacion.Equals(DatoObjetivo))
                    {
                        if (NodActual == PrimerNodo)
                        {
                            AgregarAlinicio(Nuevodato);
                        }
                        else
                        {
                            NuevoNodo = new Nodo(Nuevodato);
                            NuevoNodo.NodoAnt = NodActual.NodoAnt;
                            NuevoNodo.NodoSig = NodActual;
                            NodActual.NodoAnt.NodoSig = NuevoNodo;
                            NodActual.NodoAnt = NuevoNodo;
                            TotalNodos++;
                            return $"Nodo ingresado antes de {DatoObjetivo} en la lista";
                        }
                    }
                    NodActual = NodActual.NodoSig;
                }
                return "No se econtro el elemnto en la lista";
            }
        }
        public string AgregarDespuesDatox(object Nuevodato, object DatoObjetivo)
        {
            if (EstaVacia())
            {
                return "No hay elementos en la lista";
            }
            else
            {
                Nodo NodActual = PrimerNodo;
                while (NodActual != null)
                {
                    if (NodActual.informacion.Equals(DatoObjetivo))
                    {
                        if (NodActual == UltimoNodo)
                        {
                            AgregarAlFinal(Nuevodato);
                        }
                        else
                        {
                            NuevoNodo = new Nodo(Nuevodato);
                            NuevoNodo.NodoSig = NodActual.NodoSig;
                            NuevoNodo.NodoAnt = NodActual;
                            NodActual.NodoSig.NodoAnt = NuevoNodo;
                            NodActual.NodoSig = NuevoNodo;
                            TotalNodos++;
                        }
                        return $"Nodo ingresado despues de {DatoObjetivo} en la lista";
                    }
                    NodActual = NodActual.NodoSig;
                }
                return "No se econtro el elemnto en la lista";
            }
        }

        public string AregarAntesPosX(object Nuevodato, int poscion)
        {
            if (poscion > TotalNodos)
            {
                return "Poscision ingresada no valida";
            }
            else
            {
                int contador = 1;
                Nodo NodActual = PrimerNodo;
                while (NodActual != null)
                {
                    if (contador == poscion)
                    {
                        if (contador == 1)
                        {
                            AgregarAlinicio(Nuevodato);
                        }
                        else
                        {
                            NuevoNodo = new Nodo(Nuevodato);
                            NuevoNodo.NodoSig = NodActual;
                            NuevoNodo.NodoAnt = NodActual.NodoAnt;
                            NodActual.NodoAnt.NodoSig = NuevoNodo;
                            NodActual.NodoAnt = NuevoNodo;
                            TotalNodos++;
                        }
                        break;
                    }
                    contador++;
                    NodActual = NodActual.NodoSig;
                }
                return $"Nodo ingresado antes de la {poscion} en la lista";
            }
        }

        public string EliminarAlinicio()
        {
            if (EstaVacia())
            {
                return "No hay elementos en la lista";
            }
            else if (PrimerNodo == UltimoNodo)
            {
                PrimerNodo = UltimoNodo = null;
            }
            else
            {
                Nodo NodoAuxiliar;
                NodoAuxiliar = PrimerNodo;
                PrimerNodo = PrimerNodo.NodoSig;
                PrimerNodo.NodoAnt = null;
                NodoAuxiliar = null;
            }
            TotalNodos--;
            return "Nodo eliminado al inicio de la lista";
        }

        public string EliminarAlFinal()
        {
            if (EstaVacia())
            {
                return "No hay elementos en la lista";
            }
            else if (PrimerNodo == UltimoNodo)
            {
                PrimerNodo = UltimoNodo = null;
            }
            else
            {
                Nodo NodoAuxiliar;
                NodoAuxiliar = UltimoNodo;
                UltimoNodo = UltimoNodo.NodoAnt;
                UltimoNodo.NodoSig = null;
                NodoAuxiliar = null;
            }
            TotalNodos--;
            return "Nodo eliminado al final de la lista";
        }

        public string EliminarInformacionX(object dato)
        {
            if (EstaVacia())
            {
                return "LA LISTA ESTA VACIA";
            }
            else
            {
                Nodo NodoAcutal = PrimerNodo;
                while (NodoAcutal != null)
                {
                    if (NodoAcutal.informacion.Equals(dato))
                    {
                        if (NodoAcutal == PrimerNodo)
                        {
                            EliminarAlinicio();
                        }
                        else if (NodoAcutal == UltimoNodo)
                        {
                            EliminarAlFinal();
                        }
                        else
                        {
                            Nodo eliminado = NodoAcutal;
                            NodoAcutal.NodoSig.NodoAnt = NodoAcutal.NodoAnt;
                            NodoAcutal.NodoAnt.NodoSig = NodoAcutal.NodoSig;
                            eliminado = null;
                            TotalNodos--;
                        }
                        return "DATO FUE ELIMINADO CON EXITO";
                    }
                    NodoAcutal = NodoAcutal.NodoSig;
                }
            }
            return "LO SIENTO DATO NO FUE ENCONTRADO";
        }

        public string EliminarDespuesDatX(object DatoObjetivo)
        {
            if (EstaVacia())
            {
                return "No hay elementos en la lista";
            }
            else
            {
                Nodo NodActual = PrimerNodo;
                while (NodActual != null)
                {
                    if (NodActual.informacion.Equals(DatoObjetivo))
                    {
                        if (NodActual == UltimoNodo)
                        {
                            return "No se puede eliminar despues del ultimo elemento";
                        }
                        else if (NodActual.NodoSig == UltimoNodo)
                        {
                            EliminarAlFinal();
                        }
                        else
                        {
                            Nodo NodoAuxiliar = NodActual.NodoSig;
                            NodActual.NodoSig = NodoAuxiliar.NodoSig;
                            NodoAuxiliar.NodoSig.NodoAnt = NodActual;
                            NodoAuxiliar = null;
                            TotalNodos--;
                        }
                        return $"Nodo eliminado despues del elemento: {DatoObjetivo} en la lista";
                    }
                    NodActual = NodActual.NodoSig;
                }
                return "No se econtro el elemento en la lista";
            }
        }

        public string EliminarAntesDatX(object DatoObjetivo)
        {
            if (EstaVacia())
            {
                return "No hay elementos en la lista";
            }
            else
            {
                Nodo NodActual = PrimerNodo;
                while (NodActual != null)
                {
                    if (NodActual.informacion.Equals(DatoObjetivo))
                    {
                        if (NodActual == PrimerNodo)
                        {
                            return "No se puede elimiar antes de la primer elemento";
                        }
                        else if (NodActual.NodoAnt == PrimerNodo)
                        {
                            EliminarAlinicio();
                        }
                        else
                        {
                            Nodo NodoAuxiliar = NodActual.NodoAnt;
                            NodActual.NodoAnt = NodoAuxiliar.NodoAnt;
                            NodoAuxiliar.NodoAnt.NodoSig = NodActual;
                            NodoAuxiliar = null;
                            TotalNodos--;
                        }
                        return $"Nodo eliminado antes del elemento: {DatoObjetivo} en la lista";
                    }
                    NodActual = NodActual.NodoSig;
                }
                return "No se econtro el elemnto en la lista";
            }
        }

        public string EliminarAntesdePosicionX(int posicion)
        {
            if (posicion > TotalNodos)
            {
                return "Posicion ingresada no valida";
            }
            else
            {
                int contador = 1;
                Nodo NodActual = PrimerNodo;
                while (NodActual != null)
                {
                    if (contador == posicion)
                    {
                        if (contador == 1)
                        {
                            return "No se puede eliminar antes de la primera posición";
                        }
                        else if (contador == 2)
                        {
                            EliminarAlinicio();
                        }
                        else
                        {
                            Nodo NodoRef = NodActual.NodoAnt;
                            NodActual.NodoAnt = NodoRef.NodoAnt;
                            NodoRef.NodoAnt.NodoSig = NodActual;
                            NodoRef = null;
                            TotalNodos--;
                            break;
                        }
                    }
                    contador++;
                    NodActual = NodActual.NodoSig;
                }
                return $"Nodo Eliminado antes de la posición: {posicion} en la lista";
            }
        }

        public string EliminarDespuesdePosicionX(int posicion)
        {
            if (posicion > TotalNodos)
            {
                return "Posicion ingresada no valida";
            }
            else
            {
                int contador = 1;
                Nodo NodActual = PrimerNodo;
                while (NodActual != null)
                {
                    if (contador == posicion)
                    {
                        if (contador == TotalNodos)
                        {
                            return "No se puede eliminar despues de la ultima posición";
                        }
                        else if (contador == TotalNodos - 1)
                        {
                            EliminarAlFinal();
                        }
                        else
                        {
                            Nodo NodoRef = NodActual.NodoSig;
                            NodActual.NodoSig = NodoRef.NodoSig;
                            NodoRef.NodoSig.NodoAnt = NodActual;
                            NodoRef = null;
                            TotalNodos--;
                            break;
                        }
                    }
                    contador++;
                    NodActual = NodActual.NodoSig;
                }
                return $"Nodo eliminado despues de la posición: {posicion} en la lista";
            }
        }

        public string OrdenarLista()
        {
            if (EstaVacia())
            {
                return "Lista Vacía, no hay elementos para ordenar";
            }
            else if (PrimerNodo == UltimoNodo)
            {
                return "La lista solo tiene un elemento.";
            }
            else
            {
                Nodo NodoActual = PrimerNodo;
                Nodo NodoSiguiente = PrimerNodo.NodoSig;
                while (NodoActual.NodoSig != null)
                {
                    while (NodoSiguiente != null)
                    {
                        if (Convert.ToInt32(NodoActual.informacion) >
                        Convert.ToInt32(NodoSiguiente.informacion))
                        {
                            object Auxiliar = NodoSiguiente.informacion;
                            NodoSiguiente.informacion = NodoActual.informacion;
                            NodoActual.informacion = Auxiliar;
                        }
                        NodoSiguiente = NodoSiguiente.NodoSig;
                    }
                    NodoActual = NodoActual.NodoSig;
                    NodoSiguiente = NodoActual.NodoSig;
                }
                return "Lista Ordenada";
            }
        }

        public string BusquedaElemento(object Dato)
        {
            if (EstaVacia())
            {
                return "Lista Vacía, no hay elementos para buscar";
            }
            else if (PrimerNodo == UltimoNodo)
            {
                return "La lista solo tiene un elemento.";
            }
            else
            {
                Nodo NodoActual = PrimerNodo;
                while (NodoActual != null)
                {
                    if (NodoActual.informacion.Equals(Dato))
                    {
                        return $"Dato: [{Dato}] encontrado";
                    }
                    NodoActual = NodoActual.NodoSig;
                }
                return "No se contraron coincidencias";
            }
        }

        public string RecorrerLista(Nodo NodoActual, int contador)
        {
            if (NodoActual == null)
            {
                return " null";
            }
            else
            {
                return $"[({contador++}).-{NodoActual.ToString()}]\n ↑↓\n{RecorrerLista(NodoActual.NodoSig, contador)}";
            }
        }
}
