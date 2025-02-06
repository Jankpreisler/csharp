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
using System.Windows.Shapes;

namespace Pokemon_Fight.Windows
{
    /// <summary>
    /// Interaction logic for Window_PokemonBattle.xaml
    /// </summary>
    public partial class Window_PokemonBattle : Window
    {
        public GameEngine GameEngine { get; set; } = new GameEngine();
        public Window_PokemonBattle()
        {
            InitializeComponent();
            RefresElements();
          
        }
        private void RefresElements() 
        {
            ProgressBar_Pokemon1_HP.Value = GameEngine.FirstPokemon.Health;
            label_Pokemon_1HP.Content = $" {GameEngine.FirstPokemon.Health} / 100";

            ProgressBar_Pokemon_2HP.Value = GameEngine.LastPokemon.Health;
            label_Pokemon_2HP.Content = $" {GameEngine.LastPokemon.Health} / 100";

        }
        private void AIAtack()
        {
            Random rnd = new Random();
            var value = rnd.Next(0, 99);

            if (value < 33)
            {
                var damage = GameEngine.LastPokemon.Attack();
                var pokemonSurvive = GameEngine.FirstPokemon.TakeDamage(damage);


            }
            else if (value > 33 && value < 90)
            {
                var damage = GameEngine.LastPokemon.Attack2();
                var pokemonSurvive = GameEngine.FirstPokemon.TakeDamage(damage);


            }
            else if (value > 90) 
            {
                var damage = GameEngine.LastPokemon.Attack3();
                var pokemonSurvive = GameEngine.FirstPokemon.TakeDamage(damage);
            }                                           
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack();
            var pokemonSurvive = GameEngine.LastPokemon.TakeDamage(damage);

            /*var damage1 = GameEngine.LastPokemon.Attack();
            var pokemonSurvive1 = GameEngine.FirstPokemon.TakeDamage(damage1);*/

            AIAtack();

            RefresElements();
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack2();
            var pokemonSurvive = GameEngine.LastPokemon.TakeDamage(damage);

            AIAtack();

            RefresElements();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack3();
            var pokemonSurvive = GameEngine.LastPokemon.TakeDamage(damage);

            AIAtack();

            RefresElements();

        }
    }
}
