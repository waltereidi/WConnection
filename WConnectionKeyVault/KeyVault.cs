namespace WConnectionKeyVault
{
    public static class KeyVault
    {
        public static string GetConnectionString(this string? solution)
        {
            if (solution == "loja.Infra")
                return "Server=MWALTR;Database=loja;Trusted_Connection=True;TrustServerCertificate=True;User Id=sa;Password=123";

            return null;
        }
    }
}