namespace EjercicioPresidentes.Models.ViewModels
{
    public class IndexViewModel
    {
        //VIEWMODEL VISRTA

        public IEnumerable<PresidenteModel>? Presidentes { get; set; }
    }

    public class PresidenteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Periodo { get; set; } = "";
    }
}
