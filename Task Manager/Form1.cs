namespace Task_Manager
{
    public partial class Form1 : Form
    {
        //release
        private TaskManager taskManager;

        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(tasksListBox);
            this.Controls.Add(descriptionTextBox);
            this.Controls.Add(addTaskButton);
            this.Controls.Add(removeTaskButton);
            this.Controls.Add(toggleCompletionButton);
            taskManager = new TaskManager();
            UpdateTasksList();
        }


        private void UpdateTasksList()
        {
            tasksListBox.Items.Clear();
            foreach (var task in taskManager.Tasks)
            {
                tasksListBox.Items.Add($"{(task.IsCompleted ? "[X]" : "[ )")} {task.Description}");
            }
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
