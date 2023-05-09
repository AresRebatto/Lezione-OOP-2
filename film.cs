
class Film
{
    // Attributi
    
    private string nome{get;set;}  //Volendo si può omettere private perché è sottinteso
    private int durata {get;set;}
    private string genere {get;set;}
    private int vendite {get;set;}
    private List<string> recensioni;

    public Film(string nome, int durata, string genere, int vendite)//Costruttore della classe: prende i pezzi e costruisce l'oggetto
    {
        this.nome=nome;
        this.durata=durata;
        this.genere=genere;
        this.vendite=vendite;
        this.recensioni = new List<String>();
    }
    
    public Film(string nome, int durata, string genere)//Overloading: sono ammessi più costruttori a patto che abbiano una firma(ovvero richiedano parametri) differenti
    {
        this.nome=nome;
        this.durata=durata;
        this.genere=genere;
        this.recensioni = new List<String>();
    }

    public void ViusalizzaInfo ()
    {
        Console.WriteLine($"nome: {nome}\ndurata: {durata}\ngenere: {genere}\nvendite: {vendite}");
        foreach (var recensione in  recensioni )
        {
            Console.WriteLine(recensione);
        }
    }
     
    public void AggiungiRecensione(string recensione)
    {
        recensioni.Add(recensione);
    }   
}