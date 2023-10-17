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
using WpfAppDemo.Data;

namespace WpfAppDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{ Name = "Jan", Age = 33},
            new Person{ Name = "Anna", Age = 20},
            new Person{ Name = "Jola", Age = 25},
            new Person{ Name = "Tom", Age = 45},
            new Person{ Name = "Czesław", Age = 60},
        };

        //Person person = new Person
        //{
        //    Name = "Janek",
        //    Age = 33
        //};
        public MainWindow()
        {
            InitializeComponent();


            ListboxPeople.ItemsSource = People;


            //this.DataContext = person;

            /* BUTTON IN C#
             Button myButton = new Button(); ;
             myButton.Content = "B";

             Grid.SetRow(myButton, 3);
             Grid.SetColumn(myButton, 4);

             Grid myGrid = (Grid)FindName("myGrid");
             myGrid.Children.Add(myButton);*/

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    string personData = person.Name + " is " + person.Age + " years old";
        //    MessageBox.Show(personData);

        //}
    }
}
