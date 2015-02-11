using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Data.Entity;
using WaitForIt.Model;
using WaitForIt.Repository;
using WaitForIt;


namespace WaitForIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public ObservableCollection<Event> Events;
        //public static EventContext _dbContext;
        public static EventRepository repo = new EventRepository();
        public MainWindow()
        {
           InitializeComponent();
           CountdownList.DataContext = repo.Context().Events.Local;
           if(repo.GetCount() > 1){
               HideHelpMessages();
           }
        }

        private void HideHelpMessages()
        {
            GettingStartedText.Visibility = Visibility.Hidden;
            GettingStartedArrow.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewEventForm.Visibility = Visibility.Visible;
            EventDate.SelectedDate = DateTime.Today.AddDays(30);
            Add.IsEnabled = false;
            HideHelpMessages();
        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            NewEventForm.Visibility = Visibility.Collapsed;
            repo.Add(new Event(EventTitle.Text, EventDate.SelectedDate.ToString()));
        }
    }
}
