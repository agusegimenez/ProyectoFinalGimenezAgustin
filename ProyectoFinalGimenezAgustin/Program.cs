

namespace ProyectoCSharp
{
    public class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            ProductoHandler productoHandler = new ProductoHandler();

            List<string> descripciones = productoHandler.GetDescripciones();

            foreach (string descripcion in descripciones)
            {
                Console.WriteLine(descripcion);
            }

            UsuarioHandler usuarioHandler = new UsuarioHandler();

            usuarioHandler.GetUsuario();

        }
    }
}