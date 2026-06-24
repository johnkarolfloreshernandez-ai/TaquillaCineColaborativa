using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaquillaCineColaborativa
{
    internal class BoletoAdultoMayor : Boleto
    {
        // Atributo específico requerido
        public string NumCredencialInapam { get; set; }

        // Constructor
        public BoletoAdultoMayor(string numCredencialInapam)
        {
            NumCredencialInapam = numCredencialInapam;
        }

        // Descuento del 50%
        public override float CalcularPrecioFinal()
        {
            return PrecioBase * 0.50f;
        }

        // Mostrar información del boleto
        public override string ObtenerInformacion()
        {
            return "credencial INAPAM: " + NumCredencialInapam + "\n precio base: " + precioBase + "\n precio final: " + CalcularPrecioFinal();
        }
    }
}