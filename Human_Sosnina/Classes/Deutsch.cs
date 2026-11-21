using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Human_Sosnina.Classes
{
    public class Deutsch : Human
    {
        List<Phrase> Phrases { get; set; }
        private int stepAudio;
        private int StepAudio
        {
            get
            {
                return stepAudio;
            }
            set
            {
                stepAudio = value;
                if (StepAudio > Phrases.Count - 1)
                    stepAudio = 0;
            }
        }

        public Deutsch(string name, string img) : base(name, img)
        {
            this.Phrases = AllPhrases();
        }

        public override void Speak(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src));
            MainWindow.MediaPlayer.Play();

            StepAudio++;
        }

        private List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();

            allPhrases.Add(new Phrase("Hallo", @"C:\Users\Student-A502.PERMAVIAT\Source\Repos\MDK_01_01_sosnina_diana_10\Human_Sosnina\Voices\Hallo.mp3"));
            allPhrases.Add(new Phrase("Wie geht ' s?", @"C:\Users\Student-A502.PERMAVIAT\Source\Repos\MDK_01_01_sosnina_diana_10\Human_Sosnina\Voices\Wie geht s.mp3"));
            allPhrases.Add(new Phrase("Mein Name ist Leia", @"C:\Users\Student-A502.PERMAVIAT\Source\Repos\MDK_01_01_sosnina_diana_10\Human_Sosnina\Voices\Mein Name ist Leia.mp3"));

            return allPhrases;
        }
    }
}
