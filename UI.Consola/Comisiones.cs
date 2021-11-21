using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Comisiones
    {
        private Business.Logic.ComisionLogic _ComisionNegocio;

        public ComisionLogic ComisionNegocio
        {
            get { return _ComisionNegocio; }
            set { _ComisionNegocio = value; }
        }

        public Comisiones()
        {
            this.ComisionNegocio = new ComisionLogic();
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
            foreach (Comision com in ComisionNegocio.GetAll())
            {
                MostrarDatos(com);
            }
        }

        public void MostrarDatos(Comision com)
        {
            Console.WriteLine("Comision: {0}", com.ID);
            Console.WriteLine("\t\tAño especialidad: {0}", com.AnioEspecialidad);
            Console.WriteLine("\t\tDescripcion: {0}", com.Descripcion);
            Console.WriteLine("\t\tId plan: {0}", com.IdPlan);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la comision a consultar: ");
                int id = int.Parse(Console.ReadLine());
                this.MostrarDatos(ComisionNegocio.GetOne(id));
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
            Comision comi = new Comision();

            Console.Clear();
            Console.Write("Ingrese Año de especialidad: ");
            comi.AnioEspecialidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Descripción: ");
            comi.Descripcion = Console.ReadLine();
            Console.Write("Ingrese id de plan: ");
            comi.IdPlan = int.Parse(Console.ReadLine());
            comi.State = BusinessEntity.States.New;
            ComisionNegocio.Save(comi);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", comi.ID);
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la comision a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Comision comi = ComisionNegocio.GetOne(ID);
                Console.Write("Ingrese Año de especialidad: ");
                comi.AnioEspecialidad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese Descripción: ");
                comi.Descripcion = Console.ReadLine();
                Console.Write("Ingrese id de plan: ");
                comi.IdPlan = int.Parse(Console.ReadLine());
                comi.State = BusinessEntity.States.Modified;
                ComisionNegocio.Save(comi);
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
                Console.WriteLine("Ingrese el ID de la comision a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                ComisionNegocio.Delete(ID);

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
