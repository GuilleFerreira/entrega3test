using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Esta clase representa una oferta.
    /// </summary>
    public class Oferta : OfertaBase
    {
        /// <summary>
        /// Obtiene o establece cuando la oferta va a ser generada.
        /// </summary>
        /// <value></value>
        public DateTime FechadeGeneracion { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="OfertaRecurrente"/>.
        /// </summary>
        /// <param name="nombreoferta">parametro nombre de la oferta.</param>
        /// <param name="empresa">parametro empresa que oferta.</param>
        /// <param name="ciudad">ciuadad donde se encuentra la oferta.</param>
        /// <param name="calle">callle donde se encuentra la oferta.</param>
        /// <param name="nombreMaterial">nombre del material donde se encuentra la oferta.</param>
        /// <param name="clasificacion">clasificacion del material.</param>
        /// <param name="cantidad">cantidad del material.</param>
        /// <param name="unidad">unidad del material.</param>
        /// <param name="valor">valor del material.</param>
        /// <param name="fechaDeGeneracion">cuando se genera la oferta.</param>
        public Oferta(string nombreoferta, Empresa empresa, string ciudad, string calle, 
        string nombreMaterial ,Clasificacion clasificacion,
        int cantidad, string unidad, double valor, DateTime fechaDeGeneracion) 
        : base(nombreoferta, empresa, ciudad, calle, nombreMaterial, clasificacion, cantidad, unidad, valor)
        {
            this.FechadeGeneracion = fechaDeGeneracion;
        }
    }
}