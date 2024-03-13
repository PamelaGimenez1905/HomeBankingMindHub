﻿namespace HomeBankingMindHub.Models
{
    public class TransactionDTO
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }

        public TransactionDTO() { }

        public TransactionDTO(Models.Transaction transaction)
        {
            Id = transaction.Id;
            Type = transaction.Type.ToString();
            Amount = transaction.Amount;
            Description = transaction.Description;
            Date = transaction.Date;
        }
       
    }
}
