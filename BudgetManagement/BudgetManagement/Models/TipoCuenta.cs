namespace BudgetManagement.Models
{
    public class TipoCuenta
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public int usuarioID { get; set; }
        public int orden { get; set; }
    }
}
