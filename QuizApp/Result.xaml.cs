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
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Window
    {
        List<Question> ChooseQuestion;
        List<Question> Questions;

        public Result(int correctAnswer, List<Question> chooseQuestion, List<Question> questions)
        {
            InitializeComponent();
            txtCorrectAnswer.Text = "Correct Questions: " + correctAnswer.ToString() + "/" + chooseQuestion.Count().ToString();
            double score = ((double)correctAnswer / (double)chooseQuestion.Count()) * (double)10;
            txtScore.Text = score.ToString("N2");
            ChooseQuestion = chooseQuestion;
            Questions = questions;
        }

        private void btnReview_Click(object sender, RoutedEventArgs e)
        {
            Review review = new Review(ChooseQuestion, Questions);
            review.Show();
            this.Close();
        }
    }
}
