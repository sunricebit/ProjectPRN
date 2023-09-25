using System.Windows;

namespace QuizApp
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

        private void btnCreateCollection_Click(object sender, RoutedEventArgs e)
        {
            AddQuizCollection addQuizCollection = new AddQuizCollection();
            addQuizCollection.Show();
            this.Close();
        }

        private void btnViewQuizCollection_Click(object sender, RoutedEventArgs e)
        {
            ViewCollection viewCollection = new ViewCollection();
            viewCollection.Show();
            this.Close();
        }
    }
}
