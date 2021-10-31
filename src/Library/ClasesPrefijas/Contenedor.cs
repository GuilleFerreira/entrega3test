using System.Collections.Generic;

namespace Library
{
    public class Contenedor
    {
        private List<Habilitacion> habilitaciones = new List<Habilitacion>();

        public List<Habilitacion> Habilitaciones 
        {
            get{
                return this.habilitaciones;
            }
            set{
                this.habilitaciones=value;
            }
        }
        private List<Rubro> rubros = new List<Rubro>();
        public List<Rubro> Rubros
        {
            get{
                return this.rubros;
            }
            set{
                this.rubros=value;
            }
        }
        private List<Clasificacion> clasificaciones = new List<Clasificacion>();
        public List<Clasificacion> Clasificaciones
        {
            get{
                return this.clasificaciones;
            }
            set{
                this.clasificaciones=value;
            }
        }

        public void AddHabilitacion(string name, string descripcion)
        {
            Habilitacion habilitacion = new Habilitacion(name,descripcion);
            this.Habilitaciones.Add(habilitacion);
        }

        public void RemoveHabiltiacion(Habilitacion habilitacion)
        {
            this.Habilitaciones.Remove(habilitacion);
        }

        public void AddRubro(string nombre, string area, string descripcion)
        {
            Rubro rubro = new Rubro(nombre,area,descripcion);
            this.Rubros.Add(rubro);
        }
        public void RemoveRubro(Rubro rubro)
        {
            this.Rubros.Add(rubro);
        }
        
        public void AddClasificacion(string nombre, string descripcion)
        {
            Clasificacion clasificacion = new Clasificacion(nombre,descripcion);
            this.Clasificaciones.Add(clasificacion);
        }
        public void RemoveClasificacion(Clasificacion clasificacion)
        {
            this.Clasificaciones.Remove(clasificacion);
        }
    }
}