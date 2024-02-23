public class Rationnel
{
    public int Numerateur { get; set; }
    public int Denominateur { get; set; }
    public Rationnel(int num, int denom)
    {
        Numerateur = num;
        Denominateur = denom;
    }

    public override string ToString()
    {
        string message = $"{Numerateur} / {Denominateur}";
    }

    public Rationnel Ajouter(Rationnel r, int nb)
    {
        r.Denominateur = r.Denominateur + nb * r.Denominateur;
        return r;
    }

    public Rationnel Soustraire(Rationnel r, int nb)
    {
        r.Numerateur = r.Numerateur - nb * r.Denominateur;
        return r;
    }

}