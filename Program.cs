using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    class Usuario 
    {
        // Atributos Campos 
        private string Nombre;
        private string Correo;
        private int Seguidores;

        // 
        public void Publicar(string Texto)
        {
            Console.WriteLine($"{Nombre}:  Acaba de publicar lo siguiente:  {Texto} ");  
        }
        public void VerPerfil()
        {
            Console.WriteLine($"User: {Nombre}, Correo: {Correo}, Seguidores: {Seguidores}");
        }
        public void SetName(string nombre)
        {
            // TO DO: Verificar que el nombre de usuario no existe 
            this.Nombre = nombre;
        }
        public void SetCorrep(string correo)
        {
            // TO DO: Verificar que el nombre de usuario no existe 
            this.Correo = correo;
        }
        public void SetSegudores(int seguidores)
        {
            // TO DO: Verificar que el nombre de usuario no existe 
            if (seguidores < 0)
            
                seguidores = seguidores  * -1;
                Seguidores = seguidores;
            
           

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Usuario Mario = new Usuario();

            // Mario.SetName = "Mariosky";
            Mario.SetName("Mariosky");
            Mario.SetSegudores(80);


            Mario.VerPerfil();
            Mario.Publicar("Hola a todos:3");

            Console.ReadKey();
        }
    }
}
