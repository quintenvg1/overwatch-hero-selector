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

namespace overwatch_random_hero_selector_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public int randomizer()
        {
            int hero;
            Random B = new Random();
            // set to 1, 27 after new hero update alle cijfers excluding 26
            hero = B.Next(1, 29);
            return hero;
          
        }

        //update brigitte added 24/4/18
        //add ashe
        //add wrecking ball 10/1/2019
        public string Decoder(int A)
        {
            
            if (A == 1)
            {
                
                return "Doomfist";
            }
            if (A == 2)
            {
                
                return "Genji";
            }
            if (A == 3)
            {
                return "Mccree";
            }
            if (A == 4)
            {
                return "Pharah";
            }
            if (A == 5)
            {
                return "Reaper";
            }
            if (A == 6)
            {
                return "Soldier 76";
            }
            if (A == 7)
            {
                return "Sombra";
            }
            if (A == 8)
            {
                return "Tracer";
            }
            if (A == 9)
            {
                return "Bastion";
            }
            if (A == 10)
            {
                return "Hanzo";
            }
            if (A == 11)
            {
                return "Junkrat";
            }
            if (A == 12)
            {
                return "Mei";
            }
            if (A == 13)
            {
                return "Torbjörn";
            }
            if (A == 14)
            {
                return "Widowmaker";
            }
            if (A == 15)
            {
                return "D.va";
            }
            if (A == 16)
            {
                return "Orisa";
            }
            if (A == 17)
            {
                return "Reinhardt";
            }
            if (A == 17)
            {
                return "Roadhog";
            }
            if (A == 18)
            {
                return "Winston";
            }
            if (A == 19)
            {
                return "Zarya";
            }
            if (A == 20)
            {
                return "Ana";
            }
            if (A == 21)
            {
                return "lúcio";
            }
            if (A == 22)
            {
                return "Mercy";
            }
            if (A == 23)
            {
                return "Moira";
            }
            if (A == 24)
            {
                return "Symmetra";
            }
            if (A == 25)
            {
                return "Zenyatta";
            }
            if (A == 26)
            {
                return "Brigitte";
            }
            if (A == 27)
            {
                return "Wrecking Ball";
            }
            if (A == 28)
            {
                return "Ashe";
            }
         
            // if all fails no hero string will return
            return "no hero";

        }

        private void _1hero_Click(object sender, RoutedEventArgs e)
        {
            //functie om een hero te kiezen, returns a number between 1 and 27 inc 1 and 27
            // funtion to choose a hero
            int hero1 = randomizer();
            //stuurt het cijfer van de hero door naar de functie en decodeerd deze door if statements.
            // sends the number of the hero to the decoder function which return a name based on this number.
           herolabel1.Content = Convert.ToString(Decoder(hero1));
            // works for a single hero
            
        }

        private void _3hero_Click(object sender, RoutedEventArgs e)
        {
            int hero1 = randomizer();
            int hero2 = randomizer();
            int hero3 = randomizer();
            // code underneath solves the 'duplicates' problem
            //ervoor zorgen dat er geen dubbels in de selectie komen, door de dubbels opnieuw te laten randomizen kan het soms even duren voor de selectie gemaakt is.
            while (hero1 == hero2)
            {
                hero2 = randomizer();
            }
            while (hero3 == hero2 || hero3 == hero1)
            {
                hero3 = randomizer();
            }

            herolabel1.Content = Convert.ToString(Decoder(hero1));
            herolabel2.Content = Convert.ToString(Decoder(hero2));
            herolabel3.Content = Convert.ToString(Decoder(hero3));


        }

        private void _6hero_Click(object sender, RoutedEventArgs e)
        {
            int hero1 = randomizer();
            int hero2 = randomizer();
            int hero3 = randomizer();
            int hero4 = randomizer();
            int hero5 = randomizer();
            int hero6 = randomizer();

            while (hero1 == hero2)
            {
                hero2 = randomizer();
            }
            while (hero3 == hero2 || hero3 == hero1)
            {
                hero3 = randomizer();
            }
            while (hero4 == hero3 || hero4 == hero2 || hero4 == hero1)
            {
                hero4 = randomizer();
            }
            while (hero5 == hero4 || hero5 == hero3 || hero5 == hero2 || hero5 == hero1)
            {
                hero5 = randomizer();
            }
            while (hero6 == hero5 || hero6 == hero4 || hero6 == hero3 || hero6 == hero3 || hero6 == hero2 || hero6 == hero1)
            {
                hero6 = randomizer();
            }
            //integrated code against duplicates
            herolabel1.Content = Convert.ToString(Decoder(hero1));
            herolabel2.Content = Convert.ToString(Decoder(hero2));
            herolabel3.Content = Convert.ToString(Decoder(hero3));
            herolabel4.Content = Convert.ToString(Decoder(hero4));
            herolabel5.Content = Convert.ToString(Decoder(hero5));
            herolabel6.Content = Convert.ToString(Decoder(hero6));

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            // makes the close button work
            Environment.Exit(0);
        }
    }
}
