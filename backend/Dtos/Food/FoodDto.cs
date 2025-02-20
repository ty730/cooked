using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos
{
    public class FoodDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DefaultUnit { get; set; } = string.Empty;
        public double DefaultAmount { get; set; }
        public double Cost { get; set; }
        public double Calories { get; set; }
        public double Fiber { get; set; }
        public double Protein { get; set; }
        public double TotalSugar { get; set; }
        public double Sodium { get; set; }
    }
}