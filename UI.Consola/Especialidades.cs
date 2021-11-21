using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace UI.Consola
{
    public class Especialidades
    {
        private Business.Logic.EspecialidadLogic _EspecialidadNegocio;

        public Especialidades()
        {
            this.EspecialidadNegocio = new EspecialidadLogic();
        }

        public EspecialidadLogic EspecialidadNegocio
        {
            get { return _EspecialidadNegocio; }
            set { _EspecialidadNegocio = value; }
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
            foreach (Especialidad esp in EspecialidadNegocio.GetAll())
            {
                MostrarDatos(esp);
            }
        }

        public void MostrarDatos(Especialidad esp)
        {
            Console.WriteLine("Especialidad: {0}", esp.ID);
            Console.WriteLine("\t\tDescripción: {0}", esp.Descripcion);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la especialidad a consultar: ");
                int id = int.Parse(Console.ReadLine());
                this.MostrarDatos(EspecialidadNegocio.GetOne(id));
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
            Especialidad espec = new Especialidad();

            Console.Clear();
            Console.Write("Ingrese descripcion: ");
            espec.Descripcion = Console.ReadLine();
            espec.State = BusinessEntity.States.New;
            EspecialidadNegocio.Save(espec);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", espec.ID);
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la especialidad a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Especialidad espe = EspecialidadNegocio.GetOne(ID);
                Console.Write("Ingrese descripcion: ");
                espe.Descripcion = Console.ReadLine();
                espe.State = BusinessEntity.States.Modified;
                EspecialidadNegocio.Save(espe);
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
                Console.WriteLine("Ingrese el ID de la especialidad a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                EspecialidadNegocio.Delete(ID);

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
