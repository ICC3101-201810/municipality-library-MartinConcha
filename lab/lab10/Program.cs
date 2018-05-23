using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> personas = new List<Person>();
            List<Address> direcciones = new List<Address>();
            List<Car> autos = new List<Car>();
            while (true)
            {
                Console.WriteLine("Menu \n(1) Administrar personas \n(2) Administrar propiedad \n(3) Administrar automovil \n(4) Salir");
                string respuesta = Console.ReadLine();
                while (respuesta == "1")
                {
                    Console.WriteLine("Menu \n(1) Agregar persona \n(2) Cambiar nombre \n(3) Editar parentesco \n(4) Ingresar educacion \n(5) Salir al menu ");
                    string respuesta1 = Console.ReadLine();
                    if (respuesta1 == "1")
                    {
                        Console.WriteLine("Ingrese nombre: ");
                        string pn = Console.ReadLine();
                        Console.WriteLine("Ingrese apellido: ");
                        string ap = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento: ");
                        string dt1 = Console.ReadLine();
                        DateTime dt = DateTime.Parse(dt1);
                        Console.WriteLine("Ingrese nombre direccion: ");
                        string dir = Console.ReadLine();
                        Console.WriteLine("Ingrese numero direccion: ");
                        string num1 = Console.ReadLine();
                        int num = Int32.Parse(num1);
                        Console.WriteLine("Ingrese comuna: ");
                        string comuna = Console.ReadLine();
                        Address direccion;
                        foreach (Address dire in direcciones)
                        {
                            if (dire.Street == dir && dire.Number == num && dire.Commune == comuna)
                            {
                                direccion = dire;
                            }
                        }
                        Console.WriteLine("Ingrese rut: ");
                        string rut = Console.ReadLine();
                        Console.WriteLine("Ingrese rut parentesco 1: ");
                        string parent1 = Console.ReadLine();
                        Person parentesco1;
                        foreach (Person p1 in personas)
                        {
                            if (p1.Rut == parent1)
                            {
                                parentesco1 = p1;
                            }
                        }
                        Console.WriteLine("Ingrese rut parentesco 2: ");
                        string parent2 = Console.ReadLine();
                        Person parentesco2;
                        foreach (Person p2 in personas)
                        {
                            if (p2.Rut == parent2)
                            {
                                parentesco2 = p2;
                            }
                        }
                        Person persona = new Person(pn, ap, dt, direccion, rut, parentesco1, parentesco2);
                        personas.Add(persona);
                    }
                    else if (respuesta1 == "2")
                    {
                        Console.WriteLine("Ingrese rut: ");
                        string rut = Console.ReadLine();
                        foreach (Person persona in personas)
                        {
                            if (persona.Rut == rut)
                            {
                                Console.WriteLine("Ingrese nuevo nombre: ");
                                string pn = Console.ReadLine();
                                Console.WriteLine("Ingrese nuevo apellido: ");
                                string ap = Console.ReadLine();
                                persona.changeFirstName(pn);
                                persona.changeLastName(ap);
                            }

                        }

                    }
                    else if (respuesta1 == "3")
                    {
                        Console.WriteLine("Ingrese rut: ");
                        string rut = Console.ReadLine();
                        foreach (Person persona in personas)
                        {
                            if (persona.Rut == rut)
                            {
                                Console.WriteLine("Desea...? (1) Añadir un parentesco, (2) Añadir dos parentescos, (3) Eliminar parentesco ");
                                string respuesta2 = Console.ReadLine();
                                if (respuesta2 == "1")
                                {
                                    Console.WriteLine("Ingrese rut parentesco: ");
                                    string rutp = Console.ReadLine();
                                    foreach (Person padre in personas)
                                    {
                                        if (padre.Rut == rutp)
                                        {
                                            if (persona.getAdopted(padre) == true)
                                            {
                                                Console.WriteLine("Parentesco añadido");
                                            }
                                            else { Console.WriteLine("No se pudo añadir"); }
                                            
                                        }
                                    }
                                }
                                else if (respuesta2 == "2")
                                {
                                    Console.WriteLine("Ingrese rut parentesco 1: ");
                                    string rutp1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese rut parentesco 2: ");
                                    string rutp2 = Console.ReadLine();
                                    foreach (Person padre in personas)
                                    {
                                        if (padre.Rut == rutp1)
                                        {
                                            foreach (Person madre in personas)
                                            {
                                                if (madre.Rut == rutp2)
                                                {
                                                    if (persona.getAdopted(padre, madre) == true)
                                                    {
                                                        Console.WriteLine("Parentesco añadido");
                                                    }
                                                    else { Console.WriteLine("No se pudo añadir"); }
                                                }
                                            }                                            
                                        }
                                    }
                                }
                                else if (respuesta2  == "3")
                                {
                                    persona.getAbandoned();
                                    Console.WriteLine("Parentesco eliminado");
                                }

                            }
                        }

                    }
                    else if(respuesta1 == "4")
                    {
                        Console.WriteLine("Ingrese rut: ");
                        string rut = Console.ReadLine();
                        foreach (Person persona in personas)
                        {
                            if (persona.Rut == rut)
                            {
                                Console.WriteLine("Ingrese alma mater: ");
                                string alma = Console.ReadLine();
                                Console.WriteLine("Ingrese grado profesional: ");
                                string grado = Console.ReadLine();
                                if (persona.setEducation(alma, grado) == true)
                                {
                                    Console.WriteLine("Se agrego correctamente");
                                }
                            }
                        }
                    }
                    else if(respuesta1 == "4")
                    {
                        break;
                    }
                }
                while (respuesta == "2")
                {
                    Console.WriteLine("Menu \n(1) Ingresar direccion \n(2) Agregar baños y piezas \n(3) Cambiar dueño \n(4) Salir al menu");
                    string respuesta1 = Console.ReadLine();
                    if (respuesta1 == "1")
                    {
                        Console.WriteLine("Ingrese nombre direccion: ");
                        string dir = Console.ReadLine();
                        Console.WriteLine("Ingrese numero direccion: ");
                        string num1 = Console.ReadLine();
                        int num = Int32.Parse(num1);
                        Console.WriteLine("Ingrese comuna: ");
                        string comuna = Console.ReadLine();
                        Console.WriteLine("Ingrese ciudad: ");
                        string ciudad = Console.ReadLine();
                        Console.WriteLine("Ingrese rut propietario: ");
                        string rut = Console.ReadLine();
                        Person persona;
                        foreach (Person p in personas)
                        {
                            if (p.Rut == rut)
                            {
                                persona = p;
                            }
                        }
                        Console.WriteLine("Ingrese año de construccion: ");
                        string año1 = Console.ReadLine();
                        int año = Int32.Parse(año1);
                        Console.WriteLine("Ingrese habitaciones: ");
                        string habitacion1 = Console.ReadLine();
                        int habitacion = Int32.Parse(habitacion1);
                        Console.WriteLine("Ingrese baños: ");
                        string baño1 = Console.ReadLine();
                        int baño = Int32.Parse(baño1);
                        Console.WriteLine("Tiene patio trazero (1)si (2)no : ");
                        string r = Console.ReadLine();
                        bool by = true;
                        if (r == "1")
                        {
                            by = true;
                        }
                        else { by = false; }
                        Console.WriteLine("Tiene piscina (1)si (2)no : ");
                        string r1 = Console.ReadLine();
                        bool pis = true;
                        if (r1 == "1")
                        {
                            pis = true;
                        }
                        else { pis = false; }
                        Address direccion = new Address(dir, num, comuna, ciudad, persona, año, habitacion, baño, by, pis);
                        direcciones.Add(direccion);
                    }
                    else if (respuesta1 == "2")
                    {
                        Console.WriteLine("Ingrese nombre direccion: ");
                        string dir = Console.ReadLine();
                        Console.WriteLine("Ingrese numero direccion: ");
                        string num1 = Console.ReadLine();
                        int num = Int32.Parse(num1);
                        Console.WriteLine("Ingrese comuna: ");
                        string comuna = Console.ReadLine();
                        foreach(Address direccion in direcciones)
                        {
                            if (dir == direccion.Street && num == direccion.Number && comuna == direccion.Commune)
                            {
                                Console.WriteLine("Ingrese numero de baños: ");
                                string baños1 = Console.ReadLine();
                                int baños = Int32.Parse(baños1);
                                Console.WriteLine("Ingrese numero de piezas: ");
                                string piezas1 = Console.ReadLine();
                                int piezas = Int32.Parse(piezas1);
                                direccion.addBathrooms(baños);
                                direccion.addBeedrooms(piezas);
                            }
                        }
                    }
                    else if (respuesta1 == "3")
                    {
                        Console.WriteLine("Ingrese nombre direccion: ");
                        string dir = Console.ReadLine();
                        Console.WriteLine("Ingrese numero direccion: ");
                        string num1 = Console.ReadLine();
                        int num = Int32.Parse(num1);
                        Console.WriteLine("Ingrese comuna: ");
                        string comuna = Console.ReadLine();
                        foreach (Address direccion in direcciones)
                        {
                            if (dir == direccion.Street && num == direccion.Number && comuna == direccion.Commune)
                            {
                                Console.WriteLine("Ingrese rut: ");
                                string rut = Console.ReadLine();
                                foreach (Person persona in personas)
                                {
                                    if (persona.Rut == rut)
                                    {
                                        direccion.changeOwner(persona);
                                    }
                                }
                            }
                        }
                    }
                    else if(respuesta1 == "4")
                    {
                        break;
                    }
                }
                while (respuesta == "3")
                {
                    Console.WriteLine("Menu \n(1) Agregar auto \n(2) Cambiar dueño \n(3) Salir al menu");
                    string respuesta1 = Console.ReadLine();
                    if (respuesta1 == "1")
                    {
                        Console.WriteLine("Ingrese marca: ");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Ingrese modelo: ");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Ingrese año: ");
                        string año1 = Console.ReadLine();
                        int año = Int32.Parse(año1);
                        Console.WriteLine("Ingrese rut propietario: ");
                        string rut = Console.ReadLine();
                        Person persona;
                        foreach (Person p in personas)
                        {
                            if (p.Rut == rut)
                            {
                                persona = p;
                            }
                        }
                        Console.WriteLine("Ingrese matricula: ");
                        string matricula = Console.ReadLine();
                        Console.WriteLine("Ingrese cuantos cinturones: ");
                        string cinturon1 = Console.ReadLine();
                        int cinturon = Int32.Parse(cinturon1);
                        Console.WriteLine("Usa diesel (1)si (2)no : ");
                        string r = Console.ReadLine();
                        bool dis = true;
                        if (r == "1")
                        {
                            dis = true;
                        }
                        else { dis = false; }
                        Car auto = new Car(marca, modelo, año, persona, matricula, cinturon, dis);
                        autos.Add(auto);
                    }
                    else if(respuesta1 == "2")
                    {
                        Console.WriteLine("Ingrese matricula: ");
                        string matricula = Console.ReadLine();
                        foreach (Car auto in autos)
                        {
                            if (matricula == auto.License_plate)
                            {
                                Console.WriteLine("Ingrese nuevo rut del dueño: ");
                                string rut = Console.ReadLine();
                                foreach (Person persona in personas)
                                {
                                    if (rut == persona.Rut)
                                    {
                                        auto.giveUpOwnershipToThirdParty(persona);
                                    }
                                }
                            }
                        }
                    }
                    else if(respuesta1 == "4")
                    {
                        break;
                    }
                }
                if(respuesta=="4")
                {
                    Console.WriteLine("Programa terminado");
                    break;
                }

            }
                
            
        }
    }
}
