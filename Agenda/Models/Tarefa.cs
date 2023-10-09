namespace Agenda.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Feito { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}