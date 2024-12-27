namespace Tyuiu.HoteevaEV.Sprint6.Task7.V16
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelHead = new Panel();
            buttonInfo = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            panelDown = new Panel();
            groupBoxOut = new GroupBox();
            dataGridViewOut = new DataGridView();
            groupBoxIn = new GroupBox();
            dataGridViewIn = new DataGridView();
            panelMiddle = new Panel();
            groupBoxUslovie = new GroupBox();
            textBoxUslovie = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            toolTipButton = new ToolTip(components);
            panelHead.SuspendLayout();
            panelDown.SuspendLayout();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panelMiddle.SuspendLayout();
            groupBoxUslovie.SuspendLayout();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.Controls.Add(buttonInfo);
            panelHead.Controls.Add(buttonSave);
            panelHead.Controls.Add(buttonDone);
            panelHead.Controls.Add(buttonOpenFile);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(1349, 92);
            panelHead.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackColor = SystemColors.ButtonHighlight;
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.Location = new Point(1244, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(93, 67);
            buttonInfo.TabIndex = 3;
            toolTipButton.SetToolTip(buttonInfo, "Сведения о программе");
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ButtonHighlight;
            buttonSave.Enabled = false;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(260, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(93, 67);
            buttonSave.TabIndex = 2;
            toolTipButton.SetToolTip(buttonSave, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ButtonHighlight;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(132, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(93, 67);
            buttonDone.TabIndex = 1;
            toolTipButton.SetToolTip(buttonDone, "Выполнить обработку данных");
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = SystemColors.ButtonHighlight;
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(93, 67);
            buttonOpenFile.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpenFile, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // panelDown
            // 
            panelDown.Controls.Add(groupBoxOut);
            panelDown.Controls.Add(groupBoxIn);
            panelDown.Dock = DockStyle.Bottom;
            panelDown.Location = new Point(0, 230);
            panelDown.Name = "panelDown";
            panelDown.Size = new Size(1349, 480);
            panelDown.TabIndex = 0;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(dataGridViewOut);
            groupBoxOut.Location = new Point(689, 0);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(648, 468);
            groupBoxOut.TabIndex = 1;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(6, 43);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 62;
            dataGridViewOut.Size = new Size(636, 406);
            dataGridViewOut.TabIndex = 1;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(dataGridViewIn);
            groupBoxIn.Location = new Point(12, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(671, 468);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(15, 43);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 62;
            dataGridViewIn.Size = new Size(650, 406);
            dataGridViewIn.TabIndex = 0;
            // 
            // panelMiddle
            // 
            panelMiddle.Controls.Add(groupBoxUslovie);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 92);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(1349, 138);
            panelMiddle.TabIndex = 0;
            // 
            // groupBoxUslovie
            // 
            groupBoxUslovie.Controls.Add(textBoxUslovie);
            groupBoxUslovie.Location = new Point(12, 0);
            groupBoxUslovie.Name = "groupBoxUslovie";
            groupBoxUslovie.Size = new Size(1292, 132);
            groupBoxUslovie.TabIndex = 0;
            groupBoxUslovie.TabStop = false;
            groupBoxUslovie.Text = "Условие:";
            // 
            // textBoxUslovie
            // 
            textBoxUslovie.BackColor = SystemColors.Control;
            textBoxUslovie.BorderStyle = BorderStyle.None;
            textBoxUslovie.Location = new Point(3, 27);
            textBoxUslovie.Multiline = true;
            textBoxUslovie.Name = "textBoxUslovie";
            textBoxUslovie.ReadOnly = true;
            textBoxUslovie.Size = new Size(1283, 99);
            textBoxUslovie.TabIndex = 0;
            textBoxUslovie.Text = resources.GetString("textBoxUslovie.Text");
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // saveFileDialogMatrix
            // 
            saveFileDialogMatrix.FileName = "saveFileDialogMatrix";
            // 
            // toolTipButton
            // 
            toolTipButton.ForeColor = SystemColors.Highlight;
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 710);
            Controls.Add(panelMiddle);
            Controls.Add(panelDown);
            Controls.Add(panelHead);
            MinimumSize = new Size(1371, 766);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 16 | Хотеева Е. В.";
            Load += FormMain_Load;
            panelHead.ResumeLayout(false);
            panelDown.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panelMiddle.ResumeLayout(false);
            groupBoxUslovie.ResumeLayout(false);
            groupBoxUslovie.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Panel panelDown;
        private Button buttonOpenFile;
        private Panel panelMiddle;
        private Button buttonInfo;
        private Button buttonSave;
        private Button buttonDone;
        private GroupBox groupBoxUslovie;
        private TextBox textBoxUslovie;
        private GroupBox groupBoxOut;
        private DataGridView dataGridViewOut;
        private GroupBox groupBoxIn;
        private DataGridView dataGridViewIn;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private ToolTip toolTipButton;
    }
}
