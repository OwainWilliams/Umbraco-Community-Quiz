﻿namespace Quiz.Site.Models;

public class QuizViewModel
{
    public int QuizId { get; set; }
    public int MemberId { get; set; }
    public List<QuizQuestionViewModel> Questions { get; set; }
}
