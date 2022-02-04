using System;
using System.Collections.Generic;

namespace Primeiro.Services.Interfaces.Exercicio.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installment { get; set; }
    }
}