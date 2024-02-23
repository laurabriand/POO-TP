public class Promotion
{
    public string NomPromo { get; set; }
    public int Annee { get; set; }
    public List<Etudiant> Liste { get; set; }
    public List<Enseignant> ListeEnseignants { get; }
    public Promotion(string nomPromo, int annee, List<Etudiant> liste, List<Enseignant> listeEns)
    {
        NomPromo = nomPromo;
        Annee = annee;
        Liste = liste;
        ListeEnseignants = listeEns;
    }

    public override string ToString()
    {
        if (Liste == null)
        {
            string message1 = $"Promotion {NomPromo}, année {Annee}\nNombre d'étudiants : {Liste.Count}\n";
            if (ListeEnseignants == null)
            {
                message1 = message1 + $"Nombre d'enseignants : {ListeEnseignants.Count}\n";
                return message1;
            }
            else
            {
                message1 = message1 + $"Nombre d'enseignants : {ListeEnseignants.Count}\n";
                foreach (Enseignant enseignant in ListeEnseignants)
                {
                    message1 = message1 + $"- Nom : {enseignant.NomEnseignant}, discipline : {enseignant.Discipline}\n ";
                }
                return message1;
            }
        }
        else
        {
            string message = $"Promotion {NomPromo}, année {Annee}\nNombre d'étudiants : {Liste.Count}\n";
            foreach (Etudiant etud in Liste)
            {
                message = message + $"- Nom : {etud.Nom}, Prénom : {etud.Prenom}, login : {etud.Login}\n ";
            }
            if (ListeEnseignants == null)
            {
                message = message + $"Nombre d'enseignants : {ListeEnseignants.Count}\n";
                return message;
            }
            else
            {
                message = message + $"Nombre d'enseignants : {ListeEnseignants.Count}\n";
                foreach (Enseignant enseignant in ListeEnseignants)
                {
                    message = message + $"- Nom : {enseignant.NomEnseignant}, discipline : {enseignant.Discipline}\n ";
                }
                return message;
            }
        }

    }

}

