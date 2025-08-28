using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListaDeContactos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------LISTA DE CONTACTOS---------------");

            List<(string nombre, string telefono, string email)> ListaDeContactos = new List<(string nombre, string telefono, string email)>();

            void AgregarContacto(string nombre, string telefono, string email)
            {
                (string nombre, string telefono, string email) contacto = (nombre, telefono, email);
                ListaDeContactos.Add(contacto);
            }

            void MostrarContactos()
            {
                if (ListaDeContactos.Count == 0)
                {
                    Console.WriteLine("No tienes contactos :( ");
                }else
                {
                    foreach (var contacto in ListaDeContactos)
                    {
                        Console.WriteLine($"Este es el contacto de {contacto.nombre}, es tel: {contacto.telefono}, email: {contacto.email}");
                    }
                }
                   
            }
        }
    }
}
