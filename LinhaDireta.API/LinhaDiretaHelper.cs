using LinhaDireta.Dados.Context;

namespace LinhaDireta.API;

public class LinhaDiretaHelper
{
    private static readonly Random random = new();

    public static string GerarProtocolo(AppDbContext _context)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string protocolo;

        do
        {
            char[] stringAleatoria = new char[12];

            for (int i = 0; i < 12; i++)
            {
                stringAleatoria[i] = chars[random.Next(chars.Length)];
            }

            protocolo = new string(stringAleatoria);

        } while (_context.LinhaDireta.Any(ld => ld.Protocolo == protocolo));

        return protocolo;
    }
}
