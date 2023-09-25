using QuizApp.DataAccess;
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
using System.Windows.Shapes;
using System.Windows.Shell;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for ViewCollection.xaml
    /// </summary>
    public partial class ViewCollection : Window
    {
        List<Category> categories;
        MainDAO dao;
        QuizAppContext context;
        ObservableCollection<QuizCollection> quizCollections;

        public ViewCollection()
        {
            InitializeComponent();
            dao = new MainDAO();
            context = new QuizAppContext();
            quizCollections = new ObservableCollection<QuizCollection>();
            categories = context.Categories.ToList();
            categories.Add(new Category { Id = -1, Content = "All" });
            cmbCategory.ItemsSource = categories;
            cmbCategory.DisplayMemberPath = "Content"; // Hiển thị giá trị của thuộc tính Content
            cmbCategory.SelectedValuePath = "Id"; // Chọn giá trị của thuộc tính Id khi người dùng chọn một mục trong ComboBox
            LoadView(string.Empty, -1);
        }

        private void cmbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Nếu người dùng chọn "All" thì hiển thị All
            Category selectedCategory = (Category)cmbCategory.SelectedItem;
            LoadView(string.Empty, selectedCategory.Id);
        }

        public void LoadView(string strSearch, int? categoryID)
        {
            List<QuizCollection> qcs = context.QuizCollections.ToList();
            if (categoryID != null && categoryID != -1)
            {
                qcs = qcs.Where(item => item.CategoryId == categoryID).ToList();
            }

            if (!string.IsNullOrEmpty(strSearch))
            {
                qcs = qcs.Where(item => item.Title.Contains(strSearch)).ToList();
            }
            quizCollections = new ObservableCollection<QuizCollection>(qcs);
            
            lvCollection.ItemsSource = quizCollections;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Category selectedCategory = (Category)cmbCategory.SelectedItem;
            LoadView(txtSearch.Text, selectedCategory.Id);
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            // Lấy button "View" được bấm
            var button = sender as Button;

            // Lấy hàng (item) tương ứng với button "View" được bấm
            if (button?.DataContext is QuizCollection quizCollection)
            {
                int quizCollectionId = quizCollection.Id;
                ViewQuiz viewQuiz = new ViewQuiz(quizCollectionId);
                viewQuiz.Show();
                this.Close();
            }
        }

        private void btnToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btnDelCategory_Click(object sender, RoutedEventArgs e)
        {
            Category selectedCategory = (Category)cmbCategory.SelectedItem;
            if (selectedCategory == null || selectedCategory.Id == -1)
            {
                MessageBox.Show("Please choose an category to delete", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBoxResult result = MessageBox.Show("Are you want do delete this category? All collection will be delete.", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
            List<QuizCollection> qcs = context.QuizCollections.Where(item => item.CategoryId == selectedCategory.Id).ToList();
            
            // Kiểm tra kết quả của MessageBox
            if (result == MessageBoxResult.Yes)
            {
                // Người dùng chọn Yes
                foreach(var quizCollection in qcs)
                {
                    List<Quiz> quizzes = context.Quizzes.Where(item => item.CollectionId == quizCollection.Id).ToList();
                    foreach (var quiz in quizzes)
                    {
                        List<Answer> answers = context.Answers.Where(item => item.QuizId == quiz.Id).ToList();
                        context.Answers.RemoveRange(answers);
                        context.Quizzes.Remove(quiz);
                    }
                    context.QuizCollections.Remove(quizCollection);
                }
                context.Categories.Remove(selectedCategory);
                context.SaveChanges();
            }
            
            ViewCollection viewCollection = new ViewCollection();
            viewCollection.Show();
            this.Close();

            //else if (result == MessageBoxResult.No)
            //{

            //}
        }
    }
}
