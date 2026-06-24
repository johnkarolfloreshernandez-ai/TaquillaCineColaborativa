using TaquillaCineColaborativa;

namespace TaquillaCineWinForms
{
    public class BoletoGeneral : Boleto
    {
        public BoletoGeneral(float precioBase)
            : base(precioBase)
        {
        }

        public override float CalcularPrecioFinal()
        {
            return PrecioBase;
        }
    }
}