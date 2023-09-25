using System;
using System.Collections.Generic;

namespace QuizApp.DataAccess;

public partial class Quiz
{
    public int Id { get; set; }

    public int? CollectionId { get; set; }

    public string? Content { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual QuizCollection? Collection { get; set; }
}
