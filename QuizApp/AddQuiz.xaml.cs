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

namespace QuizApp
{
    public class Question
    {
        public int? Id { get; set; }
        public string QuestionContent { get; set; }
        public string AnswersA { get; set; }
        public string AnswersB { get; set; }
        public string AnswersC { get; set; }
        public string AnswersD { get; set; }

        public bool ACorrect { get; set; }
        public bool BCorrect { get; set; }
        public bool CCorrect { get; set; }
        public bool DCorrect { get; set; }
    }

    /// <summary>
    /// Interaction logic for AddQuiz.xaml
    /// </summary>
    public partial class AddQuiz : Window
    {
        int CollectionID;
        QuizAppContext context;
        ObservableCollection<Question> questions;
        MainDAO dao;

        public AddQuiz(int collectionID)
        {
            InitializeComponent();
            dao = new MainDAO();
            context = new QuizAppContext();
            CollectionID = collectionID;
            questions = new ObservableCollection<Question>();
            LoadQuestion();
        }

        public void LoadQuestion()
        {
            List<Quiz> quizzes = context.Quizzes.Where(item => item.CollectionId == CollectionID).ToList();
            List<Answer> answers;
            questions.Clear();
            foreach(Quiz quiz in quizzes)
            {
                Question q = new Question()
                {
                    Id = quiz.Id,
                    QuestionContent = quiz.Content,
                };
                answers = context.Answers.Where(item => item.QuizId == quiz.Id).ToList();
                q.AnswersA = answers[0].Content;
                q.ACorrect = (bool)answers[0].Correct;
                q.AnswersB = answers[1].Content;
                q.BCorrect = (bool)answers[1].Correct;
                q.AnswersC = answers[2].Content;
                q.CCorrect = (bool)answers[2].Correct;
                q.AnswersD = answers[3].Content;
                q.DCorrect = (bool)answers[3].Correct;
                questions.Add(q);
            }
            lvQuestion.ItemsSource = questions;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Quiz q = context.Quizzes.FirstOrDefault(item => item.Content.Equals(txtQuestion.Text) && item.CollectionId == CollectionID);
            if (q != null)
            {
                MessageBox.Show("This question already exists", "Duplicate", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            
            bool areAllStringsUnique = true;

            if (txtAnswerA.Text == txtAnswerB.Text || txtAnswerA.Text == txtAnswerC.Text || txtAnswerA.Text == txtAnswerD.Text)
            {
                areAllStringsUnique = false;
            }
            else if (txtAnswerB.Text == txtAnswerC.Text || txtAnswerB.Text == txtAnswerD.Text)
            {
                areAllStringsUnique = false;
            }
            else if (txtAnswerC.Text == txtAnswerD.Text)
            {
                areAllStringsUnique = false;
            }

            if (!areAllStringsUnique)
            {
                MessageBox.Show("Answers can't be the same", "Duplicate", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            dao.AddQuiz(txtQuestion.Text, CollectionID);
            // Anwser A
            if ((bool)chkA.IsChecked)
            {
                dao.AddAnswer(txtAnswerA.Text, true, context.Quizzes.ToList().Last().Id);
            }
            else
            {
                dao.AddAnswer(txtAnswerA.Text, false, context.Quizzes.ToList().Last().Id);
            }

            // Anwser B
            if ((bool)chkB.IsChecked)
            {
                dao.AddAnswer(txtAnswerB.Text, true, context.Quizzes.ToList().Last().Id);
            }
            else
            {
                dao.AddAnswer(txtAnswerB.Text, false, context.Quizzes.ToList().Last().Id);
            }

            // Anwser C
            if ((bool)chkC.IsChecked)
            {
                dao.AddAnswer(txtAnswerC.Text, true, context.Quizzes.ToList().Last().Id);
            }
            else
            {
                dao.AddAnswer(txtAnswerC.Text, false, context.Quizzes.ToList().Last().Id);
            }

            // Anwser D
            if ((bool)chkD.IsChecked)
            {
                dao.AddAnswer(txtAnswerD.Text, true, context.Quizzes.ToList().Last().Id);
            }
            else
            {
                dao.AddAnswer(txtAnswerD.Text, false, context.Quizzes.ToList().Last().Id);
            }
            LoadQuestion();
            ClearAll();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Question qToUpdate = (Question)lvQuestion.SelectedItem;
            if (qToUpdate != null)
            {
                Quiz quiz = context.Quizzes.FirstOrDefault(item => item.Id == qToUpdate.Id);
                List<Answer> answers = context.Answers.Where(item => item.QuizId == quiz.Id).ToList();
                answers[0].Content = txtAnswerA.Text;
                answers[1].Content = txtAnswerB.Text;
                answers[2].Content = txtAnswerC.Text;
                answers[3].Content = txtAnswerD.Text;
                answers[0].Correct = chkA.IsChecked;
                answers[1].Correct = chkB.IsChecked;
                answers[2].Correct = chkC.IsChecked;
                answers[3].Correct = chkD.IsChecked;
                quiz.Content = txtQuestion.Text;
                context.Update(quiz);
                context.UpdateRange(answers);
                context.SaveChanges();
                LoadQuestion();
            };
            ClearAll();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Question qToDelete = lvQuestion.SelectedItem as Question;
            if (qToDelete != null)
            {
                dao.DeleteQuiz((int)qToDelete.Id);
                LoadQuestion();
            };
            ClearAll();
        }

        private void lvQuestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedQuestion = lvQuestion.SelectedItem as Question;
            if (selectedQuestion != null)
            {
                txtQuestion.Text = selectedQuestion.QuestionContent;
                txtAnswerA.Text = selectedQuestion.AnswersA;
                txtAnswerB.Text = selectedQuestion.AnswersB;
                txtAnswerC.Text = selectedQuestion.AnswersC;
                txtAnswerD.Text = selectedQuestion.AnswersD;
                chkA.IsChecked = selectedQuestion.ACorrect;
                chkB.IsChecked = selectedQuestion.BCorrect;
                chkC.IsChecked = selectedQuestion.CCorrect;
                chkD.IsChecked = selectedQuestion.DCorrect;
            }
        }

        public void ClearAll()
        {
            txtQuestion.Clear();
            txtAnswerA.Clear();
            txtAnswerB.Clear();
            txtAnswerC.Clear();
            txtAnswerD.Clear();
            chkA.IsChecked = false;
            chkB.IsChecked = false;
            chkC.IsChecked = false;
            chkD.IsChecked = false;
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
