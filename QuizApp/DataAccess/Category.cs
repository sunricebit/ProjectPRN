using System;
using System.Collections.Generic;

namespace QuizApp.DataAccess;

public partial class Category
{
    public int Id { get; set; }

    public string? Content { get; set; }

    public virtual ICollection<QuizCollection> QuizCollections { get; set; } = new List<QuizCollection>();
}
