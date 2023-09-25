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

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for Review.xaml
    /// </summary>
    public partial class Review : Window
    {
        List<Question> ChooseQuestion;
        List<Question> Questions;
        int position;

        public Review(List<Question> chooseQuestion, List<Question> questions)
        {
            InitializeComponent();
            ChooseQuestion = chooseQuestion;
            Questions = questions;
            position = 0;
            LoadQuiz((int)questions[position].Id);
        }

        public void LoadQuiz(int quizId)
        {
            Question q = ChooseQuestion.FirstOrDefault(item => item.Id == quizId);
            Question qi = Questions.FirstOrDefault(item => item.Id == quizId);
            txtQuestion.Text = q.QuestionContent;
            txtAnswerA.Text = q.AnswersA;
            txtAnswerB.Text = q.AnswersB;
            txtAnswerC.Text = q.AnswersC;
            txtAnswerD.Text = q.AnswersD;
            chkA.IsChecked = q.ACorrect;
            chkB.IsChecked = q.BCorrect;
            chkC.IsChecked = q.CCorrect;
            chkD.IsChecked = q.DCorrect;
            if (qi.ACorrect)
            {
                txtAnswerA.Foreground = Brushes.Green;
            }
            else
            {
                txtAnswerA.Foreground = Brushes.Red;
            }

            if (qi.BCorrect)
            {
                txtAnswerB.Foreground = Brushes.Green;
            }
            else
            {
                txtAnswerB.Foreground = Brushes.Red;
            }

            if (qi.CCorrect)
            {
                txtAnswerC.Foreground = Brushes.Green;
            }
            else
            {
                txtAnswerC.Foreground = Brushes.Red;
            }

            if (qi.DCorrect)
            {
                txtAnswerD.Foreground = Brushes.Green;
            }
            else
            {
                txtAnswerD.Foreground = Brushes.Red;
            }
            txtIndex.Text = (position + 1).ToString() + "/" + ChooseQuestion.Count().ToString();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (position > 0)
            {
                position--;
                LoadQuiz((int)ChooseQuestion[position].Id);
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (position < ChooseQuestion.Count() - 1)
            {
                position++;
                LoadQuiz((int)ChooseQuestion[position].Id);
            }
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
