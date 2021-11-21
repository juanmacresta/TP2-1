using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Materias
    {
        private Business.Logic.MateriaLogic _MateriaNegocio;

        public MateriaLogic MateriaNegocio
        {
            get { return _MateriaNegocio; }
            set { _MateriaNegocio = value; }
        }

        public Materias()
        {
            this.MateriaNegocio = new MateriaLogic();
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
            foreach (Materia mat in MateriaNegocio.GetAll())
            {
                MostrarDatos(mat);
            }
        }

        public void MostrarDatos(Materia mat)
        {
            Console.WriteLine("Materia: {0}", mat.ID);
            Console.WriteLine("\t\tDescripcion: {0}", mat.Descripcion);
            Console.WriteLine("\t\tHoras semanales: {0}", mat.HsSemanales);
            Console.WriteLine("\t\tHoras totales: {0}", mat.HsTotales);
            Console.WriteLine("\t\tId de plan: {0}", mat.IdPlan);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la materia a consultar: ");
                int id = int.Parse(Console.ReadLine());
                this.MostrarDatos(MateriaNegocio.GetOne(id));
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
            Materia mat = new Materia();

            Console.Clear();
            Console.Write("Ingrese descripcion: ");
            mat.Descripcion = Console.ReadLine();
            Console.Write("Ingrese horas semanales: ");
            mat.HsSemanales = int.Parse(Console.ReadLine());
            Console.Write("Ingrese horas totales: ");
            mat.HsTotales = int.Parse(Console.ReadLine());
            Console.Write("Ingrese id de plan: ");
            mat.IdPlan = int.Parse(Console.ReadLine());
            mat.State = BusinessEntity.States.New;
            MateriaNegocio.Save(mat);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", mat.ID);
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la materia a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Materia mat = MateriaNegocio.GetOne(ID);
                Console.Clear();
                Console.Write("Ingrese descripcion: ");
                mat.Descripcion = Console.ReadLine();
                Console.Write("Ingrese horas semanales: ");
                mat.HsSemanales = int.Parse(Console.ReadLine());
                Console.Write("Ingrese horas totales: ");
                mat.HsTotales = int.Parse(Console.ReadLine());
                Console.Write("Ingrese id de plan: ");
                mat.IdPlan = int.Parse(Console.ReadLine());
                mat.State = BusinessEntity.States.Modified;
                MateriaNegocio.Save(mat);


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
                Console.WriteLine("Ingrese el ID de la materia a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                MateriaNegocio.Delete(ID);

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
