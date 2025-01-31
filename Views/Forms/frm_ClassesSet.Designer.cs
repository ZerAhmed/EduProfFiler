namespace EduProfFiler.Views.Forms
{
    partial class frm_ClassesSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ClassesSet));
            groupBox1 = new GroupBox();
            txt_SYCode = new TextBox();
            label3 = new Label();
            txt_ClGrade = new TextBox();
            label4 = new Label();
            txt_ClName = new TextBox();
            label2 = new Label();
            txt_ClCode = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_First = new DevExpress.XtraEditors.SimpleButton();
            btn_Previous = new DevExpress.XtraEditors.SimpleButton();
            btn_Next = new DevExpress.XtraEditors.SimpleButton();
            btn_Last = new DevExpress.XtraEditors.SimpleButton();
            groupBox3 = new GroupBox();
            btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            btn_Add = new DevExpress.XtraEditors.SimpleButton();
            btn_Search = new DevExpress.XtraEditors.SimpleButton();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_SYCode);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_ClGrade);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_ClName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_ClCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "الأقسام";
            // 
            // txt_SYCode
            // 
            txt_SYCode.Location = new Point(38, 67);
            txt_SYCode.Name = "txt_SYCode";
            txt_SYCode.Size = new Size(123, 32);
            txt_SYCode.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(163, 70);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 6;
            label3.Text = "الموسم الدراسي:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ClGrade
            // 
            txt_ClGrade.Location = new Point(358, 67);
            txt_ClGrade.Name = "txt_ClGrade";
            txt_ClGrade.Size = new Size(122, 32);
            txt_ClGrade.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(485, 70);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 4;
            label4.Text = "المستوى: ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ClName
            // 
            txt_ClName.Location = new Point(38, 29);
            txt_ClName.Name = "txt_ClName";
            txt_ClName.Size = new Size(123, 32);
            txt_ClName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(178, 32);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "تسمية القسم:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ClCode
            // 
            txt_ClCode.Location = new Point(358, 29);
            txt_ClCode.Name = "txt_ClCode";
            txt_ClCode.Size = new Size(122, 32);
            txt_ClCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(483, 32);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "رمز القسم:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_First);
            groupBox2.Controls.Add(btn_Previous);
            groupBox2.Controls.Add(btn_Next);
            groupBox2.Controls.Add(btn_Last);
            groupBox2.Location = new Point(13, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 84);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "التنقل بين الأقسام";
            // 
            // btn_First
            // 
            btn_First.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_First.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_First.ImageOptions.SvgImage");
            btn_First.Location = new Point(9, 31);
            btn_First.Name = "btn_First";
            btn_First.Size = new Size(42, 35);
            btn_First.TabIndex = 3;
            // 
            // btn_Previous
            // 
            btn_Previous.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Previous.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Previous.ImageOptions.SvgImage");
            btn_Previous.Location = new Point(65, 31);
            btn_Previous.Name = "btn_Previous";
            btn_Previous.Size = new Size(42, 35);
            btn_Previous.TabIndex = 2;
            // 
            // btn_Next
            // 
            btn_Next.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Next.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Next.ImageOptions.SvgImage");
            btn_Next.Location = new Point(121, 31);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(42, 35);
            btn_Next.TabIndex = 1;
            // 
            // btn_Last
            // 
            btn_Last.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Last.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Last.ImageOptions.SvgImage");
            btn_Last.Location = new Point(177, 31);
            btn_Last.Name = "btn_Last";
            btn_Last.Size = new Size(42, 35);
            btn_Last.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Delete);
            groupBox3.Controls.Add(btn_Edit);
            groupBox3.Controls.Add(btn_Add);
            groupBox3.Controls.Add(btn_Search);
            groupBox3.Location = new Point(267, 128);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(353, 84);
            groupBox3.TabIndex = 9;
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
            btn_Delete.Location = new Point(6, 31);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(74, 35);
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
            btn_Edit.Location = new Point(91, 31);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(74, 35);
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
            btn_Add.Location = new Point(176, 31);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(74, 35);
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
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(74, 35);
            btn_Search.TabIndex = 0;
            btn_Search.Text = "بحث";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 177);
            dataGridView1.TabIndex = 10;
            // 
            // frm_ClassesSet
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(632, 407);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Droid Arabic Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frm_ClassesSet";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إعدادات الأقسام";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_ClName;
        private Label label2;
        private TextBox txt_ClCode;
        private Label label1;
        private TextBox txt_SYCode;
        private Label label3;
        private TextBox txt_ClGrade;
        private Label label4;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btn_Last;
        private DevExpress.XtraEditors.SimpleButton btn_First;
        private DevExpress.XtraEditors.SimpleButton btn_Previous;
        private DevExpress.XtraEditors.SimpleButton btn_Next;
        private GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DataGridView dataGridView1;
    }
}