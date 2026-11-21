using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Human_Sosnina.Classes
{
    public class English : Human
    {
        List<Phrase> Phrases { get; set; }
        public int StepAudio = 0;

        public English(string name, string img) : base(name, img)
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

            allPhrases.Add(new Phrase("Hello", @"C:\Users\Student-A502.PERMAVIAT\Source\Repos\MDK_01_01_sosnina_diana_10\Human_Sosnina\Voices\Hello.mp3"));
            allPhrases.Add(new Phrase("How are you?", @"C:\Users\Student-A502.PERMAVIAT\Source\Repos\MDK_01_01_sosnina_diana_10\Human_Sosnina\Voices\How are you.mp3"));
            allPhrases.Add(new Phrase("My name is Alexander", @"C:\Users\Student-A502.PERMAVIAT\Source\Repos\MDK_01_01_sosnina_diana_10\Human_Sosnina\Voices\My name is Alexander.mp3"));

            return allPhrases;
        }
    }
}
