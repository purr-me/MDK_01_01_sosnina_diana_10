using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Human_Sosnina.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Classes.Human Human;
        public Item(object Data)
        {
            InitializeComponent();
            this.Human = Data as Classes.Human;

            Img.Source = new BitmapImage(new Uri(this.Human.Img));
            lName.Content = this.Human.Name;
            lRace.Content = Data.GetType().Name;
        }

        private void Speak(object sender, MouseButtonEventArgs e) =>
            Human.Speak(lText);

    }
}
