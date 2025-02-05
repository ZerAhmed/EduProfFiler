namespace EduProfFiler.Views.Forms
{
    partial class frm_SchoolYearSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SchoolYearSet));
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btn_Clearfields = new DevExpress.XtraEditors.SimpleButton();
            btn_DeleteAll = new DevExpress.XtraEditors.SimpleButton();
            btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            btn_Add = new DevExpress.XtraEditors.SimpleButton();
            btn_Search = new DevExpress.XtraEditors.SimpleButton();
            btn_First = new DevExpress.XtraEditors.SimpleButton();
            btn_Previous = new DevExpress.XtraEditors.SimpleButton();
            btn_Next = new DevExpress.XtraEditors.SimpleButton();
            btn_Last = new DevExpress.XtraEditors.SimpleButton();
            groupBox1 = new GroupBox();
            txt_SYNotes = new TextBox();
            label2 = new Label();
            txt_SYCode = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 189);
            dataGridView1.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Clearfields);
            groupBox3.Controls.Add(btn_DeleteAll);
            groupBox3.Controls.Add(btn_Delete);
            groupBox3.Controls.Add(btn_Edit);
            groupBox3.Controls.Add(btn_Add);
            groupBox3.Controls.Add(btn_Search);
            groupBox3.Location = new Point(228, 92);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(391, 78);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "العمليات المتاحة";
            // 
            // btn_Clearfields
            // 
            btn_Clearfields.Appearance.Font = new Font("Droid Arabic Kufi", 8.25F);
            btn_Clearfields.Appearance.Options.UseFont = true;
            btn_Clearfields.ImageOptions.Image = (Image)resources.GetObject("btn_Clearfields.ImageOptions.Image");
            btn_Clearfields.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_Clearfields.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Clearfields.Location = new Point(10, 31);
            btn_Clearfields.Name = "btn_Clearfields";
            btn_Clearfields.Size = new Size(52, 35);
            btn_Clearfields.TabIndex = 5;
            btn_Clearfields.Text = "إفراغ";
            btn_Clearfields.Click += btn_Clearfields_Click;
            // 
            // btn_DeleteAll
            // 
            btn_DeleteAll.Appearance.Font = new Font("Droid Arabic Kufi", 8.25F);
            btn_DeleteAll.Appearance.Options.UseFont = true;
            btn_DeleteAll.ImageOptions.Image = (Image)resources.GetObject("btn_DeleteAll.ImageOptions.Image");
            btn_DeleteAll.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_DeleteAll.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_DeleteAll.Location = new Point(68, 31);
            btn_DeleteAll.Name = "btn_DeleteAll";
            btn_DeleteAll.Size = new Size(74, 35);
            btn_DeleteAll.TabIndex = 4;
            btn_DeleteAll.Text = "حذف الكل";
            btn_DeleteAll.Click += btn_DeleteAll_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Appearance.Font = new Font("Droid Arabic Kufi", 8.25F);
            btn_Delete.Appearance.Options.UseFont = true;
            btn_Delete.ImageOptions.Image = (Image)resources.GetObject("btn_Delete.ImageOptions.Image");
            btn_Delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_Delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Delete.Location = new Point(148, 31);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(49, 35);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "حذف";
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Appearance.Font = new Font("Droid Arabic Kufi", 8.25F);
            btn_Edit.Appearance.Options.UseFont = true;
            btn_Edit.ImageOptions.Image = (Image)resources.GetObject("btn_Edit.ImageOptions.Image");
            btn_Edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_Edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Edit.Location = new Point(203, 31);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(56, 35);
            btn_Edit.TabIndex = 2;
            btn_Edit.Text = "تعديل";
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Add
            // 
            btn_Add.Appearance.Font = new Font("Droid Arabic Kufi", 8.25F);
            btn_Add.Appearance.Options.UseFont = true;
            btn_Add.ImageOptions.Image = (Image)resources.GetObject("btn_Add.ImageOptions.Image");
            btn_Add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_Add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Add.Location = new Point(265, 31);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(58, 35);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "إضافة";
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Search
            // 
            btn_Search.Appearance.Font = new Font("Droid Arabic Kufi", 8.25F);
            btn_Search.Appearance.Options.UseFont = true;
            btn_Search.ImageOptions.Image = (Image)resources.GetObject("btn_Search.ImageOptions.Image");
            btn_Search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            btn_Search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Search.Location = new Point(329, 31);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(52, 35);
            btn_Search.TabIndex = 0;
            btn_Search.Text = "بحث";
            // 
            // btn_First
            // 
            btn_First.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_First.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_First.ImageOptions.SvgImage");
            btn_First.Location = new Point(10, 29);
            btn_First.Name = "btn_First";
            btn_First.Size = new Size(42, 35);
            btn_First.TabIndex = 3;
            // 
            // btn_Previous
            // 
            btn_Previous.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Previous.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Previous.ImageOptions.SvgImage");
            btn_Previous.Location = new Point(59, 29);
            btn_Previous.Name = "btn_Previous";
            btn_Previous.Size = new Size(42, 35);
            btn_Previous.TabIndex = 2;
            // 
            // btn_Next
            // 
            btn_Next.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Next.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Next.ImageOptions.SvgImage");
            btn_Next.Location = new Point(108, 29);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(42, 35);
            btn_Next.TabIndex = 1;
            // 
            // btn_Last
            // 
            btn_Last.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Last.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Last.ImageOptions.SvgImage");
            btn_Last.Location = new Point(157, 29);
            btn_Last.Name = "btn_Last";
            btn_Last.Size = new Size(42, 35);
            btn_Last.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_SYNotes);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_SYCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 73);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات الموسم الدراسي";
            // 
            // txt_SYNotes
            // 
            txt_SYNotes.Location = new Point(6, 29);
            txt_SYNotes.Name = "txt_SYNotes";
            txt_SYNotes.Size = new Size(259, 30);
            txt_SYNotes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(270, 32);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 2;
            label2.Text = "ملاحظات:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_SYCode
            // 
            txt_SYCode.Location = new Point(352, 29);
            txt_SYCode.Name = "txt_SYCode";
            txt_SYCode.Size = new Size(122, 30);
            txt_SYCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(477, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 22);
            label1.TabIndex = 0;
            label1.Text = "رمز الموسم الدراسي:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(simpleButton1);
            groupBox2.Controls.Add(simpleButton2);
            groupBox2.Controls.Add(simpleButton3);
            groupBox2.Controls.Add(simpleButton4);
            groupBox2.Location = new Point(12, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 78);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "التنقل بين الأقسام";
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(9, 31);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(42, 35);
            simpleButton1.TabIndex = 3;
            // 
            // simpleButton2
            // 
            simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            simpleButton2.Location = new Point(59, 31);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(42, 35);
            simpleButton2.TabIndex = 2;
            // 
            // simpleButton3
            // 
            simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton3.ImageOptions.SvgImage");
            simpleButton3.Location = new Point(109, 31);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(42, 35);
            simpleButton3.TabIndex = 1;
            // 
            // simpleButton4
            // 
            simpleButton4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton4.ImageOptions.SvgImage");
            simpleButton4.Location = new Point(159, 31);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new Size(42, 35);
            simpleButton4.TabIndex = 0;
            // 
            // frm_SchoolYearSet
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 377);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_SchoolYearSet";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "المواسم الدراسية";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.SimpleButton btn_First;
        private DevExpress.XtraEditors.SimpleButton btn_Previous;
        private DevExpress.XtraEditors.SimpleButton btn_Next;
        private DevExpress.XtraEditors.SimpleButton btn_Last;
        private GroupBox groupBox1;
        private TextBox txt_SYNotes;
        private Label label2;
        private TextBox txt_SYCode;
        private Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteAll;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton btn_Clearfields;
    }
}