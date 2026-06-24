using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaquillaCineColaborativa
{
    public abstract class Boleto
    {

        public float precioBase;
        // Precio base fijo de $80.00
        protected float PrecioBase
        {
            get {  return precioBase; }
            set { precioBase = value; }

        }
        public Boleto()
        {
            this.precioBase = 80.00f;
        }
       

        // Método abstracto que cada subclase debe implementar
        public abstract float CalcularPrecioFinal();

        // Método virtual opcional para mostrar información
        public virtual string ObtenerInformacion()
        {
            return $"Precio base: ${PrecioBase:F2}";
        }
    }

}
