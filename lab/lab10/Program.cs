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
            while (true)
            {
                
                List<Person> personas = new List<Person>();
                List<Address> direcciones = new List<Address>();
                List<Car> autos = new List<Car>();
                Console.WriteLine("Menu \n(1) Ingresar personas \n(2) Ingresar propiedad \n(3) Ingresar automovil \n(4) Salir");
                string respuesta = Console.ReadLine();
                if (respuesta == "1")
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
                        if (p1.Rut==parent1)
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
                else if (respuesta == "2")
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
                else if (respuesta == "3")
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
                else if(respuesta=="4")
                {
                    Console.WriteLine("Programa terminado");
                    break;
                }

            }
                
            
        }
    }
}
