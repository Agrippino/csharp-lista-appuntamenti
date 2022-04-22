using ListaAppuntamenti;

//creo una lista//
List<Appuntamento> listaDeiMieiAppuntamenti = new List<Appuntamento>();

Console.WriteLine("Quanti Appuntamenti vuoi inserire?");
int numeroDiAppuntamenti = int.Parse(Console.ReadLine());


for (int i = 0; i < numeroDiAppuntamenti; i++)
{
    Console.WriteLine("Ciao, sono il tuo aiutante per la tua agenda personale \n");
    Console.WriteLine("Inserisci qui il nome della persona che incontrerai");
    string nome = Console.ReadLine();
    Console.WriteLine("Inserisci qui la località del tuo appuntamento");
    string localita = Console.ReadLine();
    
    bool controlloData = false;
    while (controlloData == false)
    {
        try
        {
            Console.WriteLine("Inserisci qui la data del tuo incontro in forma numerica");
            DateTime data = DateTime.Parse(Console.ReadLine());

            listaDeiMieiAppuntamenti.Add(new Appuntamento(nome, localita, data));

            controlloData = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
try
{
    Console.WriteLine("inserisci l'indice che vuoi cambiare");
    int indiceAppuntamenti = int.Parse(Console.ReadLine());
    listaDeiMieiAppuntamenti[indiceAppuntamenti].modificaLaData();
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}


foreach (Appuntamento ogniAppuntameto in listaDeiMieiAppuntamenti)
{
    ogniAppuntameto.ToString();
}


