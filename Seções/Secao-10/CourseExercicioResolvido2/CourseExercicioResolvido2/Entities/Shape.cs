using CourseExercicioResolvido2.Entities.Enums;

namespace CourseExercicioResolvido2.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }
        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
    }
}
