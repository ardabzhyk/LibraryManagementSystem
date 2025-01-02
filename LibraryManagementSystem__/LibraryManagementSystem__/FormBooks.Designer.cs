namespace LibraryManagementSystem__
{
    partial class FormBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooks));
            groupBox1 = new GroupBox();
            groupBoxRecordEditing = new GroupBox();
            buttonNewBookAdd = new Button();
            buttonUpdateBookİnformation = new Button();
            buttonBookDelete = new Button();
            groupBoxSearch = new GroupBox();
            buttonDataShow = new Button();
            buttonSearch = new Button();
            buttonClear = new Button();
            textBoxBookTypeCode = new TextBox();
            textBoxISBN = new TextBox();
            textBoxWriterSurname = new TextBox();
            textBoxWriterName = new TextBox();
            textBoxBookName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelID = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonLendTheBook = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBoxBorrower = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox = new GroupBox();
            label12 = new Label();
            labelReturnLateFee = new Label();
            buttonBookReturn = new Button();
            buttonCalculateReturnLateFee = new Button();
            label10 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBoxRecordEditing.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBoxRecordEditing);
            groupBox1.Controls.Add(groupBoxSearch);
            groupBox1.Controls.Add(textBoxBookTypeCode);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxWriterSurname);
            groupBox1.Controls.Add(textBoxWriterName);
            groupBox1.Controls.Add(textBoxBookName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 375);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Record Update";
            // 
            // groupBoxRecordEditing
            // 
            groupBoxRecordEditing.Controls.Add(buttonNewBookAdd);
            groupBoxRecordEditing.Controls.Add(buttonUpdateBookİnformation);
            groupBoxRecordEditing.Controls.Add(buttonBookDelete);
            groupBoxRecordEditing.Location = new Point(13, 292);
            groupBoxRecordEditing.Name = "groupBoxRecordEditing";
            groupBoxRecordEditing.Size = new Size(364, 71);
            groupBoxRecordEditing.TabIndex = 19;
            groupBoxRecordEditing.TabStop = false;
            groupBoxRecordEditing.Text = "Record Editing";
            // 
            // buttonNewBookAdd
            // 
            buttonNewBookAdd.BackColor = SystemColors.WindowText;
            buttonNewBookAdd.ForeColor = SystemColors.ButtonFace;
            buttonNewBookAdd.Location = new Point(131, 19);
            buttonNewBookAdd.Name = "buttonNewBookAdd";
            buttonNewBookAdd.Size = new Size(105, 44);
            buttonNewBookAdd.TabIndex = 12;
            buttonNewBookAdd.Text = "New Book Add";
            buttonNewBookAdd.UseVisualStyleBackColor = false;
            buttonNewBookAdd.Click += buttonNewBookAdd_Click;
            // 
            // buttonUpdateBookİnformation
            // 
            buttonUpdateBookİnformation.BackColor = SystemColors.WindowText;
            buttonUpdateBookİnformation.ForeColor = SystemColors.ButtonFace;
            buttonUpdateBookİnformation.Location = new Point(16, 21);
            buttonUpdateBookİnformation.Name = "buttonUpdateBookİnformation";
            buttonUpdateBookİnformation.Size = new Size(109, 40);
            buttonUpdateBookİnformation.TabIndex = 13;
            buttonUpdateBookİnformation.Text = "Update Book İnformation";
            buttonUpdateBookİnformation.UseVisualStyleBackColor = false;
            buttonUpdateBookİnformation.Click += buttonUpdateBookİnformation_Click;
            // 
            // buttonBookDelete
            // 
            buttonBookDelete.BackColor = SystemColors.WindowText;
            buttonBookDelete.ForeColor = SystemColors.ButtonFace;
            buttonBookDelete.Location = new Point(242, 19);
            buttonBookDelete.Name = "buttonBookDelete";
            buttonBookDelete.Size = new Size(104, 44);
            buttonBookDelete.TabIndex = 17;
            buttonBookDelete.Text = "Book Delete";
            buttonBookDelete.UseVisualStyleBackColor = false;
            buttonBookDelete.Click += buttonBookDelete_Click;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(buttonDataShow);
            groupBoxSearch.Controls.Add(buttonSearch);
            groupBoxSearch.Controls.Add(buttonClear);
            groupBoxSearch.Location = new Point(383, 292);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(341, 71);
            groupBoxSearch.TabIndex = 18;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // buttonDataShow
            // 
            buttonDataShow.BackColor = SystemColors.WindowText;
            buttonDataShow.ForeColor = SystemColors.ButtonFace;
            buttonDataShow.Location = new Point(228, 17);
            buttonDataShow.Name = "buttonDataShow";
            buttonDataShow.Size = new Size(107, 44);
            buttonDataShow.TabIndex = 16;
            buttonDataShow.Text = "Data Show";
            buttonDataShow.UseVisualStyleBackColor = false;
            buttonDataShow.Click += buttonDataShow_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.WindowText;
            buttonSearch.ForeColor = SystemColors.ButtonFace;
            buttonSearch.Location = new Point(115, 17);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(107, 44);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.WindowText;
            buttonClear.ForeColor = SystemColors.ButtonFace;
            buttonClear.Location = new Point(6, 17);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(103, 44);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxBookTypeCode
            // 
            textBoxBookTypeCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxBookTypeCode.Location = new Point(201, 256);
            textBoxBookTypeCode.Name = "textBoxBookTypeCode";
            textBoxBookTypeCode.Size = new Size(158, 25);
            textBoxBookTypeCode.TabIndex = 11;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxISBN.Location = new Point(201, 197);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(158, 25);
            textBoxISBN.TabIndex = 10;
            // 
            // textBoxWriterSurname
            // 
            textBoxWriterSurname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxWriterSurname.Location = new Point(201, 144);
            textBoxWriterSurname.Name = "textBoxWriterSurname";
            textBoxWriterSurname.Size = new Size(318, 25);
            textBoxWriterSurname.TabIndex = 9;
            // 
            // textBoxWriterName
            // 
            textBoxWriterName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxWriterName.Location = new Point(201, 96);
            textBoxWriterName.Name = "textBoxWriterName";
            textBoxWriterName.Size = new Size(318, 25);
            textBoxWriterName.TabIndex = 8;
            // 
            // textBoxBookName
            // 
            textBoxBookName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxBookName.Location = new Point(201, 52);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(318, 25);
            textBoxBookName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(22, 96);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 6;
            label7.Text = "Writer Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(22, 144);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 5;
            label6.Text = "Writer Surname :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(22, 256);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 4;
            label5.Text = "Book Type Code :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(22, 197);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "ISBN  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(22, 49);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 2;
            label3.Text = "Book Name :";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelID.Location = new Point(157, 16);
            labelID.Name = "labelID";
            labelID.Size = new Size(16, 21);
            labelID.TabIndex = 1;
            labelID.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Book ID :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(buttonLendTheBook);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBoxBorrower);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(752, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 375);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Borrow a Book";
            // 
            // buttonLendTheBook
            // 
            buttonLendTheBook.BackColor = SystemColors.WindowText;
            buttonLendTheBook.ForeColor = SystemColors.ButtonFace;
            buttonLendTheBook.Location = new Point(105, 157);
            buttonLendTheBook.Name = "buttonLendTheBook";
            buttonLendTheBook.Size = new Size(131, 50);
            buttonLendTheBook.TabIndex = 14;
            buttonLendTheBook.Text = "Lend the book";
            buttonLendTheBook.UseVisualStyleBackColor = false;
            buttonLendTheBook.Click += buttonLendTheBook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBoxBorrower
            // 
            textBoxBorrower.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxBorrower.Location = new Point(165, 31);
            textBoxBorrower.Name = "textBoxBorrower";
            textBoxBorrower.Size = new Size(158, 25);
            textBoxBorrower.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label9.Location = new Point(6, 75);
            label9.Name = "label9";
            label9.Size = new Size(153, 25);
            label9.TabIndex = 4;
            label9.Text = "Borrower Date :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(6, 28);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 3;
            label8.Text = "Borrower : ";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label12);
            groupBox.Controls.Add(labelReturnLateFee);
            groupBox.Controls.Add(buttonBookReturn);
            groupBox.Controls.Add(buttonCalculateReturnLateFee);
            groupBox.Controls.Add(label10);
            groupBox.Location = new Point(1120, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(275, 375);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Book Return";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label12.Location = new Point(218, 56);
            label12.Name = "label12";
            label12.Size = new Size(33, 25);
            label12.TabIndex = 15;
            label12.Text = "TL";
            // 
            // labelReturnLateFee
            // 
            labelReturnLateFee.AutoSize = true;
            labelReturnLateFee.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelReturnLateFee.Location = new Point(171, 56);
            labelReturnLateFee.Name = "labelReturnLateFee";
            labelReturnLateFee.Size = new Size(23, 25);
            labelReturnLateFee.TabIndex = 10;
            labelReturnLateFee.Text = "0";
            // 
            // buttonBookReturn
            // 
            buttonBookReturn.BackColor = SystemColors.WindowText;
            buttonBookReturn.ForeColor = SystemColors.ButtonFace;
            buttonBookReturn.Location = new Point(74, 224);
            buttonBookReturn.Name = "buttonBookReturn";
            buttonBookReturn.Size = new Size(145, 48);
            buttonBookReturn.TabIndex = 14;
            buttonBookReturn.Text = "Book Return";
            buttonBookReturn.UseVisualStyleBackColor = false;
            buttonBookReturn.Click += buttonBookReturn_Click;
            // 
            // buttonCalculateReturnLateFee
            // 
            buttonCalculateReturnLateFee.BackColor = SystemColors.WindowText;
            buttonCalculateReturnLateFee.ForeColor = SystemColors.ButtonFace;
            buttonCalculateReturnLateFee.Location = new Point(74, 135);
            buttonCalculateReturnLateFee.Name = "buttonCalculateReturnLateFee";
            buttonCalculateReturnLateFee.Size = new Size(145, 50);
            buttonCalculateReturnLateFee.TabIndex = 13;
            buttonCalculateReturnLateFee.Text = "Calculate return late fee";
            buttonCalculateReturnLateFee.UseVisualStyleBackColor = false;
            buttonCalculateReturnLateFee.Click += buttonCalculateReturnLateFee_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label10.Location = new Point(0, 56);
            label10.Name = "label10";
            label10.Size = new Size(165, 25);
            label10.TabIndex = 4;
            label10.Text = "Return Late Fee : ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 393);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1378, 261);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Book List";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1372, 239);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1407, 666);
            Controls.Add(groupBox4);
            Controls.Add(groupBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBooks";
            Text = "Libray Management System";
            FormClosed += FormBooks_FormClosed;
            Load += FormBooks_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxRecordEditing.ResumeLayout(false);
            groupBoxSearch.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelID;
        private Label label1;
        private TextBox textBoxBookTypeCode;
        private TextBox textBoxISBN;
        private TextBox textBoxWriterSurname;
        private TextBox textBoxWriterName;
        private TextBox textBoxBookName;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button buttonUpdateBookİnformation;
        private Button buttonNewBookAdd;
        private Label label9;
        private Label label8;
        private TextBox textBoxBorrower;
        private DateTimePicker dateTimePicker1;
        private Button buttonCalculateReturnLateFee;
        private Label label10;
        private Label label12;
        private Label labelReturnLateFee;
        private Button buttonBookReturn;
        private Button buttonLendTheBook;
        private Button buttonSearch;
        private Button buttonClear;
        private Button buttonDataShow;
        private Button buttonBookDelete;
        private GroupBox groupBoxSearch;
        private GroupBox groupBoxRecordEditing;
    }
}