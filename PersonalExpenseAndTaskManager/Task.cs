using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonalExpenseAndTaskManager
{
    public class Task
    {
        //Constructor
        public Task(string title, string description, string? deadline, int? priority)
        {
            Title = title;
            this.description = description;
            Deadline = deadline;
            Priority = priority;
        }

        //Variables
        private string? description;

        //Properties
        public string Title{ get; set; }
        public string Description 
        { 
            get
            {
                if (Global.FullDescriptionFlag) return description ?? "";

                if (description?.Length < 13)
                    return description;

                else return $"{description?.Substring(0, 12)}...";
            }

            set { description = value; }
        }
        public string? Deadline { get; set; }
        public int? Priority { get; set; }

        //Methods
        public override string ToString()
        {
            string? fixedTitle;
            string? fixedDescription;

            if (Title != null)
            {
                fixedTitle = TextActions.specialCharactersClean(Title);
            }
            else
                fixedTitle = "";


            if (description != null)
            {
                fixedDescription = TextActions.specialCharactersClean(description);
            }
            else
                fixedDescription = "";

            var sentPriority = Convert.ToString(Priority);

            if (TextActions.spacesString(Convert.ToString(Priority) ?? "")) { sentPriority = "null"; }

            return $"{{\n\"Title\": \"{fixedTitle}\",\n\"Description\": \"{fixedDescription}\",\n\"Deadline\": \"{Deadline}\",\n\"Priority\": {sentPriority}\n}}";
        }
    }
}
