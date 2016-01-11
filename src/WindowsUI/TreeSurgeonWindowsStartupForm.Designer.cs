namespace TreeSurgeon.WindowsUI
{
    partial class TreeSurgeonWindowsStartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeSurgeonWindowsStartupForm));
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.exitButton = new System.Windows.Forms.Button();
            this.version2003RadioButton = new System.Windows.Forms.RadioButton();
            this.version2005RadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.version2008RadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.nunitRadionButton = new System.Windows.Forms.RadioButton();
            this.mbunitRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(168, 3);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(311, 20);
            this.projectNameTextBox.TabIndex = 1;
            this.projectNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Project Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // generateButton
            // 
            this.generateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.generateButton.Location = new System.Drawing.Point(366, 423);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(72, 23);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesTextBox.Location = new System.Drawing.Point(168, 75);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ReadOnly = true;
            this.messagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messagesTextBox.Size = new System.Drawing.Size(311, 210);
            this.messagesTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 216);
            this.label4.TabIndex = 6;
            this.label4.Text = "Messages:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(256, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(248, 23);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tree Surgeon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(444, 423);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // version2003RadioButton
            // 
            this.version2003RadioButton.AutoSize = true;
            this.version2003RadioButton.Location = new System.Drawing.Point(3, 3);
            this.version2003RadioButton.Name = "version2003RadioButton";
            this.version2003RadioButton.Size = new System.Drawing.Size(49, 17);
            this.version2003RadioButton.TabIndex = 3;
            this.version2003RadioButton.Text = "2003";
            this.version2003RadioButton.UseVisualStyleBackColor = true;
            // 
            // version2005RadioButton
            // 
            this.version2005RadioButton.AutoSize = true;
            this.version2005RadioButton.Checked = true;
            this.version2005RadioButton.Location = new System.Drawing.Point(58, 3);
            this.version2005RadioButton.Name = "version2005RadioButton";
            this.version2005RadioButton.Size = new System.Drawing.Size(49, 17);
            this.version2005RadioButton.TabIndex = 4;
            this.version2005RadioButton.TabStop = true;
            this.version2005RadioButton.Text = "2005";
            this.version2005RadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Visual Studio Version:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // version2008RadioButton
            // 
            this.version2008RadioButton.AutoSize = true;
            this.version2008RadioButton.Location = new System.Drawing.Point(113, 3);
            this.version2008RadioButton.Name = "version2008RadioButton";
            this.version2008RadioButton.Size = new System.Drawing.Size(49, 17);
            this.version2008RadioButton.TabIndex = 5;
            this.version2008RadioButton.TabStop = true;
            this.version2008RadioButton.Text = "2008";
            this.version2008RadioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.60378F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.39622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 405);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "It is recommended that project names don\'t have spaces - use camel case LikeThis " +
                "instead.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Welcome to";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Just enter the name for your new project and hit \'Generate\'!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 313);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution Configuration";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.42879F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.57121F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.projectNameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.messagesTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 288);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.version2003RadioButton);
            this.flowLayoutPanel1.Controls.Add(this.version2005RadioButton);
            this.flowLayoutPanel1.Controls.Add(this.version2008RadioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(168, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 18);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Unit Test Framework:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.nunitRadionButton);
            this.flowLayoutPanel2.Controls.Add(this.mbunitRadioButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(168, 51);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(311, 18);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // nunitRadionButton
            // 
            this.nunitRadionButton.AutoSize = true;
            this.nunitRadionButton.Checked = true;
            this.nunitRadionButton.Location = new System.Drawing.Point(3, 3);
            this.nunitRadionButton.Name = "nunitRadionButton";
            this.nunitRadionButton.Size = new System.Drawing.Size(52, 17);
            this.nunitRadionButton.TabIndex = 0;
            this.nunitRadionButton.TabStop = true;
            this.nunitRadionButton.Text = "NUnit";
            this.nunitRadionButton.UseVisualStyleBackColor = true;
            // 
            // mbunitRadioButton
            // 
            this.mbunitRadioButton.AutoSize = true;
            this.mbunitRadioButton.Location = new System.Drawing.Point(61, 3);
            this.mbunitRadioButton.Name = "mbunitRadioButton";
            this.mbunitRadioButton.Size = new System.Drawing.Size(59, 17);
            this.mbunitRadioButton.TabIndex = 1;
            this.mbunitRadioButton.Text = "MbUnit";
            this.mbunitRadioButton.UseVisualStyleBackColor = true;
            // 
            // TreeSurgeonWindowsStartupForm
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TreeSurgeonWindowsStartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree Surgeon";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.RadioButton version2003RadioButton;
        private System.Windows.Forms.RadioButton version2005RadioButton;
        private System.Windows.Forms.RadioButton version2008RadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton nunitRadionButton;
        private System.Windows.Forms.RadioButton mbunitRadioButton;
    }
}