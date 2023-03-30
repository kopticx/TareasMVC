using TareasMVC.Models;

namespace TareasMVC.Servicios
{
    public interface IAlmacenadorArchivos
    {
        Task Borrar(string key);
        Task<AlmacenarArchivoResultado[]> Almacenar(IEnumerable<IFormFile> archivos);
    }
}
