using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseAndTaskManager
{
    public class Notification
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Unread { get; set; }
        public Notification(string title, string description) 
        {
            Title = title;
            Description = description;
            Unread = true;
        }

        public static bool Check()
        {
            List<Task> tasksToNotify = [];

            try
            {
                tasksToNotify = ExpensesForm.tasks.Where(t =>
                {
                    if (t.Deadline == null) { return false; }

                    if (TextActions.spacesString(t.Deadline)) { return false; }

                    return (Convert.ToDateTime(t.Deadline) - DateTime.Today) < TimeSpan.FromDays(3);

                }).ToList();

                for (int i = 0; i < tasksToNotify.Count; i++)
                {
                    tasksToNotify[i] = new Task(tasksToNotify[i].Title, tasksToNotify[i].Description, tasksToNotify[i].Deadline, tasksToNotify[i].Priority);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"FATAL ERROR THIS IS NOT SUPPOSED TO HAPPEN: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            List<Notification> newNotifications = [];

            for (int i = 0; i < tasksToNotify.Count; i++)
            {
                if (tasksToNotify[i].Priority == null) { tasksToNotify[i].Priority = 0; }

                string futureOrPastText;

                int daysDifference = (int)(Convert.ToDateTime(tasksToNotify[i].Deadline) - DateTime.Today).TotalDays;

                if (daysDifference > 0) { futureOrPastText = $"is due {daysDifference} days"; }
                else if (daysDifference < 0) { futureOrPastText = $"expired {Math.Abs(daysDifference) + 1} days ago"; }
                else { futureOrPastText = "is due today"; }

                newNotifications.Add(new Notification($"[[{tasksToNotify[i].Title}]]", $"This task with priority ({tasksToNotify[i].Priority}) {futureOrPastText}.\n\n"));
            }

            bool flag = false;

            if (tasksToNotify.Count > ExpensesForm.notifications.Count) { flag = true; }

            // Mark all new notifications as how they were and old notifications as read
            for (int i = 0; i < newNotifications.Count; i++)
            {
                if (i < (tasksToNotify.Count - ExpensesForm.notifications.Count))
                {
                    //new ones
                    newNotifications[i].Unread = true;
                }
                else
                {
                    //old ones
                    newNotifications[i].Unread = ExpensesForm.notifications[i - (tasksToNotify.Count - ExpensesForm.notifications.Count)].Unread;
                }
            }

            ExpensesForm.notifications.Clear();
            ExpensesForm.notifications.AddRange(newNotifications);

            return flag;
        }
    }
}
