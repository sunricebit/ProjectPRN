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
    /// Interaction logic for FlashCard.xaml
    /// </summary>
    public partial class FlashCard : Window
    {
        public FlashCard()
        {
            InitializeComponent();
            UpdateFlashCardContent();
        }

        private int currentCardIndex = 0;
        private string[] frontContents = { "What is the capital of France?", "What is the chemical symbol for water?", /* Add more questions here */ };
        private string[] backContents = { "Paris", "H2O", /* Add more answers here */ };

        private void borderFlashcard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (gridFlashcard.RowDefinitions[0].Height.Value == 1)
            {
                gridFlashcard.RowDefinitions[0].Height = new GridLength(0);
                gridFlashcard.RowDefinitions[1].Height = new GridLength(1, GridUnitType.Star);
            }
            else
            {
                gridFlashcard.RowDefinitions[0].Height = new GridLength(1, GridUnitType.Star);
                gridFlashcard.RowDefinitions[1].Height = new GridLength(0);
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            currentCardIndex = Math.Max(0, currentCardIndex - 1);
            UpdateFlashCardContent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            currentCardIndex = Math.Min(frontContents.Length - 1, currentCardIndex + 1);
            UpdateFlashCardContent();
        }

        private void UpdateFlashCardContent()
        {
            txtFront.Text = frontContents[currentCardIndex];
            txtIndex.Text = $"Card {currentCardIndex + 1}/{frontContents.Length}";
            gridFlashcard.RowDefinitions[0].Height = new GridLength(1, GridUnitType.Star);
            gridFlashcard.RowDefinitions[1].Height = new GridLength(0);
        }

        private void LoadAnswerOptions(int numberOfAnswers)
        {
            // Xóa các TextBlock cũ (nếu có)
            answerOptionsStackPanel.Children.Clear();

            // Tạo các TextBlock mới và thêm vào StackPanel
            for (int i = 0; i < numberOfAnswers; i++)
            {
                var answerOption = (char)('A' + i); // Chuyển đổi thành các ký tự 'A', 'B', 'C', ...
                var textBlock = new TextBlock
                {
                    Text = answerOption.ToString(),
                    FontSize = 18,
                    FontWeight = FontWeights.Bold,
                    TextAlignment = TextAlignment.Left
                };

                answerOptionsStackPanel.Children.Add(textBlock);
            }
        }
    }
}
