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
            txt_ClName = new TextBox();
            label2 = new Label();
            txt_ClCode = new TextBox();
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
            dataGridView1.Location = new Point(12, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 177);
            dataGridView1.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Delete);
            groupBox3.Controls.Add(btn_Edit);
            groupBox3.Controls.Add(btn_Add);
            groupBox3.Controls.Add(btn_Search);
            groupBox3.Location = new Point(266, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(353, 84);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_First);
            groupBox2.Controls.Add(btn_Previous);
            groupBox2.Controls.Add(btn_Next);
            groupBox2.Controls.Add(btn_Last);
            groupBox2.Location = new Point(12, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 84);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "التنقل بين المواسم";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_ClName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_ClCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 73);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات الموسم الدراسي";
            // 
            // txt_ClName
            // 
            txt_ClName.Location = new Point(6, 29);
            txt_ClName.Name = "txt_ClName";
            txt_ClName.Size = new Size(259, 30);
            txt_ClName.TabIndex = 3;
            txt_ClName.TextChanged += txt_ClName_TextChanged;
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
            // txt_ClCode
            // 
            txt_ClCode.Location = new Point(352, 29);
            txt_ClCode.Name = "txt_ClCode";
            txt_ClCode.Size = new Size(122, 30);
            txt_ClCode.TabIndex = 1;
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
            // frm_SchoolYearSet
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 377);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
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
        private TextBox txt_ClName;
        private Label label2;
        private TextBox txt_ClCode;
        private Label label1;
    }
}