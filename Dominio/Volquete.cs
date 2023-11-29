namespace Dominio
{
    public enum TipoDeVolquete
    {
        Pequeño,
        Mediano,
        Grande
    }
    [Serializable]
    public class Volquete
    {

        public int Id { get; set; }
        public int? IdAlquiler { get; set; }
        public double Tamaño { get; set; }

        public TipoDeVolquete Tipo { get; set; }



        public Volquete(int id, int idalquiler, double tamaño, TipoDeVolquete tipo)
        {
            this.Id = id;
            this.IdAlquiler = idalquiler;
            this.Tamaño = tamaño;
            this.Tipo = tipo;

        }
        public Volquete(int id, double tamaño, TipoDeVolquete tipo)
        {
            this.Id = id;
            this.Tamaño = tamaño;
            this.Tipo = tipo;

        }
        public Volquete(double tamaño, TipoDeVolquete tipo)
        {
            this.Tamaño = tamaño;
            this.Tipo = tipo;

        }

        public override string ToString()
        {
            return $"{Tipo}";
        }


    }
}
