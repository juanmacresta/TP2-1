using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Cursos
    {
        private Business.Logic.CursoLogic _CursoNegocio;

        public CursoLogic CursoNegocio
        {
            get { return _CursoNegocio; }
            set { _CursoNegocio = value; }
        }

        public Cursos()
        {
            this.CursoNegocio = new CursoLogic();
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
            foreach (Curso cur in CursoNegocio.GetAll())
            {
                MostrarDatos(cur);
            }
        }

        public void MostrarDatos(Curso cur)
        {
            Console.WriteLine("Curso: {0}", cur.ID);
            Console.WriteLine("\t\tAño calendario: {0}", cur.AnioCalendario);
            Console.WriteLine("\t\tCupo {0}", cur.Cupo);
            Console.WriteLine("\t\tDescripcion: {0}", cur.Descripcion);
            Console.WriteLine("\t\tId de comision: {0}", cur.IdComision);
            Console.WriteLine("\t\tId de materia: {0}", cur.IdMateria);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del curso a consultar: ");
                int id = int.Parse(Console.ReadLine());
                this.MostrarDatos(CursoNegocio.GetOne(id));
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
            Curso cur = new Curso();

            Console.Clear();
            Console.Write("Ingrese Año calendario: ");
            cur.AnioCalendario = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Descripcion: ");
            cur.Descripcion = Console.ReadLine();
            Console.Write("Ingrese Cupo: ");
            cur.Cupo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese id de comision: ");
            cur.IdComision = int.Parse(Console.ReadLine());
            Console.Write("Ingrese id de materia: ");
            cur.IdMateria = int.Parse(Console.ReadLine());
            cur.State = BusinessEntity.States.New;
            CursoNegocio.Save(cur);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", cur.ID);
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del curso a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Curso cur = CursoNegocio.GetOne(ID);
                Console.Write("Ingrese Año calendario: ");
                cur.AnioCalendario = int.Parse(Console.ReadLine());
                Console.Write("Ingrese Descripcion: ");
                cur.Descripcion = Console.ReadLine();
                Console.Write("Ingrese Cupo: ");
                cur.Cupo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese id de comision: ");
                cur.IdComision = int.Parse(Console.ReadLine());
                Console.Write("Ingrese id de materia: ");
                cur.IdMateria = int.Parse(Console.ReadLine());
                cur.State = BusinessEntity.States.Modified;
                CursoNegocio.Save(cur);
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
                Console.WriteLine("Ingrese el ID del curso a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                CursoNegocio.Delete(ID);

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
