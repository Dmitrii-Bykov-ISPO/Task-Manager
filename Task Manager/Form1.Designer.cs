namespace Task_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tasksListBox = new ListBox();
            descriptionTextBox = new TextBox();
            addTaskButton = new Button();
            removeTaskButton = new Button();
            toggleCompletionButton = new Button();
            SuspendLayout();
            // 
            // tasksListBox
            // 
            tasksListBox.FormattingEnabled = true;
            tasksListBox.ItemHeight = 15;
            tasksListBox.Location = new Point(10, 10);
            tasksListBox.Name = "tasksListBox";
            tasksListBox.Size = new Size(200, 199);
            tasksListBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(220, 10);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(150, 23);
            descriptionTextBox.TabIndex = 1;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(220, 40);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(70, 23);
            addTaskButton.TabIndex = 2;
            addTaskButton.Text = "Добавить";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += AddTaskButton_Click;
            // 
            // removeTaskButton
            // 
            removeTaskButton.Location = new Point(300, 40);
            removeTaskButton.Name = "removeTaskButton";
            removeTaskButton.Size = new Size(70, 23);
            removeTaskButton.TabIndex = 3;
            removeTaskButton.Text = "Удалить";
            removeTaskButton.UseVisualStyleBackColor = true;
            removeTaskButton.Click += RemoveTaskButton_Click;
            // 
            // toggleCompletionButton
            // 
            toggleCompletionButton.Location = new Point(220, 70);
            toggleCompletionButton.Name = "toggleCompletionButton";
            toggleCompletionButton.Size = new Size(150, 23);
            toggleCompletionButton.TabIndex = 4;
            toggleCompletionButton.Text = "Отметить";
            toggleCompletionButton.UseVisualStyleBackColor = true;
            toggleCompletionButton.Click += ToggleCompletionButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(toggleCompletionButton);
            Controls.Add(removeTaskButton);
            Controls.Add(addTaskButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(tasksListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox tasksListBox;
        private TextBox descriptionTextBox;
        private Button addTaskButton;
        private Button removeTaskButton;
        private Button toggleCompletionButton;
    }
}
