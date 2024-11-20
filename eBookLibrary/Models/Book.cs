using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBookLibrary.Models
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int publicationYear { get; set; }
        public bool isEpubAvailable { get; set; }
        public bool isF2bAvailable { get; set; }
        public bool isMobiAvailable { get; set; }
        public bool isPdfAvailable { get; set; }
        public float borrowPrice { get; set; }
        public float buyPrice { get; set; }
        public decimal? discountPrice { get; set; }
        public DateTime? discountStartDate { get; set; }
        public DateTime? discountEndDate { get; set; }
    }
}