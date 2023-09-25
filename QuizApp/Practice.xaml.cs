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
    /// <summary>
    /// Interaction logic for Practice.xaml
    /// </summary>
    public partial class Practice : Window
    {
        int CollectionID;
        QuizAppContext context;
        List<Question> questions;
        List<Question> chooseQuestions;
        MainDAO dao;
        int position;

        public Practice(int collectionID)
        {
            InitializeComponent();
            dao = new MainDAO();
            context = new QuizAppContext();
            CollectionID = collectionID;
            questions = new List<Question>();
            chooseQuestions = new List<Question>();
            LoadQuestion();
            foreach (var item in questions)
            {
                Question q = new Question()
                {
                    Id = item.Id,
                    QuestionContent = item.QuestionContent,
                    AnswersA = item.AnswersA,
                    AnswersB = item.AnswersB,
                    AnswersC = item.AnswersC,
                    AnswersD = item.AnswersD,
                    ACorrect = false,
                    BCorrect = false,
                    CCorrect = false,
                    DCorrect = false,
                };

                chooseQuestions.Add(q);
            }
            position = 0;
            LoadQuiz((int)questions[position].Id);
        }

        public void LoadQuestion()
        {
            List<Quiz> quizzes = context.Quizzes.Where(item => item.CollectionId == CollectionID).ToList();
            List<Answer> answers;
            questions.Clear();
            foreach (Quiz quiz in quizzes)
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
        }

        public void LoadQuiz(int quizId)
        {
            Question q = chooseQuestions.FirstOrDefault(item => item.Id == quizId);
            txtQuestion.Text = q.QuestionContent;
            txtAnswerA.Text = q.AnswersA;
            txtAnswerB.Text = q.AnswersB;
            txtAnswerC.Text = q.AnswersC;
            txtAnswerD.Text = q.AnswersD;
            chkA.IsChecked = q.ACorrect;
            chkB.IsChecked = q.BCorrect;
            chkC.IsChecked = q.CCorrect;
            chkD.IsChecked = q.DCorrect;
            txtIndex.Text = (position + 1).ToString() + "/" + questions.Count().ToString();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            SaveQuestion(position);
            if (position > 0)
            {
                position--;
                LoadQuiz((int)questions[position].Id);
            }
            else 
            {
                txtIndex.Text = (position + 1).ToString() + "/" + questions.Count().ToString();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

            SaveQuestion(position);

            if (position < questions.Count() - 1)
            {
                position++;
                LoadQuiz((int)questions[position].Id);
            }
            else
            {
                txtIndex.Text = (position + 1).ToString() + "/" + questions.Count().ToString();
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SaveQuestion(position);

            int correctAnswer = 0;

            for (int i = 0; i < questions.Count(); i++)
            {
                if (chooseQuestions[i].ACorrect == questions[i].ACorrect
                        && chooseQuestions[i].BCorrect == questions[i].BCorrect
                        && chooseQuestions[i].CCorrect == questions[i].CCorrect
                        && chooseQuestions[i].DCorrect == questions[i].DCorrect)
                {
                    correctAnswer++;
                }
            }

            Result result = new Result(correctAnswer, chooseQuestions, questions);
            result.Show();
            this.Close();

        }

        private void SaveQuestion(int pos)
        {
            chooseQuestions[pos].ACorrect = (bool)chkA.IsChecked;
            chooseQuestions[pos].BCorrect = (bool)chkB.IsChecked;
            chooseQuestions[pos].CCorrect = (bool)chkC.IsChecked;
            chooseQuestions[pos].DCorrect = (bool)chkD.IsChecked;
        }
    }
}
