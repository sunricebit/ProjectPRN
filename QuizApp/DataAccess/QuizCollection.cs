using System;
using System.Collections.Generic;

namespace QuizApp.DataAccess;

public partial class QuizCollection
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
}
