using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_Manager
{
    public partial class Form1 : Form
    {
        private TaskManager.TaskManager taskManager;
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(tasksListBox);
            this.Controls.Add(descriptionTextBox);
            this.Controls.Add(addTaskButton);
            this.Controls.Add(removeTaskButton);
            this.Controls.Add(toggleCompletionButton);
            taskManager = new TaskManager.TaskManager();
            UpdateTasksList();
            tasksListBox.DrawMode = DrawMode.OwnerDrawFixed;
            tasksListBox.DrawItem += tasksListBox_DrawItem;
        }
        private void tasksListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush textBrush;
            ListBox lb = (ListBox)sender;
            string item = lb.Items[e.Index].ToString();
            string[] task = item.Split(' ');
            if (task[0] == "[X]") { textBrush = Brushes.Red; } else { textBrush = Brushes.Green; }
            e.DrawFocusRectangle();
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);
        }
        private void UpdateTasksList()
        {
            tasksListBox.Items.Clear();
            foreach (var task in taskManager.Tasks)
            {
                tasksListBox.Items.Add($"{(task.IsCompleted ? "[X]" : "[ )")} {task.Description}");
            }
            tasksListBox.Invalidate();

        }
        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.AddTask(descriptionTextBox.Text);
                descriptionTextBox.Clear();
                UpdateTasksList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите задачу для удаления!");
                return;
            }
            try
            {
                taskManager.RemoveTask(tasksListBox.SelectedIndex);
                UpdateTasksList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ToggleCompletionButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите задачу для изменения статуса!");
                return;
            }
            try
            {
                taskManager.ToggleTaskCompletion(tasksListBox.SelectedIndex);
                UpdateTasksList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
