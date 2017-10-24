using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBox.Models
{
    public class SuggestionModel
    {
        //Fields
        private string topic;
        private string suggestion;

        //Properties
        [Key]
        public int ID { get; set; }

        public string Topic { get; set; }

        public string Comment { get; set; }

    }
}