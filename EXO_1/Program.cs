// EXERCICE 1

Etudiant Nick = new Etudiant("Haragoua", "Nick");
Console.WriteLine(Nick);

Etudiant Agatha = new Etudiant("Filine", "Agatha", "Afiline");
Console.WriteLine(Agatha);

Etudiant Louis = new Etudiant("", "Louis");
Console.WriteLine(Louis);

List<Etudiant> etud = new List<Etudiant>();
etud.Add(Nick);
etud.Add(Agatha);

List<Etudiant> etud1 = new List<Etudiant>();

Enseignant e1 = new Enseignant("Durant", "histoire");
Enseignant e2 = new Enseignant("Durant", "geographie");
List<Enseignant> ens = new List<Enseignant>();
ens.Add(e1);
ens.Add(e2);
List<Enseignant> ens1 = new List<Enseignant>();

Promotion Cognitique = new Promotion("Cognitique", 2026, etud, ens);
Console.WriteLine(Cognitique);

Promotion NoName = new Promotion("NoName", 2099, etud1, ens1);
Console.WriteLine(NoName);
