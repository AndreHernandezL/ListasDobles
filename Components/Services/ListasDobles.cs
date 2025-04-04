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
        public string AgregarAlinicio(Persona dato)
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
        public string AgregarAlFinal(Persona dato)
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

        public string AgregarAntesDatox(Persona Nuevodato, int id)
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
                    Persona informacion = NodActual.informacion;
                    if (informacion.getId() == id)
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
                            return $"Nodo ingresado antes del ID {id} en la lista";
                        }
                    }
                    NodActual = NodActual.NodoSig;
                }
                return "No se econtro el elemnto en la lista";
            }
        }
        public string AgregarDespuesDatox(Persona Nuevodato, int id)
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
                    Persona informacion = NodActual.informacion;

                    if (informacion.getId() == id)
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
                        return $"Nodo ingresado despues del ID {id} en la lista";
                    }
                    NodActual = NodActual.NodoSig;
                }
                return "No se econtro el elemnto en la lista";
            }
        }

        public string AgregarEnDatoX(Persona Nuevodato, int id)
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
                    Persona informacion = NodActual.informacion;
                    if (informacion.getId() == id)
                    {
                        if (NodActual == PrimerNodo)
                        {
                            AgregarAlinicio(Nuevodato);

                        }else if (NodActual == UltimoNodo)
                        {
                            AgregarAlFinal(Nuevodato);
                        }
                        else
                        {
                            NuevoNodo = new Nodo(Nuevodato);
                            NuevoNodo.NodoAnt = NodActual.NodoAnt;
                            NuevoNodo.NodoSig = NodActual;
                            NodActual.NodoAnt.NodoSig = NuevoNodo;
                            NodActual.NodoAnt = NuevoNodo;
                            TotalNodos++;
                            return $"Nodo ingresado en el lugar del ID {id} en la lista";
                        }
                    }
                    NodActual = NodActual.NodoSig;
                }
                return "No se econtro el elemnto en la lista";
            }
        }

        public string AregarAntesPosX(Persona Nuevodato, int poscion)
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

        public string AregarDespuesPosX(Persona Nuevodato, int poscion)
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
                        if (contador == TotalNodos)
                        {
                            AgregarAlFinal(Nuevodato);
                        }
                        else
                        {
                            NuevoNodo = new Nodo(Nuevodato);

                            NuevoNodo.NodoAnt = NodActual;
                            NuevoNodo.NodoSig = NodActual.NodoSig;
                            NodActual.NodoSig.NodoAnt = NuevoNodo;
                            NodActual.NodoSig = NuevoNodo;

                            TotalNodos++;

                        }
                        break;
                    }

                    contador++;
                    NodActual = NodActual.NodoSig;
                }
                return $"Nodo ingresado despues de la {poscion} en la lista";
            }
        }

        public string AregarEnPosX(Persona Nuevodato, int poscion)
        {

            if (poscion > TotalNodos || poscion < 1)
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
                        if (contador == TotalNodos)
                        {
                            AgregarAlFinal(Nuevodato);
                        }
                        else if (contador == 1)
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

                        }
                        break;
                    }

                    contador++;
                    NodActual = NodActual.NodoSig;
                }
                return $"Nodo ingresado en la {poscion} en la lista";
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

        public string EliminarDatoX(int id)
        {
            if (EstaVacia())
            {
                return "La lista esta vacia";
            }
            else
            {
                Nodo NodoAcutal = PrimerNodo;
                while (NodoAcutal != null)
                {
                    Persona informacion = NodoAcutal.informacion;
                    if (informacion.getId() == id)
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
                        return "Dato eliminado";
                    }
                    NodoAcutal = NodoAcutal.NodoSig;
                }
            }
            return "Dato no encontrado";
        }

        public string EliminarPosicionX(int posicion)
        {
            int contador = 1;
            if (EstaVacia())
            {
                return "La lista esta vacia";
            }
            else if (posicion > TotalNodos && posicion < 1)
            {
                return "Poscision ingresada no valida";
            }
            else {

                Nodo NodoAcutal = PrimerNodo;
                while (NodoAcutal != null)
                {
                    if (contador == posicion)
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
                        return "Posicion eliminada";
                    }
                    NodoAcutal = NodoAcutal.NodoSig;
                    contador++;
                }
            }
            return "Posicion no encontrada";
        }

        public string EliminarDespuesDatX(int id)
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
                    Persona informacion = NodActual.informacion;
                    if (informacion.getId() == id)
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
                        return $"Nodo eliminado despues del ID: {id} en la lista";
                    }
                    NodActual = NodActual.NodoSig;
                }
                return "No se econtro el elemento en la lista";
            }
        }

        public string EliminarAntesDatX(int id)
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
                    Persona informacion = NodActual.informacion;
                    if (informacion.getId() == id)
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
                        return $"Nodo eliminado antes del ID: {id} en la lista";
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
                        Persona Actual = NodoActual.informacion;
                        Persona Siguiente = NodoSiguiente.informacion;

                        if (Actual.getId() > Siguiente.getId())
                        {
                            Persona Auxiliar = NodoSiguiente.informacion;
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

        public string BusquedaElemento(int Dato)
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
                    if (NodoActual.informacion.getId() == Dato)
                    {
                        return $"Dato: ({NodoActual.informacion.getId()}) → {NodoActual.informacion.getNombre()} encontrado";
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
                return "";
            }
            else
            {
                Persona informacion = NodoActual.informacion;
                return $"({contador++}) → [{informacion.getId()}]: {informacion.getNombre()} | {RecorrerLista(NodoActual.NodoSig, contador)}";
            }
        }
    }
}
