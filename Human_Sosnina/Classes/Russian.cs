using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Human_Sosnina.Classes
{
    public class Russian : Human
    {
        List<Phrase> Phrases {  get; set; }
        int stepAudio;
        int StepAudio
        {
            get
            {
                return stepAudio;
            }
            set
            {
                stepAudio = value;
                if (stepAudio > Phrases.Count - 1)
                {
                    stepAudio = 0;
                }
            }
        }

        public Russian(string name, string img) : base(name, img)
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

            allPhrases.Add(new Phrase("Привет", @"Human_Sosnina\\Human_Sosnina\\Voices\\Привет.mp3"));
            allPhrases.Add(new Phrase("Как дела?", @"Human_Sosnina\\Human_Sosnina\\Voices\\Как дела.mp3"));
            allPhrases.Add(new Phrase("Меня зовут Александр", @"Human_Sosnina\\Human_Sosnina\\Voices\\Меня зовут.mp3"));

            return allPhrases;
        }
    }
}
