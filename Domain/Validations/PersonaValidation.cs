using Entities;

namespace Domain.Validations
{
    internal class PersonaValidation
    {
        public bool isValid(Persona? persona)
        {
            if (persona == null) throw new Exception("Los datos de la persona son obligatorios.");
            if (String.IsNullOrEmpty(persona.nombre)) throw new Exception("El nombre es requerido.");
            if (String.IsNullOrEmpty(persona.apellido)) throw new Exception("El apellido es requerido.");
            if (String.IsNullOrEmpty(persona.direccion)) throw new Exception("La direccion es requerida.");
            if (String.IsNullOrEmpty(persona.email)) throw new Exception("El email es requerido.");
            if (String.IsNullOrEmpty(persona.telefono)) throw new Exception("El telefono es requerido.");
            if (persona.fecha_nac == null || persona.fecha_nac == DateTime.MinValue)
                throw new Exception("La fecha de nacimiento es requerida.");

            return true;
        }
    }
}
