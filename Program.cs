using System;

class ClassWithEvent
    {
        private string nameOfObjectWeCreated;

        public delegate void Delegate(string textWithName);
        public ClassWithEvent(string name)
        {
            nameOfObjectWeCreated = name;
        }
        public event Delegate Evento;
        public void attivazioneEConvalidaDellEEvento()
        {
            if (Evento != null)
            {
                Evento(nameOfObjectWeCreated);
            }
        }
    }
    class ClassForText
    {
        private string testo;
        public ClassForText(string annuncioImportante)
        {
            testo = annuncioImportante;
        }
        public void informazione(string nomeOgetto)
        {
            Console.WriteLine("Oggetto evento: " + nomeOgetto);
            Console.WriteLine("Testo: " + testo);
        }
    }
    class Program
    {
        static void Main()
        {
            ClassWithEvent experimento1 = new ClassWithEvent("Experimento numero uno");
            ClassWithEvent experimento2 = new ClassWithEvent("Experimento numero due");

            ClassForText textOfEvent = new ClassForText("I'm alive");

            experimento1.Evento += textOfEvent.informazione;
            experimento2.Evento += textOfEvent.informazione;

            experimento1.attivazioneEConvalidaDellEEvento();
            Console.WriteLine();

            experimento2.attivazioneEConvalidaDellEEvento();
            Console.WriteLine();
        }
    }
