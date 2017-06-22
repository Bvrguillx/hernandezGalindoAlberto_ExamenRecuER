using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenExtraordinarioER_AlbertoHernandez.Models
{
    public class ClinicaVeterinaria
    {
        protected List<Animal> ListaAnimales { get; set; }

        public ClinicaVeterinaria()
        {
            ListaAnimales = new List<Animal>();
            menuPrincipal();
            // paraProbar();
        }

        public void menuPrincipal()
        {
            Console.WriteLine("BIENVENIDO A LA CLINICA DE BVRGUILLX");
            string opcion;

            Console.WriteLine();
            Console.WriteLine("------- MENU PRINCIPAL -------");
            Console.WriteLine("");
            Console.WriteLine("(1). AÑADIR ANIMAL ");
            Console.WriteLine("(2). BUSCAR ANIMAL ");
            Console.WriteLine("(3). MODIFICAR COMENTARIOS DEL ANIMAL ");
            Console.WriteLine("(4). PESAR ANIMAL");
            Console.WriteLine("(5). MOSTRAR FICHA DEL ANIMAL");
            Console.WriteLine("(6). SALIR DEL PROGRAMA");
            Console.WriteLine("");
            Console.Write("¿QUE QUIERE HACER?: ");

            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    aniadirAnimal();
                    break;
                case "2":
                    BuscarAnimal();
                    break;
                case "3":
                    modifComentarios();
                    break;
                case "4":
                    pesarAnimal();
                    break;
                case "5":
                    mostrarFicha();
                    break;
                case "6":
                    Console.WriteLine();
                    Console.WriteLine("¡¡ HASTA LA PROXIMA !!");
                    Console.WriteLine();
                    break;
            }
        }

        public void aniadirAnimal()
        {
            // ATRIBUTOS
            string nombre;
            string fechaNacimiento;
            int peso;
            string especieReptil;
            bool venenoso = false;
            string razaPerro, microChipPerro;
            string razaGato, microChripGato;
            string especiePajaro;
            bool cantor = false;

            // PRIMER PASO PARA CREAR ANIMAL, INTRODUCIR DATOS POR PANTALLA
            Console.WriteLine();
            Console.WriteLine("----- TIPO ANIMAL -----");
            Console.WriteLine("");
            Console.WriteLine(" (1). PERRO ");
            Console.WriteLine(" (2). GATO ");
            Console.WriteLine(" (3). PAJARO ");
            Console.WriteLine(" (4). REPTIL ");
            Console.WriteLine();
            Console.WriteLine("¿TIPO DE ANIMAL?: ");

            // SEGUNDO PASO DE LA CREACION, DECIDIR EL TIPO DE ANIMAL
            string opcion;
            opcion = Console.ReadLine();

            string variableAuxiliar;

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("NOMBRE: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("RAZA: ");
                    razaPerro = Console.ReadLine();
                    Console.WriteLine("FECHA: ");
                    fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("MICROCHIP: ");
                    microChipPerro = Console.ReadLine();
                    Console.WriteLine("PESO: ");
                    peso = (int)Console.Read(); // NO ME DEJA CREAR ANIMALES CUANDO INTRODUZCO EL PESO, Y CREO QUE ES POR EL METODO READ
                                                // YA QUE PONE QUE DEVUELVE UN INT Y ESTOY TRABAJANDO CON PESO COMO DOUBLE
                    Perro P = new Perro(nombre, razaPerro, fechaNacimiento, peso, microChipPerro);
                    InsertarAnimal(P);
                    break;
                case "2":
                    Console.WriteLine("NOMBRE: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("RAZA: ");
                    razaGato = Console.ReadLine();
                    Console.WriteLine("FECHA: ");
                    fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("MICROCHIP: ");
                    microChripGato = Console.ReadLine();
                    Console.WriteLine("PESO: ");
                    peso = (int)Console.Read();
                    Gato G = new Gato(nombre, razaGato, fechaNacimiento, peso, microChripGato);
                    InsertarAnimal(G);
                    break;
                case "3":
                    Console.WriteLine("NOMBRE: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ESPECIE: ");
                    especiePajaro = Console.ReadLine();
                    Console.WriteLine("FECHA: ");
                    fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("¿CANTA?: (1). SI (2). NO");
                    variableAuxiliar = Console.ReadLine();
                    if (variableAuxiliar == "1")
                    {
                        cantor = true;
                    }
                    else if (variableAuxiliar == "2")
                    {
                        cantor = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: OPCION SELECCIONADA NO VALIDA");
                    }
                    Console.Write(cantor);
                    Console.WriteLine();
                    Console.WriteLine("PESO: ");
                    peso = (int)Console.Read();
                    Pajaro Paj = new Pajaro(nombre, especiePajaro, fechaNacimiento, peso, cantor);
                    InsertarAnimal(Paj);
                    break;
                case "4":
                    Console.WriteLine("NOMBRE: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ESPECIE: ");
                    especieReptil = Console.ReadLine();
                    Console.WriteLine("FECHA: ");
                    fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("¿VENENOSO?: (1). SI (2). NO");
                    variableAuxiliar = Console.ReadLine();
                    if (variableAuxiliar == "1")
                    {
                        venenoso = true;
                    }
                    else if (variableAuxiliar == "2")
                    {
                        venenoso = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: OPCION SELECCIONADA NO VALIDA");
                    }
                    Console.Write(venenoso);
                    Console.WriteLine();
                    Console.WriteLine("PESO: ");
                    peso = (int)Console.Read();
                    Reptil R = new Reptil(nombre, especieReptil, fechaNacimiento, peso, venenoso);
                    InsertarAnimal(R);
                    break;
            }
        }

        private void InsertarAnimal(Animal a)
        {
            if (!this.ListaAnimales.Contains(a))
            {
                this.ListaAnimales.Add(a);
            }
            else
            {
                Console.WriteLine("EL ANIMAL " + a.nombreAni + " YA ESTA EN LA CLINICA");
            }
        }


        // private void crearPerro()
        // {
        //    string nombre, peso, fechaNacimiento, razaPerro, microChipPerro;
        //    Console.WriteLine("RAZA: ");
        //   razaPerro = Console.ReadLine();
        //    Console.WriteLine("MICROCHIP: ");
        //    microChipPerro = Console.ReadLine();
        //    Perro P = new Perro(nombre, razaPerro, fechaNacimiento, peso, microChipPerro);
        //    InsertarAnimal(P);
        // }


        private void BuscarAnimal()
        {
            Console.WriteLine("¿NOMBRE DE SU MASCOTA, PORFAVOR?:");
            string nombreAuxiliar = Console.ReadLine();
            Animal aBuscar = null;
            foreach (Animal a in ListaAnimales)
            {
                if (a.nombreAni.Equals(nombreAuxiliar))
                {
                    aBuscar = a;
                }
            }
            // SI LO ENCUENTRA, LO MUESTRA
            if (aBuscar != null || ListaAnimales.Contains(aBuscar))
            {
                Console.WriteLine(aBuscar.ToString());
            }
            else
            {
                Console.WriteLine("ERROR: NO HEMOS ENCONTRADO EL ANIMAL");
                Console.WriteLine();
                menuPrincipal();
            }
        }
        public void pesarAnimal()
        {
            string nombre;
            Console.WriteLine("¿NOMBRE DEL ANIMAL?: ");
            nombre = Console.ReadLine();
            Animal aBuscar = null;

            foreach (Animal a in ListaAnimales)
            {
                if (a.nombreAni.Equals(nombre))
                {
                    aBuscar = a;
                }
            }
            // SI LO ENCUENTRA, TE DEJA PESARLE
            if (aBuscar != null || ListaAnimales.Contains(aBuscar))
            {
                Console.WriteLine(aBuscar.pesoAni);
            }
            else
            {
                Console.WriteLine("ERROR: NO HEMOS ENCONTRADO EL ANIMAL");
                Console.WriteLine();
                menuPrincipal();
            }
        }
        public void mostrarFicha()
        {
            string nombre;
            Console.WriteLine("¿NOMBRE DEL ANIMAL?: ");
            nombre = Console.ReadLine();
            Animal aMostrar = null;

            foreach (Animal a in ListaAnimales)
            {
                if (a.nombreAni.Equals(nombre))
                {
                    aMostrar = a;
                }
            }
            // SI LO ENCUENTRA, LE MUESTRA
            if (aMostrar != null || ListaAnimales.Contains(aMostrar))
            {
                Console.WriteLine(aMostrar.ToString());
            }
            else
            {
                Console.WriteLine("ERROR: NO HEMOS ENCONTRADO EL ANIMAL");
                Console.WriteLine();
                menuPrincipal();
            }
        }
        public void modifComentarios()
        {
            string nombre;
            Console.WriteLine("¿NOMBRE DEL ANIMAL?: ");
            nombre = Console.ReadLine();
            Animal aModificar = null;

            foreach (Animal a in ListaAnimales)
            {
                if (a.nombreAni.Equals(nombre))
                {
                    aModificar = a;
                    string comentarios;
                    Console.WriteLine("INTRODUZCA LOS NUEVOS COMENTARIOS: ");
                    Console.WriteLine();
                    comentarios = Console.ReadLine();
                }
            }
            // SI LO ENCUENTRA, TE DEJA MODIFICARLE
            if (aModificar != null || ListaAnimales.Contains(aModificar))
            {
                Console.WriteLine(aModificar.ToString());
            }
            else
            {
                Console.WriteLine("ERROR: NO HEMOS ENCONTRADO EL ANIMAL");
                Console.WriteLine();
                menuPrincipal();
            }
        }
        //public void paraProbar()
        //{
        //    Perro A = new Perro("burguillo", "Pastor Aleman", "Antes de Aye", 55, "54654654KLJ");
        //    Gato G = new Gato("chispitas", "persa", "Antes de Aye", 88, "23131321ADS");
        //    Pajaro P = new Pajaro("Figaro", "Pastor Aleman", "Antes de Aye", 55, true);
        //    Reptil R = new Reptil("burguillo", "Pastor Aleman", "Antes de Aye", 55, false);
        //    ListaAnimales.Add(A);
        //}
    }

}
