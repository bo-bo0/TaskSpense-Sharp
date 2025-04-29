using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PersonalExpenseAndTaskManager;

namespace PersonalExpenseAndTaskManager
{
    internal abstract class FileActions
    {
        public static void addJsonContent<T>(T newItem, string path, List<T> list)
        {
            string[]? oldLines = null;

            if (list.Count != 1)
            {
                if(File.Exists(path))
                    oldLines = File.ReadAllLines(path);

                else
                {
                    File.WriteAllText(path, "[\n");
                    
                    int i = 0;
                    foreach (var item in list)
                    {
                        if (i > 0) { File.AppendAllText(path, ","); }

                        if (item != null) { File.AppendAllText(path, item.ToString()); }
                        i++;
                    }
                    File.AppendAllText(path, "\n]");
                }
                if (oldLines != null) { oldLines = oldLines.Skip(1).Take(oldLines.Length - 2).ToArray(); }
            }

            if (newItem != null) { File.WriteAllText(path, $"[\n{newItem.ToString()}\n"); }
            
            if (oldLines != null) 
            {
                File.AppendAllText(path, ",");
                File.AppendAllLines(path, oldLines); 
            }

            File.AppendAllText(path, "]");
        }

        public static void readJsonContent<T>(string file, List<T> list, DataGridView dataGrid)
        {
            if (file != null)
            {
                string json;
                using (var r = new StreamReader(file)) { json = r.ReadToEnd(); }

                if (json == "") return; //doesn't do anything if the file is empty
                try
                {
                    var phlist = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
                    list.Clear();
                    list.AddRange(phlist);
                    dataGrid.DataSource = list;
                }
                catch
                {

                    var answer = MessageBox.Show($"It was not possible to read the save files. Press Ok to create new data or Cancel to close the application.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (answer == DialogResult.Cancel)
                        Application.Exit();
                    else
                    {
                        dataGrid.DataSource = null;
                        File.WriteAllText(file, null); //reset file
                    }

                }
            }
        }
    }
}
