
namespace Pokemones
{
    public class Pokemon
    {

        #region Atributos
        private string nombre;
        private string tipo;
        private byte nivel;
        private string debilidad;
        private bool sexo;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public byte Nivel { get => nivel; set => nivel = value; }
        public string Debilidad { get => debilidad; set => debilidad = value; }
        public bool Sexo { get => sexo; set => sexo = value; }
        #endregion

        #region Constructor
        public Pokemon(string nombre, string tipo, byte nivel, string debilidad, bool sexo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Nivel = nivel;
            Debilidad = debilidad;
            Sexo = sexo;
        }
        #endregion

    }
}
