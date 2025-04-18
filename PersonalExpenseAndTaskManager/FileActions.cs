using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalExpenseAndTaskManager;

namespace PersonalExpenseAndTaskManager
{
    internal abstract class FileActions
    {
        public static void addJsonContent(Expense newExpense, string path)
        {
            string[]? oldLines = null;

            if (ExpensesForm.expenses.Count != 1)
            {
                if(File.Exists(path))
                    oldLines = File.ReadAllLines(path);

                else
                {
                    File.WriteAllText(path, "[\n");
                    
                    int i = 0;
                    foreach (var item in ExpensesForm.expenses)
                    {
                        if (i > 0) { File.AppendAllText(path, ","); }

                        File.AppendAllText(path, item.ToString());
                        i++;
                    }
                    File.AppendAllText(path, "\n]");
                }
                if (oldLines != null) { oldLines = oldLines.Skip(1).Take(oldLines.Length - 2).ToArray(); }
            }

            File.WriteAllText(path, $"[\n{newExpense.ToString()}\n");
            
            if (oldLines != null) 
            {
                File.AppendAllText(path, ",");
                File.AppendAllLines(path, oldLines); 
            }

            File.AppendAllText(path, "]");
        }
    }
}
