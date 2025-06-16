using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseAndTaskManager
{
    public class Expense
    {
        //constructor
        public Expense(string amount, string date, string category, string description, string intermediate)
        {
            Amount = amount;
            Date = date;
            Category = category;
            this.description = description;
            Intermediate = intermediate;
        }

        //variables

        private string? description;

        //properties

        public string? Amount { get; set; }
        public string? Date { get; set; }
        public string? Category { get; set; }
        public string? Description 
        {
            get
            {
                if (description != null)
                {
                    if (description.Length < 13)
                        return description;

                    else return $"{description.Substring(0, 12)}...";
                }
                else return null;
            }
            set { description = value; }
            
        }
        public string? Intermediate { get; set; }

        //methods

        public override string ToString()
        {
            string? fixedDescription;
            string? fixedIntermediate;

            if (description != null)
            {
                fixedDescription =  TextActions.specialCharactersClean(description);
            }
            else
                fixedDescription = "";


            if (Intermediate != null)
            {
                fixedIntermediate = TextActions.specialCharactersClean(Intermediate);
            }
            else
                fixedIntermediate = "";


            return $"{{\n\"Amount\": \"{Amount}\",\n\"Date\": \"{Date}\",\n\"Category\": \"{Category}\",\n\"Description\": \"{fixedDescription}\",\n\"Intermediate\": \"{fixedIntermediate}\"\n}}";
        }
    }
}
