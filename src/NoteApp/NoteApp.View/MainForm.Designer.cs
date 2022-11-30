
namespace NoteApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.DateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.IconButtonEdit = new System.Windows.Forms.Button();
            this.IconButtonDelete = new System.Windows.Forms.Button();
            this.IconButtonAdd = new System.Windows.Forms.Button();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NoteTextBox.Font = new System.Drawing.Font("Verdana", 11F);
            this.NoteTextBox.Location = new System.Drawing.Point(15, 110);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(542, 400);
            this.NoteTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 18F);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameLabel.Location = new System.Drawing.Point(10, 11);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(146, 29);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Note Name";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.CategoryLabel.Location = new System.Drawing.Point(15, 50);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(84, 18);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.TextLabel.Location = new System.Drawing.Point(100, 50);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(78, 18);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Unknown";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.CreatedLabel.Location = new System.Drawing.Point(15, 78);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(74, 18);
            this.CreatedLabel.TabIndex = 1;
            this.CreatedLabel.Text = "Created:";
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.ModifiedLabel.Location = new System.Drawing.Point(225, 78);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(76, 18);
            this.ModifiedLabel.TabIndex = 1;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // DateTimePickerModified
            // 
            this.DateTimePickerModified.CalendarFont = new System.Drawing.Font("Verdana", 10F);
            this.DateTimePickerModified.Enabled = false;
            this.DateTimePickerModified.Font = new System.Drawing.Font("Verdana", 10F);
            this.DateTimePickerModified.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerModified.Location = new System.Drawing.Point(305, 75);
            this.DateTimePickerModified.Name = "DateTimePickerModified";
            this.DateTimePickerModified.Size = new System.Drawing.Size(100, 24);
            this.DateTimePickerModified.TabIndex = 3;
            // 
            // DateTimePickerCreated
            // 
            this.DateTimePickerCreated.CalendarFont = new System.Drawing.Font("Verdana", 10F);
            this.DateTimePickerCreated.Enabled = false;
            this.DateTimePickerCreated.Font = new System.Drawing.Font("Verdana", 10F);
            this.DateTimePickerCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerCreated.Location = new System.Drawing.Point(95, 75);
            this.DateTimePickerCreated.Name = "DateTimePickerCreated";
            this.DateTimePickerCreated.Size = new System.Drawing.Size(100, 24);
            this.DateTimePickerCreated.TabIndex = 2;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.Location = new System.Drawing.Point(11, 27);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.IconButtonEdit);
            this.SplitContainer.Panel1.Controls.Add(this.IconButtonDelete);
            this.SplitContainer.Panel1.Controls.Add(this.IconButtonAdd);
            this.SplitContainer.Panel1.Controls.Add(this.CategoryListBox);
            this.SplitContainer.Panel1.Controls.Add(this.CategoryComboBox);
            this.SplitContainer.Panel1.Controls.Add(this.ShowCategoryLabel);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.NoteTextBox);
            this.SplitContainer.Panel2.Controls.Add(this.TextLabel);
            this.SplitContainer.Panel2.Controls.Add(this.DateTimePickerModified);
            this.SplitContainer.Panel2.Controls.Add(this.CategoryLabel);
            this.SplitContainer.Panel2.Controls.Add(this.CreatedLabel);
            this.SplitContainer.Panel2.Controls.Add(this.NameLabel);
            this.SplitContainer.Panel2.Controls.Add(this.DateTimePickerCreated);
            this.SplitContainer.Panel2.Controls.Add(this.ModifiedLabel);
            this.SplitContainer.Size = new System.Drawing.Size(860, 520);
            this.SplitContainer.SplitterDistance = 286;
            this.SplitContainer.TabIndex = 3;
            // 
            // IconButtonEdit
            // 
            this.IconButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IconButtonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconButtonEdit.BackgroundImage")));
            this.IconButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButtonEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.IconButtonEdit.Location = new System.Drawing.Point(77, 460);
            this.IconButtonEdit.Name = "IconButtonEdit";
            this.IconButtonEdit.Size = new System.Drawing.Size(48, 48);
            this.IconButtonEdit.TabIndex = 4;
            this.IconButtonEdit.UseVisualStyleBackColor = true;
            this.IconButtonEdit.Click += new System.EventHandler(this.IconButtonEdit_Click);
            // 
            // IconButtonDelete
            // 
            this.IconButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IconButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconButtonDelete.BackgroundImage")));
            this.IconButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButtonDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.IconButtonDelete.Location = new System.Drawing.Point(137, 460);
            this.IconButtonDelete.Name = "IconButtonDelete";
            this.IconButtonDelete.Size = new System.Drawing.Size(48, 48);
            this.IconButtonDelete.TabIndex = 4;
            this.IconButtonDelete.UseVisualStyleBackColor = true;
            this.IconButtonDelete.Click += new System.EventHandler(this.IconButtonDelete_Click);
            // 
            // IconButtonAdd
            // 
            this.IconButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IconButtonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconButtonAdd.BackgroundImage")));
            this.IconButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButtonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.IconButtonAdd.Location = new System.Drawing.Point(17, 460);
            this.IconButtonAdd.Name = "IconButtonAdd";
            this.IconButtonAdd.Size = new System.Drawing.Size(48, 48);
            this.IconButtonAdd.TabIndex = 4;
            this.IconButtonAdd.UseVisualStyleBackColor = true;
            this.IconButtonAdd.Click += new System.EventHandler(this.IconButtonAdd_Click);
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryListBox.Font = new System.Drawing.Font("Verdana", 11F);
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.IntegralHeight = false;
            this.CategoryListBox.ItemHeight = 18;
            this.CategoryListBox.Location = new System.Drawing.Point(13, 50);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(265, 404);
            this.CategoryListBox.TabIndex = 3;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "All",
            "Events",
            "Work",
            "Food",
            "Health",
            "Animals",
            "Books",
            "Traveling",
            "Other"});
            this.CategoryComboBox.Location = new System.Drawing.Point(137, 15);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(141, 22);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.ShowCategoryLabel.Location = new System.Drawing.Point(10, 16);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(124, 18);
            this.ShowCategoryLabel.TabIndex = 1;
            this.ShowCategoryLabel.Text = "Show Category";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.AddToolStripMenuItem.Text = "Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.EditNoteToolStripMenuItem_Click);
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MenuStrip.Font = new System.Drawing.Font("Verdana", 11F);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(884, 26);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(870, 580);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.DateTimePicker DateTimePickerModified;
        private System.Windows.Forms.DateTimePicker DateTimePickerCreated;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.Button IconButtonEdit;
        private System.Windows.Forms.Button IconButtonDelete;
        private System.Windows.Forms.Button IconButtonAdd;
    }
}

