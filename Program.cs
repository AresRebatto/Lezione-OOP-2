Console.WriteLine("inserisci il nome del film");
string nome = Console.ReadLine();
Console.WriteLine("inserisci la durata del film");
int durata=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("inserisci il genere del film");
string genere = Console.ReadLine();
Console.WriteLine("inserisci la vendita del film");
int vendita=Convert.ToInt32(Console.ReadLine());

Film qualcosa = new Film(nome,durata,genere,vendita);
Film qualcosa2 = new Film("La storia dei sassi 2",2,"azione");


qualcosa2.ViusalizzaInfo();
qualcosa2.AggiungiRecensione("il film e' bello ma risulta noioso a causa della sua esagerata lunghezza pesonalmente avrei aggiunto piu scene di sesso per lomeno non ci si addormentava sulla sedia");
// approvato dai migliroi critici tal critica 