﻿using _02Uzduotis.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _02Uzduotis.Models
{
    public class Magazine: Item, IBorrowable
    {
        public int IssueNumber {  get; set; }
        public string Publisher { get; set; }

        public Magazine(int id, string title, int publicationYear, int issueNumber, string publisher) 
            :base(id, title, publicationYear)
        {
            IssueNumber = issueNumber;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {IssueNumber} - {Publisher}";
        }

        public void Borrow(Reader reader)
        {
            reader.BorrowItem(this);
        }

        public void Return(Reader reader)
        {
            reader.BorrowedItems.Remove(this);
        }
    }
}
