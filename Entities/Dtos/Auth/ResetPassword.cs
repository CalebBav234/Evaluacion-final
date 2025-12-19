namespace ProyectoFinalTecWeb.Entities.Dtos.Auth
{
    public class ResetPassword
    {
        public string token { get; set; } = string.Empty;
        public string newPassword { get; set; } = string.Empty;
    }
}
