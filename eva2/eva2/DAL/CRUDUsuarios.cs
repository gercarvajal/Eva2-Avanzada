﻿using eva2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static eva2.DTO.Usuario;

namespace eva2.DAL
{
    internal class CRUDUsuarios
    {

        private static List<Usuario> usuarios = new List<Usuario>();

        public void Insertar(Usuario usu)
        {

            usuarios.Add(usu);
            String li = usu.Usuari + ";" + usu.Clave;
        
            StreamWriter Temp = new StreamWriter(@"D:\C#Programs\eva2\eva2\Usuarios.txt", true);
            Temp.WriteLine(li);
            Temp.Close();
         
           

        }

        public void Modificar(int indice, Usuario usu,Usuario antiguo)
        {
            // modificarv en lista
            usuarios.Insert(indice, usu);


            //borrar en archivo

            string FileToRead = @"D:\C#Programs\eva2\eva2\Usuarios.txt";
            string[] lines = File.ReadAllLines(FileToRead);

            int k = 0;
            while (k < lines.Length)
            {
                String[] datos = lines[k].Split(";");

                if ((antiguo.Usuari == datos[0]))
                {
                    lines = lines.Where((source, index) => index != k).ToArray();
                }

                k = k + 1;
            }

            File.WriteAllLines(@"D:\C#Programs\eva2\eva2\Usuarios.txt", lines);

            //Insertar nuevo en archivo

            String li = usu.Usuari + ";" + usu.Clave;

            StreamWriter Temp = new StreamWriter(@"D:\C#Programs\eva2\eva2\Usuarios.txt", true);
            Temp.WriteLine(li);
            Temp.Close();



        }
       
        public void Eliminar(Usuario usu)
        {
            //borra lista

            usuarios.Remove(usu);

            //borra archivo

            string FileToRead = @"D:\C#Programs\eva2\eva2\Usuarios.txt";
            string[] lines = File.ReadAllLines(FileToRead);

            int k = 0;
            while (k < lines.Length)
            {
                String[] datos = lines[k].Split(";");

                if ((usu.Usuari == datos[0]))
                {
                    lines = lines.Where((source, index) => index != k).ToArray();
                }

                k = k + 1;
            }

            File.WriteAllLines(@"D:\C#Programs\eva2\eva2\Usuarios.txt", lines);
           

        }

        public void borrartodoarchivo() {

            FileStream fileStream = File.Open(@"D:\C#Programs\eva2\eva2\Usuarios.txt", FileMode.Open);

            fileStream.SetLength(0);

            fileStream.Close();

       



        }

        public List<Usuario> Mostrar()
        {

            return usuarios;
        }

        //definir metodos struct

        public static readonly tipousuario Tipobode = new tipousuario()
        {

            Nombre = "Bodeguero",
            Codigo = "0001"

        };

        public static readonly tipousuario Tipoadm = new tipousuario()
        {

            Nombre = "Administrador",
            Codigo = "0002"

        };
        public static readonly tipousuario Tipousu = new tipousuario()
        {

            Nombre = "Usuario",
            Codigo = "0003"

        };





















    }
}
