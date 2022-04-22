

namespace ListaAppuntamenti
{
    internal class Appuntamento
    //variabili//
    {
        private protected string nome { get; set; }
        private protected string localita { get; set; }

        private protected DateTime dataAppuntamento = new DateTime();

        private protected DateTime dataAttuale = DateTime.Now;

        public Appuntamento(string nome, string localita, DateTime dataAppuntamento)
        {
            this.nome = nome;
            this.localita = localita;
            this.dataAppuntamento = dataAppuntamento;
           

            //verifichiamo de la data del'appuntamento sia pi vecchia di oggi 
            if (dataAppuntamento < dataAttuale)
            {
                throw new Exception("La data è sbaglaita");
            }
        }

        //metodi//
        public virtual void ToString()
        {
            // string ConsoleWriteLine = "";

            Console.WriteLine("---La tua agenda--- \n"); 
            Console.WriteLine("Nome della persona con cui hai l'appuntamento" + this.nome + "\n");
            Console.WriteLine("Località del tuo appuntamento" + this.localita + "\n");
            Console.WriteLine("Data del tuo appuntamento" + this.dataAppuntamento + "\n");

            //return formDellaAgenda;
        }

        public DateTime modificaLaData()
        {
                Console.WriteLine("Perfetto,qual è la nuova data ?");
           
            DateTime dataDaCambiare = DateTime.Parse(Console.ReadLine());
                dataAppuntamento = dataDaCambiare;
                if (dataAppuntamento < dataAttuale)
            {
                throw new Exception("La data è sbaglaita");
            }
            return dataAppuntamento;
        }
    }
    }


/*Console.WriteLine("Vuoi modificare l'appuntamento scirtto in passato? [sì/no]");
string rispostaUtente = Console.ReadLine();
switch (rispostaUtente)
{
    case "sì":*/

