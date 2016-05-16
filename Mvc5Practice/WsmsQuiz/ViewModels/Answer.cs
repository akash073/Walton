using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WsmsQuiz.ViewModels
{
    public class Answer
    {
        
        
        public long Id { get; set; }//1 ans1 2 ans2
        public string AnswerName { get; set; }
    }
}