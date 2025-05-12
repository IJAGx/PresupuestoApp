using System.Collections.Generic;

namespace PresupuestoApp.Models
{
    public class PresupuestoViewModel
    {
        public string NombreUsuario { get; set; }

        // Ingresos
        public decimal IngresoPrevistoPrincipal { get; set; }
        public decimal IngresoPrevistoAdicional { get; set; }
        public decimal IngresoRealPrincipal { get; set; }
        public decimal IngresoRealAdicional { get; set; }

        // Gastos principales
        public decimal Alquiler { get; set; }
        public decimal Electricidad { get; set; }
        public decimal Agua { get; set; }
        public decimal Gas { get; set; }
        public decimal AyudanteHogar { get; set; }
        public decimal Colegio { get; set; }
        public decimal DespensaFija { get; set; }
        public decimal InternetHogar { get; set; }
        public decimal Telefono { get; set; }

        // Gastos personales
        public decimal Ahorros { get; set; }
        public decimal Estudios { get; set; }
        public decimal Peluqueria { get; set; }
        public decimal Gimnasio { get; set; }
        public decimal TransporteLaboral { get; set; }
        public decimal TransporteExtra { get; set; }
        public decimal PagoVehiculo { get; set; }
        public decimal Combustible { get; set; }
        public decimal MesadaPadres { get; set; }
        public decimal MesadaHijos { get; set; }

        // Prestamos
        public decimal Prestamo1 { get; set; }
        public decimal Prestamo2 { get; set; }
        public decimal PrestamoEstudiantil { get; set; }
        public decimal TarjetaCredito1 { get; set; }
        public decimal TarjetaCredito2 { get; set; }

        // Entretenimiento
        public decimal Streaming { get; set; }
        public decimal Salidas { get; set; }
        public decimal Restaurantes { get; set; }
        public decimal DespensaExtra { get; set; }
    }
}
