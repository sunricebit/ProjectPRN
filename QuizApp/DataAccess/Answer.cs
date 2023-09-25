using System;
using System.Collections.Generic;

namespace QuizApp.DataAccess;

public partial class Answer
{
    public int Id { get; set; }

    public int? QuizId { get; set; }

    public string? Content { get; set; }

    public bool? Correct { get; set; }

    public virtual Quiz? Quiz { get; set; }
}
