using QuizApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for AddQuizCollection.xaml
    /// </summary>
    public partial class AddQuizCollection : Window
    {
        List<Category> categories;
        MainDAO dao;
        QuizAppContext context;

        public AddQuizCollection()
        {
            InitializeComponent();
            dao = new MainDAO();
            context = new QuizAppContext();
            categories = context.Categories.ToList();
            categories.Add(new Category { Id = -1, Content = "Add New Category" });
            cmbCategoryId.ItemsSource = categories;
            cmbCategoryId.DisplayMemberPath = "Content"; // Hiển thị giá trị của thuộc tính Content
            cmbCategoryId.SelectedValuePath = "Id"; // Chọn giá trị của thuộc tính Id khi người dùng chọn một mục trong ComboBox
        }


        private void cmbCategoryId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Nếu người dùng chọn "Add New Category" thì hiển thị TextBox để nhập mới CategoryId
            if (cmbCategoryId.SelectedItem is Category selectedCategory && selectedCategory.Id == -1)
            {
                txtNewCategory.Visibility = Visibility.Visible;
            }
            else
            {
                txtNewCategory.Visibility = Visibility.Hidden;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Lấy thông tin từ TextBox và ComboBox
            string title = txtTitle.Text;

            // Lựa chọn từ ComboBox
            int categoryId = 0;
            if (cmbCategoryId.SelectedItem is Category selectedCategory && selectedCategory.Id == -1)
            {
                // Nếu người dùng chọn "Add New Category", lấy giá trị từ TextBox
                categoryId = context.Categories.Count();
                bool check = dao.CreatNewCategory(txtNewCategory.Text);
                if (!check)
                {
                    MessageBox.Show("This category is already exits", "Duplicate", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    QuizCollection? qc = context.QuizCollections.FirstOrDefault(item => item.Title == title);
                    if (qc != null && qc.CategoryId == categoryId)
                    {
                        MessageBox.Show("This collection is already exits", "Duplicate", MessageBoxButton.OK, MessageBoxImage.Warning);
                        AddQuiz addQuiz = new AddQuiz(qc.Id);
                        addQuiz.Show();
                        // Đóng cửa sổ sau khi thêm 
                        this.Close();
                    }
                    else
                    {
                        dao.AddNewCollection(txtTitle.Text, categoryId);
                        int collectionId = context.QuizCollections.ToList().Last().Id;
                        AddQuiz addQuiz = new AddQuiz(collectionId);
                        addQuiz.Show();
                        // Đóng cửa sổ sau khi thêm 
                        this.Close();
                    }
                }
            }
            else if (cmbCategoryId.SelectedItem is Category selectedcategory)
            {
                // Nếu người dùng chọn từ ExistingCategories, lấy giá trị từ ComboBox
                categoryId = selectedcategory.Id;
                QuizCollection? qc = context.QuizCollections.FirstOrDefault(item => item.Title == title);
                if (qc != null && qc.CategoryId == categoryId)
                {
                    MessageBox.Show("This collection is already exits", "Duplicate", MessageBoxButton.OK, MessageBoxImage.Warning);
                    AddQuiz addQuiz = new AddQuiz(qc.Id);
                    addQuiz.Show();
                    // Đóng cửa sổ sau khi thêm 
                    this.Close();
                }
                else
                {
                    dao.AddNewCollection(txtTitle.Text, categoryId);
                    int collectionId = context.QuizCollections.ToList().Last().Id;
                    AddQuiz addQuiz = new AddQuiz(collectionId);
                    addQuiz.Show();
                    // Đóng cửa sổ sau khi thêm 
                    this.Close();
                }
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            // Đóng cửa sổ nếu người dùng chọn "Cancel"
            this.Close();

        }
    }
}
