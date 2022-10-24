
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
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategory = new System.Windows.Forms.Label();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.NoteTextBox.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTextBox.Location = new System.Drawing.Point(30, 110);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(520, 400);
            this.NoteTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Cuprum", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameLabel.Location = new System.Drawing.Point(25, 5);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(358, 37);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Требования к оформлению";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Cuprum", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(30, 50);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(79, 22);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Cuprum", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.Location = new System.Drawing.Point(110, 50);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(48, 22);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Work";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Cuprum", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(30, 80);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(70, 22);
            this.CreatedLabel.TabIndex = 1;
            this.CreatedLabel.Text = "Created:";
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Font = new System.Drawing.Font("Cuprum", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedLabel.Location = new System.Drawing.Point(240, 80);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(77, 22);
            this.ModifiedLabel.TabIndex = 1;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // DateTimePickerModified
            // 
            this.DateTimePickerModified.Enabled = false;
            this.DateTimePickerModified.Font = new System.Drawing.Font("Cuprum", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePickerModified.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerModified.Location = new System.Drawing.Point(323, 80);
            this.DateTimePickerModified.Name = "DateTimePickerModified";
            this.DateTimePickerModified.Size = new System.Drawing.Size(100, 24);
            this.DateTimePickerModified.TabIndex = 2;
            this.DateTimePickerModified.ValueChanged += new System.EventHandler(this.DateTimePickerModified_ValueChanged);
            // 
            // DateTimePickerCreated
            // 
            this.DateTimePickerCreated.Enabled = false;
            this.DateTimePickerCreated.Font = new System.Drawing.Font("Cuprum", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePickerCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerCreated.Location = new System.Drawing.Point(108, 80);
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
            this.SplitContainer.Panel1.Controls.Add(this.button3);
            this.SplitContainer.Panel1.Controls.Add(this.button2);
            this.SplitContainer.Panel1.Controls.Add(this.button1);
            this.SplitContainer.Panel1.Controls.Add(this.CategoryListBox);
            this.SplitContainer.Panel1.Controls.Add(this.CategoryComboBox);
            this.SplitContainer.Panel1.Controls.Add(this.ShowCategory);
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
            // CategoryListBox
            // 
            this.CategoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryListBox.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.IntegralHeight = false;
            this.CategoryListBox.ItemHeight = 17;
            this.CategoryListBox.Location = new System.Drawing.Point(18, 50);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(250, 400);
            this.CategoryListBox.TabIndex = 3;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.Font = new System.Drawing.Font("Cuprum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(140, 15);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(128, 23);
            this.CategoryComboBox.TabIndex = 2;
            // 
            // ShowCategory
            // 
            this.ShowCategory.AutoSize = true;
            this.ShowCategory.Font = new System.Drawing.Font("Cuprum", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCategory.Location = new System.Drawing.Point(15, 15);
            this.ShowCategory.Name = "ShowCategory";
            this.ShowCategory.Size = new System.Drawing.Size(120, 22);
            this.ShowCategory.TabIndex = 1;
            this.ShowCategory.Text = "Show Category";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExtToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExtToolStripMenuItem
            // 
            this.ExtToolStripMenuItem.Name = "ExtToolStripMenuItem";
            this.ExtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExtToolStripMenuItem.Text = "Exit";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Add";
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MenuStrip.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(884, 25);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(22, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(142, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(82, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 48);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(870, 580);
            this.Name = "MainForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label ShowCategory;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

