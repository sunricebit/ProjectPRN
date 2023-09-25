using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuizApp.DataAccess
{
    public class MainDAO
    {
        QuizAppContext context;

        public MainDAO()
        {
            context = new QuizAppContext();
        }

        public bool CreatNewCategory(string content)
        {
            Category category = new Category()
            {
                Id = context.Categories.Count(),
                Content = content,
            };
            Category c = context.Categories.FirstOrDefault(item => item.Content == content);
            if (c != null)
            {
                return false;
            }
            else {
                context.Categories.Add(category);
                context.SaveChanges(); 
                return true;
            }
        }

        public List<Category> GetAllCategory()
        {
            List<Category> categories = context.Categories.ToList();
            return categories;
        }

        public List<QuizCollection> GetAllCollection()
        {
            List<QuizCollection> quizCollections = context.QuizCollections.ToList();
            return quizCollections;
        }

        public List<Quiz> GetQuizInCollection(int quizCollectionID)
        {
            List<Quiz> quizzes = context.Quizzes.ToList();
            quizzes.Where(item => item.CollectionId == quizCollectionID);
            return quizzes;
        }

        public void Check(int quizCollectionID, List<QuizUser> quizUsers)
        {
            int countTrueAnswer = 0;
            List<Quiz> quizzes = context.Quizzes.ToList();
            quizzes.Where(item => item.CollectionId == quizCollectionID);
            foreach (Quiz quiz in quizzes)
            {
                foreach(QuizUser quizUser in quizUsers)
                {
                    if (quiz.Id == quizUser.Id)
                    {
                        
                    }
                }
            }
        }

        public void AddNewCollection(string content, int categoryId)
        {
            QuizCollection collection = new QuizCollection()
            {
                Id = context.QuizCollections.ToList().Last().Id + 1,
                Title = content,
                CategoryId = categoryId,
            };
            context.QuizCollections.Add(collection);
            context.SaveChanges();
        }

        public void AddQuiz(string content, int collectionId)
        {
            Quiz quiz = new Quiz()
            {
                Id = context.Quizzes.ToList().Last().Id + 1,
                CollectionId = collectionId,
                Content = content,
            };
            context.Quizzes.Add(quiz);
            context.SaveChanges();
        }

        public void AddAnswer(string content, bool correct, int quizId)
        {
            Answer answer = new Answer()
            {
                Id = context.Answers.ToList().Last().Id + 1,
                Content = content,
                Correct = correct,
                QuizId = quizId,
            };
            context.Answers.Add(answer);
            context.SaveChanges();
        }

        public void DeleteQuiz(int quizId)
        {
            Quiz q = context.Quizzes.FirstOrDefault(item => item.Id == quizId);
            var answerList = context.Answers.Where(item => item.QuizId == quizId);
            context.Quizzes.Remove(q);
            context.Answers.RemoveRange(answerList);
            context.SaveChanges();
        }

        public List<QuizCollection> SearchCollection(string strSearch, int? categoryID)
        {
            List<QuizCollection> qcs = context.QuizCollections.ToList();
            List<QuizCollection> tempList = new List<QuizCollection>();
            if (categoryID != null && categoryID != -1)
            {
                foreach(var item in qcs)
                {
                    if (item.Id == categoryID)
                    {
                        tempList.Add(item);
                    }
                }
            }

            if (!string.IsNullOrEmpty(strSearch))
            {
                qcs.Clear();
                foreach (var item in tempList)
                {
                    if (item.Title.Contains(strSearch))
                    {
                        qcs.Add(item);
                    }
                }
            }

            qcs.Clear();
            foreach (var item in tempList)
            {
                    qcs.Add(item);
            }
            return qcs;
        }
    }
}
