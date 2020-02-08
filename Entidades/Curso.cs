namespace IntentoCasa.Entidades
{
    public class Curso
    {
        public string id { get; private set; }
        public string Nombre { get; set; }

        public TipoCurso Tipo { get; set; }

        public Curso()
        {
            id = System.Guid.NewGuid().ToString();
        }
    }
}