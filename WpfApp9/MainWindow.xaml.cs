using System.Collections;
using System.Windows;

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("a");
            lvEntries.Items.Add("b");
            lvEntries.Items.Add("c");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
/*            int index = lvEntries.SelectedIndex;
 *            
*/        
          // object item= lvEntries.SelectedItem;
          var items = lvEntries.SelectedItems;
          var result = MessageBox.Show($"Are you sure you want to delete:{items.Count} items?","Sure?",MessageBoxButton.YesNo);
          if (result == MessageBoxResult.Yes)
            {
                var itemList = new ArrayList(items); 
                foreach (var item in itemList)
                
                    lvEntries.Items.Remove(item);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}