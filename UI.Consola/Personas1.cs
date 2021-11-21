using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace UI.Consola
{
    public class Personas1
    {
        private Business.Logic.PersonasLogic _PersonaNegocio;

        public PersonasLogic PersonaNegocio
        {
            get { return _PersonaNegocio; }
            set { _PersonaNegocio = value; }
        }

        public Personas1()
        {
            this.PersonaNegocio = new PersonasLogic();
        }

        public void Menu()
        {
            int op;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1- Listado General");
                Console.WriteLine("2– Consulta");
                Console.WriteLine("3– Agregar");
                Console.WriteLine("4- Modificar");
                Console.WriteLine("5- Eliminar");
                Console.WriteLine("6- Salir");
                Console.WriteLine("");
                Console.Write("Ingrese una opción: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            ListadoGeneral();
                            break;
                        }
                    case 2:
                        {
                            Consultar();
                            break;
                        }
                    case 3:
                        {
                            Agregar();
                            break;
                        }
                    case 4:
                        {
                            Modificar();
                            break;
                        }
                    case 5:
                        {
                            Eliminar();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            } while (op != 6);
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Personas per in PersonaNegocio.GetAll())
            {
                MostrarDatos(per);
            }
        }

        public void MostrarDatos(Personas per)
        {
            Console.WriteLine("Persona: {0}", per.ID);
            Console.WriteLine("\t\tNombre: {0}", per.Nombre);
            Console.WriteLine("\t\tApellido: {0}", per.Apellido);
            Console.WriteLine("\t\tDirección: {0}", per.Direccion);
            Console.WriteLine("\t\tTélefono: {0}", per.Telefono);
            Console.WriteLine("\t\tEmail: {0}", per.Email);
            Console.WriteLine("\t\tFecha de Nacimiento: {0}", per.FechaNacimiento);
            Console.WriteLine("\t\tId plan: {0}", per.IdPlan);
            Console.WriteLine("\t\tNº Legajo: {0}", per.Legajo);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la persona a consultar: ");
                int id = int.Parse(Console.ReadLine());
                this.MostrarDatos(PersonaNegocio.GetOne(id));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Agregar()
        {
            Personas pers = new Personas();

            Console.Clear();
            Console.Write("Ingrese nombre: ");
            pers.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");
            pers.Apellido = Console.ReadLine();
            Console.Write("Ingrese Direccion: ");
            pers.Direccion = Console.ReadLine();
            Console.Write("Ingrese telefono: ");
            pers.Telefono = Console.ReadLine();
            Console.Write("Ingrese Email: ");
            pers.Email = Console.ReadLine();
            Console.Write("Ingrese nº de legajo: ");
            pers.Legajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese id de plan: ");
            pers.IdPlan = int.Parse(Console.ReadLine());
            Console.Write("Ingrese fecha de nacimiento: ");
            pers.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            pers.State = BusinessEntity.States.New;
            PersonaNegocio.Save(pers);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", pers.ID);
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la persona a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Personas pers = PersonaNegocio.GetOne(ID);
                Console.Write("Ingrese nombre: ");
                pers.Nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido: ");
                pers.Apellido = Console.ReadLine();
                Console.Write("Ingrese Direccion: ");
                pers.Direccion = Console.ReadLine();
                Console.Write("Ingrese telefono: ");
                pers.Telefono = Console.ReadLine();
                Console.Write("Ingrese Email: ");
                pers.Email = Console.ReadLine();
                Console.Write("Ingrese nº de legajo: ");
                pers.Legajo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese id de plan: ");
                pers.IdPlan = int.Parse(Console.ReadLine());
                Console.Write("Ingrese fecha de nacimiento: ");
                pers.FechaNacimiento = DateTime.Parse(Console.ReadLine());
                pers.State = BusinessEntity.States.Modified;
                PersonaNegocio.Save(pers);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la persona a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                PersonaNegocio.Delete(ID);

            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
