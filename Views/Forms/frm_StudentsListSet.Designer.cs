namespace EduProfFiler.Views.Forms
{
    partial class frm_StudentsListSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StudentsListSet));
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            btn_Add = new DevExpress.XtraEditors.SimpleButton();
            btn_Search = new DevExpress.XtraEditors.SimpleButton();
            groupBox2 = new GroupBox();
            btn_First = new DevExpress.XtraEditors.SimpleButton();
            btn_Previous = new DevExpress.XtraEditors.SimpleButton();
            btn_Next = new DevExpress.XtraEditors.SimpleButton();
            btn_Last = new DevExpress.XtraEditors.SimpleButton();
            groupBox1 = new GroupBox();
            txt_StNotes = new TextBox();
            label5 = new Label();
            txt_StDOB = new TextBox();
            label3 = new Label();
            txt_StGender = new TextBox();
            label4 = new Label();
            txt_StName = new TextBox();
            label2 = new Label();
            txt_StCode = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 270);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(576, 191);
            dataGridView1.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Delete);
            groupBox3.Controls.Add(btn_Edit);
            groupBox3.Controls.Add(btn_Add);
            groupBox3.Controls.Add(btn_Search);
            groupBox3.Location = new Point(237, 170);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(350, 92);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "العمليات المتاحة";
            // 
            // btn_Delete
            // 
            btn_Delete.Appearance.Font = new Font("Droid Arabic Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Delete.Appearance.Options.UseFont = true;
            btn_Delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_Delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Delete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Delete.ImageOptions.SvgImage");
            btn_Delete.Location = new Point(15, 31);
            btn_Delete.Margin = new Padding(3, 4, 3, 4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(76, 35);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "حذف";
            // 
            // btn_Edit
            // 
            btn_Edit.Appearance.Font = new Font("Droid Arabic Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Edit.Appearance.Options.UseFont = true;
            btn_Edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_Edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Edit.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Edit.ImageOptions.SvgImage");
            btn_Edit.Location = new Point(97, 31);
            btn_Edit.Margin = new Padding(3, 4, 3, 4);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(76, 35);
            btn_Edit.TabIndex = 2;
            btn_Edit.Text = "تعديل";
            // 
            // btn_Add
            // 
            btn_Add.Appearance.Font = new Font("Droid Arabic Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.Appearance.Options.UseFont = true;
            btn_Add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_Add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Add.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Add.ImageOptions.SvgImage");
            btn_Add.Location = new Point(179, 31);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(76, 35);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "إضافة";
            // 
            // btn_Search
            // 
            btn_Search.Appearance.Font = new Font("Droid Arabic Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Search.Appearance.Options.UseFont = true;
            btn_Search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_Search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Search.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Search.ImageOptions.SvgImage");
            btn_Search.Location = new Point(261, 31);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(76, 35);
            btn_Search.TabIndex = 0;
            btn_Search.Text = "بحث";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_First);
            groupBox2.Controls.Add(btn_Previous);
            groupBox2.Controls.Add(btn_Next);
            groupBox2.Controls.Add(btn_Last);
            groupBox2.Location = new Point(11, 170);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(211, 92);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "التنقل بين التلاميذ";
            // 
            // btn_First
            // 
            btn_First.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_First.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_First.ImageOptions.SvgImage");
            btn_First.Location = new Point(10, 31);
            btn_First.Margin = new Padding(3, 4, 3, 4);
            btn_First.Name = "btn_First";
            btn_First.Size = new Size(38, 35);
            btn_First.TabIndex = 3;
            // 
            // btn_Previous
            // 
            btn_Previous.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Previous.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Previous.ImageOptions.SvgImage");
            btn_Previous.Location = new Point(61, 31);
            btn_Previous.Margin = new Padding(3, 4, 3, 4);
            btn_Previous.Name = "btn_Previous";
            btn_Previous.Size = new Size(38, 35);
            btn_Previous.TabIndex = 2;
            btn_Previous.Click += btn_Previous_Click;
            // 
            // btn_Next
            // 
            btn_Next.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Next.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Next.ImageOptions.SvgImage");
            btn_Next.Location = new Point(112, 31);
            btn_Next.Margin = new Padding(3, 4, 3, 4);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(38, 35);
            btn_Next.TabIndex = 1;
            // 
            // btn_Last
            // 
            btn_Last.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Last.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Last.ImageOptions.SvgImage");
            btn_Last.Location = new Point(163, 31);
            btn_Last.Margin = new Padding(3, 4, 3, 4);
            btn_Last.Name = "btn_Last";
            btn_Last.Size = new Size(38, 35);
            btn_Last.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_StNotes);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_StDOB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_StGender);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_StName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_StCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(576, 149);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات التلميذ";
            // 
            // txt_StNotes
            // 
            txt_StNotes.Location = new Point(17, 107);
            txt_StNotes.Margin = new Padding(3, 4, 3, 4);
            txt_StNotes.Name = "txt_StNotes";
            txt_StNotes.Size = new Size(478, 30);
            txt_StNotes.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(507, 112);
            label5.Name = "label5";
            label5.Size = new Size(60, 22);
            label5.TabIndex = 8;
            label5.Text = "ملاحظات:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_StDOB
            // 
            txt_StDOB.Location = new Point(17, 69);
            txt_StDOB.Margin = new Padding(3, 4, 3, 4);
            txt_StDOB.Name = "txt_StDOB";
            txt_StDOB.Size = new Size(174, 30);
            txt_StDOB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(206, 74);
            label3.Name = "label3";
            label3.Size = new Size(76, 22);
            label3.TabIndex = 6;
            label3.Text = "تاريخ الازدياد:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_StGender
            // 
            txt_StGender.Location = new Point(322, 69);
            txt_StGender.Margin = new Padding(3, 4, 3, 4);
            txt_StGender.Name = "txt_StGender";
            txt_StGender.Size = new Size(173, 30);
            txt_StGender.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(524, 74);
            label4.Name = "label4";
            label4.Size = new Size(43, 22);
            label4.TabIndex = 4;
            label4.Text = "الجنس";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // txt_StName
            // 
            txt_StName.Location = new Point(17, 31);
            txt_StName.Margin = new Padding(3, 4, 3, 4);
            txt_StName.Name = "txt_StName";
            txt_StName.Size = new Size(174, 30);
            txt_StName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(195, 35);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 2;
            label2.Text = "الاسم والنسب:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_StCode
            // 
            txt_StCode.Location = new Point(322, 31);
            txt_StCode.Margin = new Padding(3, 4, 3, 4);
            txt_StCode.Name = "txt_StCode";
            txt_StCode.Size = new Size(173, 30);
            txt_StCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(499, 35);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 0;
            label1.Text = "رمز التلميذ:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frm_StudentsListSet
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 474);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.CornflowerBlue;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_StudentsListSet";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "التلاميذ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btn_First;
        private DevExpress.XtraEditors.SimpleButton btn_Previous;
        private DevExpress.XtraEditors.SimpleButton btn_Next;
        private DevExpress.XtraEditors.SimpleButton btn_Last;
        private GroupBox groupBox1;
        private TextBox txt_StDOB;
        private Label label3;
        private TextBox txt_StGender;
        private Label label4;
        private TextBox txt_StName;
        private Label label2;
        private TextBox txt_StCode;
        private Label label1;
        private TextBox txt_StNotes;
        private Label label5;
    }
}