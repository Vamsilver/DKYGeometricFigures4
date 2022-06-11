
namespace DKYGeometricFigures4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figuresTools = new System.Windows.Forms.ToolStrip();
            this.LineBtn = new System.Windows.Forms.ToolStripButton();
            this.TrinagleBtn = new System.Windows.Forms.ToolStripButton();
            this.RectangleBtn = new System.Windows.Forms.ToolStripButton();
            this.CircleBtn = new System.Windows.Forms.ToolStripButton();
            this.ChangeStrokeColorDialog = new System.Windows.Forms.ColorDialog();
            this.ChangeFillColorDialog = new System.Windows.Forms.ColorDialog();
            this.workplace = new System.Windows.Forms.Panel();
            this.ChangeStrokeColorBtn = new System.Windows.Forms.Button();
            this.ChangeFillColorBtn = new System.Windows.Forms.Button();
            this.ChangeFillColorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeStrokeDataLabel = new System.Windows.Forms.Label();
            this.ChangeStrokeWidthTB = new System.Windows.Forms.TextBox();
            this.GroupFigureSettings = new System.Windows.Forms.GroupBox();
            this.FileMenuStrip.SuspendLayout();
            this.figuresTools.SuspendLayout();
            this.GroupFigureSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.FileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(1268, 24);
            this.FileMenuStrip.TabIndex = 1;
            this.FileMenuStrip.Text = "menuStrip2";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // figuresTools
            // 
            this.figuresTools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.figuresTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.figuresTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineBtn,
            this.TrinagleBtn,
            this.RectangleBtn,
            this.CircleBtn});
            this.figuresTools.Location = new System.Drawing.Point(0, 24);
            this.figuresTools.Name = "figuresTools";
            this.figuresTools.Size = new System.Drawing.Size(24, 611);
            this.figuresTools.TabIndex = 2;
            this.figuresTools.Text = "toolStrip1";
            // 
            // LineBtn
            // 
            this.LineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineBtn.Image = ((System.Drawing.Image)(resources.GetObject("LineBtn.Image")));
            this.LineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(21, 20);
            this.LineBtn.Text = "Line";
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // TrinagleBtn
            // 
            this.TrinagleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TrinagleBtn.Image = ((System.Drawing.Image)(resources.GetObject("TrinagleBtn.Image")));
            this.TrinagleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TrinagleBtn.Name = "TrinagleBtn";
            this.TrinagleBtn.Size = new System.Drawing.Size(21, 20);
            this.TrinagleBtn.Text = "Triangle";
            this.TrinagleBtn.Click += new System.EventHandler(this.TrinagleBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleBtn.Image = ((System.Drawing.Image)(resources.GetObject("RectangleBtn.Image")));
            this.RectangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(21, 20);
            this.RectangleBtn.Text = "toolStripButton1";
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CircleBtn.Image = ((System.Drawing.Image)(resources.GetObject("CircleBtn.Image")));
            this.CircleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(21, 20);
            this.CircleBtn.Text = "toolStripButton1";
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // workplace
            // 
            this.workplace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.workplace.Cursor = System.Windows.Forms.Cursors.Cross;
            this.workplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workplace.Location = new System.Drawing.Point(24, 24);
            this.workplace.Name = "workplace";
            this.workplace.Size = new System.Drawing.Size(1044, 611);
            this.workplace.TabIndex = 0;
            this.workplace.Paint += new System.Windows.Forms.PaintEventHandler(this.workplace_Paint);
            this.workplace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workplace_MouseDown);
            this.workplace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.workplace_MouseMove);
            this.workplace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.workplace_MouseUp);
            // 
            // ChangeStrokeColorBtn
            // 
            this.ChangeStrokeColorBtn.Location = new System.Drawing.Point(100, 79);
            this.ChangeStrokeColorBtn.Name = "ChangeStrokeColorBtn";
            this.ChangeStrokeColorBtn.Size = new System.Drawing.Size(66, 38);
            this.ChangeStrokeColorBtn.TabIndex = 2;
            this.ChangeStrokeColorBtn.Text = "\r\n";
            this.ChangeStrokeColorBtn.UseVisualStyleBackColor = true;
            this.ChangeStrokeColorBtn.Click += new System.EventHandler(this.ChangeStrokeColorBtn_Click);
            // 
            // ChangeFillColorBtn
            // 
            this.ChangeFillColorBtn.Location = new System.Drawing.Point(100, 139);
            this.ChangeFillColorBtn.Name = "ChangeFillColorBtn";
            this.ChangeFillColorBtn.Size = new System.Drawing.Size(66, 38);
            this.ChangeFillColorBtn.TabIndex = 3;
            this.ChangeFillColorBtn.UseVisualStyleBackColor = true;
            this.ChangeFillColorBtn.Click += new System.EventHandler(this.ChangeFillColorBtn_Click);
            // 
            // ChangeFillColorLabel
            // 
            this.ChangeFillColorLabel.AutoSize = true;
            this.ChangeFillColorLabel.Location = new System.Drawing.Point(20, 136);
            this.ChangeFillColorLabel.Name = "ChangeFillColorLabel";
            this.ChangeFillColorLabel.Size = new System.Drawing.Size(48, 45);
            this.ChangeFillColorLabel.TabIndex = 5;
            this.ChangeFillColorLabel.Text = "Change\r\nfill\r\ncolor\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change\r\nstroke \r\ncolor\r\n";
            // 
            // ChangeStrokeDataLabel
            // 
            this.ChangeStrokeDataLabel.AutoSize = true;
            this.ChangeStrokeDataLabel.Location = new System.Drawing.Point(20, 22);
            this.ChangeStrokeDataLabel.Name = "ChangeStrokeDataLabel";
            this.ChangeStrokeDataLabel.Size = new System.Drawing.Size(48, 45);
            this.ChangeStrokeDataLabel.TabIndex = 0;
            this.ChangeStrokeDataLabel.Text = "Change\r\nstroke\r\nwidth ";
            this.ChangeStrokeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeStrokeWidthTB
            // 
            this.ChangeStrokeWidthTB.Location = new System.Drawing.Point(100, 30);
            this.ChangeStrokeWidthTB.Name = "ChangeStrokeWidthTB";
            this.ChangeStrokeWidthTB.Size = new System.Drawing.Size(66, 23);
            this.ChangeStrokeWidthTB.TabIndex = 1;
            this.ChangeStrokeWidthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChangeStrokeWidthTB_KeyPress);
            // 
            // GroupFigureSettings
            // 
            this.GroupFigureSettings.Controls.Add(this.ChangeFillColorLabel);
            this.GroupFigureSettings.Controls.Add(this.ChangeStrokeDataLabel);
            this.GroupFigureSettings.Controls.Add(this.label2);
            this.GroupFigureSettings.Controls.Add(this.ChangeStrokeWidthTB);
            this.GroupFigureSettings.Controls.Add(this.ChangeStrokeColorBtn);
            this.GroupFigureSettings.Controls.Add(this.ChangeFillColorBtn);
            this.GroupFigureSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupFigureSettings.Location = new System.Drawing.Point(1068, 24);
            this.GroupFigureSettings.Name = "GroupFigureSettings";
            this.GroupFigureSettings.Size = new System.Drawing.Size(200, 611);
            this.GroupFigureSettings.TabIndex = 3;
            this.GroupFigureSettings.TabStop = false;
            this.GroupFigureSettings.Text = "Figure settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 635);
            this.Controls.Add(this.workplace);
            this.Controls.Add(this.GroupFigureSettings);
            this.Controls.Add(this.figuresTools);
            this.Controls.Add(this.FileMenuStrip);
            this.Name = "MainForm";
            this.Text = "Main";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.FileMenuStrip.ResumeLayout(false);
            this.FileMenuStrip.PerformLayout();
            this.figuresTools.ResumeLayout(false);
            this.figuresTools.PerformLayout();
            this.GroupFigureSettings.ResumeLayout(false);
            this.GroupFigureSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStrip figuresTools;
        private System.Windows.Forms.ToolStripButton LineBtn;
        private System.Windows.Forms.ToolStripButton TrinagleBtn;
        private System.Windows.Forms.ToolStripButton RectangleBtn;
        private System.Windows.Forms.ToolStripButton CircleBtn;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ColorDialog ChangeStrokeColorDialog;
        private System.Windows.Forms.ColorDialog ChangeFillColorDialog;
        public System.Windows.Forms.Panel workplace;
        private System.Windows.Forms.Button ChangeStrokeColorBtn;
        private System.Windows.Forms.Button ChangeFillColorBtn;
        private System.Windows.Forms.Label ChangeFillColorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ChangeStrokeDataLabel;
        private System.Windows.Forms.TextBox ChangeStrokeWidthTB;
        private System.Windows.Forms.GroupBox GroupFigureSettings;
    }
}

