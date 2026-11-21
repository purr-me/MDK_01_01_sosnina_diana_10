using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Human_Sosnina.Classes
{
    public class Russian : Human
    {
        List<Phrase> Phrases {  get; set; }
        public int StepAudio = 0;


        public Russian(string name, string img) : base(name, img)
        {
            this.Phrases = AllPhrases();
        }

        public override void Speak(Label Phrase)
        {
            if (Phrases.Count == 0) return;

            if (StepAudio >= Phrases.Count)
            {
                StepAudio = 0;
            }

            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src));
            MainWindow.MediaPlayer.Play();

            StepAudio++;
        }

        private List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();

            allPhrases.Add(new Phrase("Привет", @"C:\Users\Student-A502.PERMAVIAT\Source\Repos\MDK_01_01_sosnina_diana_10\Human_Sosnina\Voices\Привет.mp3"));
            allPhrases.Add(new Phrase("Как дела?", @"C:\Users\Student-A502.PERMAVIAT\Source\Repos\MDK_01_01_sosnina_diana_10\Human_Sosnina\Voices\Как дела.mp3"));
            allPhrases.Add(new Phrase("Меня зовут Александр", @"C:\Users\Student-A502.PERMAVIAT\Source\Repos\MDK_01_01_sosnina_diana_10\Human_Sosnina\Voices\Меня зовут.mp3"));

            return allPhrases;
        }
    }
}
