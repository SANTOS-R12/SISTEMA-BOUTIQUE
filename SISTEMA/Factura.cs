using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    public class Factura
    {
        string nombreComprador;
        string listCompras;
        string precioTotal;
        string pagado;
        string restante;

        public Factura(string nombreComprador, string listCompras, string precioTotal, string pagado, string restante)
        {
            this.nombreComprador = nombreComprador;
            this.listCompras = listCompras;
            this.precioTotal = precioTotal;
            this.pagado = pagado;
            this.restante = restante;
        }

        public string NombreComprador { get => nombreComprador; set => nombreComprador = value; }
        public string ListCompras { get => listCompras; set => listCompras = value; }
        public string PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string Pagado { get => pagado; set => pagado = value; }
        public string Restante { get => restante; set => restante = value; }
    }
}
