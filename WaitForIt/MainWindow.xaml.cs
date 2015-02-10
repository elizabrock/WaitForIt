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
using WaitForIt.Model;
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
        public MainWindow()
        {
            using(var _dbContext = new EventContext())
            {
                _dbContext.Events.Add(new Event("New Year's Eve", "12/31/2015"));
                _dbContext.Events.Add(new Event("Birthday", "12/25/2015"));
                _dbContext.SaveChanges();
                //Events = new ObservableCollection<Event>();
            }
                InitializeComponent();
                //CountdownList.DataContext = _dbContext.Events.Local;
            // _dbContext.Events.Add(......) == _dbContext.Events.Local.Add(.....) == (new ObservableCollection<Event>()).Add(....)

        }
    }
}
