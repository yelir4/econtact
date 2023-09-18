namespace econtact
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbContact = new Label();
            lbFirst = new Label();
            lbLast = new Label();
            label2 = new Label();
            lbAddress = new Label();
            lbGender = new Label();
            tbContact = new TextBox();
            tbFirst = new TextBox();
            tbLast = new TextBox();
            tbNumber = new TextBox();
            tbAddress = new TextBox();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            openForm2Button = new Button();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            lbData = new Label();
            tbSearch = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolExit = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolAbout = new ToolStripMenuItem();
            openForm1Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._09_14_fit_check;
            pictureBox1.Location = new Point(156, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 174);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 25);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "hello everyone";
            label1.Click += label1_Click;
            // 
            // lbContact
            // 
            lbContact.AutoSize = true;
            lbContact.Location = new Point(85, 240);
            lbContact.Name = "lbContact";
            lbContact.Size = new Size(60, 15);
            lbContact.TabIndex = 3;
            lbContact.Text = "contact id";
            lbContact.Click += label2_Click;
            // 
            // lbFirst
            // 
            lbFirst.AutoSize = true;
            lbFirst.Location = new Point(85, 268);
            lbFirst.Name = "lbFirst";
            lbFirst.Size = new Size(60, 15);
            lbFirst.TabIndex = 4;
            lbFirst.Text = "first name";
            // 
            // lbLast
            // 
            lbLast.AutoSize = true;
            lbLast.Location = new Point(85, 298);
            lbLast.Name = "lbLast";
            lbLast.Size = new Size(58, 15);
            lbLast.TabIndex = 5;
            lbLast.Text = "last name";
            lbLast.Click += label2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 328);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "number";
            label2.Click += label2_Click_2;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(85, 359);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(47, 15);
            lbAddress.TabIndex = 7;
            lbAddress.Text = "address";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(88, 405);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(44, 15);
            lbGender.TabIndex = 8;
            lbGender.Text = "gender";
            lbGender.Click += label3_Click;
            // 
            // tbContact
            // 
            tbContact.Location = new Point(156, 237);
            tbContact.Name = "tbContact";
            tbContact.Size = new Size(100, 23);
            tbContact.TabIndex = 9;
            // 
            // tbFirst
            // 
            tbFirst.Location = new Point(176, 268);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(100, 23);
            tbFirst.TabIndex = 10;
            // 
            // tbLast
            // 
            tbLast.Location = new Point(176, 295);
            tbLast.Name = "tbLast";
            tbLast.Size = new Size(100, 23);
            tbLast.TabIndex = 11;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(176, 324);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(100, 23);
            tbNumber.TabIndex = 12;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(153, 359);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(100, 42);
            tbAddress.TabIndex = 13;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "yes", "no" });
            cmbGender.Location = new Point(156, 407);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.ForestGreen;
            btnAdd.Location = new Point(392, 240);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseLeave += btnAdd_MouseLeave;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(392, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Brown;
            btnDelete.Location = new Point(392, 342);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(392, 397);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 18;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // openForm2Button
            // 
            openForm2Button.Location = new Point(0, 0);
            openForm2Button.Name = "openForm2Button";
            openForm2Button.Size = new Size(75, 23);
            openForm2Button.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._05_30_ACTUALLY_mok_o_;
            pictureBox2.Location = new Point(690, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(205, 182);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(564, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(282, 143);
            dataGridView1.TabIndex = 20;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(564, 263);
            lbData.Name = "lbData";
            lbData.Size = new Size(199, 15);
            lbData.TabIndex = 21;
            lbData.Text = "data grid view: search for something";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(769, 255);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(126, 23);
            tbSearch.TabIndex = 22;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(907, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // toolExit
            // 
            toolExit.Name = "toolExit";
            toolExit.Size = new Size(93, 22);
            toolExit.Text = "E&xit";
            toolExit.Click += toolExit_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolAbout });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // toolAbout
            // 
            toolAbout.Name = "toolAbout";
            toolAbout.Size = new Size(107, 22);
            toolAbout.Text = "&About";
            toolAbout.Click += toolAbout_Click;
            // 
            // openForm1Button
            // 
            openForm1Button.Location = new Point(505, 127);
            openForm1Button.Name = "openForm1Button";
            openForm1Button.Size = new Size(75, 23);
            openForm1Button.TabIndex = 24;
            openForm1Button.Text = "openForm1";
            openForm1Button.UseVisualStyleBackColor = true;
            openForm1Button.Click += openForm1Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(openForm1Button);
            Controls.Add(tbSearch);
            Controls.Add(lbData);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbGender);
            Controls.Add(tbAddress);
            Controls.Add(tbNumber);
            Controls.Add(tbLast);
            Controls.Add(tbFirst);
            Controls.Add(tbContact);
            Controls.Add(lbGender);
            Controls.Add(lbAddress);
            Controls.Add(label2);
            Controls.Add(lbLast);
            Controls.Add(lbFirst);
            Controls.Add(lbContact);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "econtact, 003";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbContact;
        private Label lbFirst;
        private Label lbLast;
        private Label label2;
        private Label lbAddress;
        private Label lbGender;
        private TextBox tbContact;
        private TextBox tbFirst;
        private TextBox tbLast;
        private TextBox tbNumber;
        private TextBox tbAddress;
        private ComboBox cmbGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button openForm2Button;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Label lbData;
        private TextBox tbSearch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem toolAbout;
        private Button openForm1Button;
    }
}