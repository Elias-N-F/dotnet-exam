namespace DotnetExam.Entities
{
    public class Alumno: Persona
    {
        public int AlumnoId { get; set; }
        public string Legajo { get; set; }

        public Alumno()
        {
            
        }

        public Alumno(int id, string legajo)
        {
            Id = id;
            AlumnoId = id;
            Legajo = legajo;
        }

    }
}