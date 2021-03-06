//--------------------------------------------------------------------------------
// <copyright file="Usuario.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    /// <summary>
    /// Esta clase representa un usuario de la aplicación.
    /// Es una clase abstracta, por lo que no puede ser instanciada.
    /// Representa a un usuario de la aplicación de manera general.
    /// </summary>
    public abstract class Usuario
    {
        private Collection<OfertaBase> registroUsuario = new Collection<OfertaBase>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Usuario"/>.
        /// </summary>
        /// <param name="nombre">parametro nombre recibido por el constructor del usuario.</param>
        /// <param name="rubro">parametro rubro recibido por el constructor del usuario.</param>
        /// <param name="ciudad">parametro ciudad recibido por el constructor del usuario.</param>
        /// <param name="calle">parametro calle recibido por el constructor del usuario.</param>
        protected Usuario(string nombre, Rubro rubro, string ciudad, string calle)
        {
            if (nombre == null)
            {
                throw new ArgumentNullException("name");
            }
            if (nombre.Length == 0)
            {
                throw new ArgumentException("El nombre no puede estar vacio");
            }

            Ubicacion ubicacion = new Ubicacion(ciudad, calle);
            this.Ubicacion = ubicacion;
            this.Nombre = nombre;
            this.Rubro = rubro;
        }

        /// <summary>
        /// Obtiene o establece un valor el nombre del usuario.
        /// </summary>
        /// <value>this.nombre.</value>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que es el rubro del usuario.
        /// </summary>
        /// <value>this.rubro.</value>
        public Rubro Rubro { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica la ubicacion del usuario.
        /// </summary>
        /// <value>this.ubicacion.</value>
        public Ubicacion Ubicacion { get; set; }

        /// <summary>
        /// Obtiene un valor que indica el registro del usuario.
        /// </summary>
        /// <value>this.registroUsuario.</value>
        public Collection<OfertaBase> RegistroUsuario
        {
            get
            {
                return this.registroUsuario;
            }
        }

        /// <summary>
        /// Añiade al registro del usuario la oferta.
        /// </summary>
        /// <param name="oferta">Parametro.</param>
        public void AddToRegister(OfertaBase oferta)
        {
            this.registroUsuario.Add(oferta);
        }

        /// <summary>
        /// Busca en el registro del usuario.
        /// </summary>
        /// <param name="fechaDesde">Parametro que indica la fechaDesde donde se desea buscar.</param>
        /// <returns>una lista de ofertas llamada resultado.</returns>
        public Collection<OfertaBase> BuscarEnRegistro(DateTime fechaDesde)
        {
            Collection<OfertaBase> resultado = new Collection<OfertaBase>();
            foreach (OfertaBase oferta in this.registroUsuario)
            {
                if (oferta.FechaVenta.Date >= fechaDesde.Date)
                {
                    resultado.Add(oferta);
                }
            }

            return resultado;
        }
    }
}