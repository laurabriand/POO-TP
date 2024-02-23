using System.Security.Cryptography.X509Certificates;

public class Etudiant
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string? Login { get; }
    public Etudiant(string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom;
        Login = GenererLogin(nom, prenom);
    }

    public Etudiant(string nom, string prenom, string login)
    {
        Nom = nom;
        Prenom = prenom;
        Login = login;
    }

    public string GenererLogin(string nom, string prenom)
    {
        if (nom == "" || prenom == "")
        {
            string login = "inconnu";
            return login;
        }
        else
        {
            string login = $"{prenom[0]}{nom.ToLower()}";
            return login;
        }


    }

    public override string ToString()
    {
        if (Login == null)
        {
            string message = $"Nom : {Nom}, Prenom: {Prenom}\n";
            return message;
        }
        else
        {
            string message = $"Nom : {Nom}, Prenom: {Prenom}, login: {Login}\n";
            return message;
        }
    }
}