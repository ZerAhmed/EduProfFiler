namespace EduProfFiler.Views.Forms
{
    partial class frm_UnitsAndSubjectsSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UnitsAndSubjectsSet));
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
            groupBox4 = new GroupBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            groupBox5 = new GroupBox();
            simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            groupBox6 = new GroupBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 293);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 154);
            dataGridView1.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Delete);
            groupBox3.Controls.Add(btn_Edit);
            groupBox3.Controls.Add(btn_Add);
            groupBox3.Controls.Add(btn_Search);
            groupBox3.Location = new Point(266, 74);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(353, 73);
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
            btn_Delete.Location = new Point(6, 26);
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
            btn_Edit.Location = new Point(91, 26);
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
            btn_Add.Location = new Point(176, 26);
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
            btn_Search.Location = new Point(261, 26);
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
            groupBox2.Location = new Point(12, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 73);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "التنقل بين الوحدات";
            // 
            // btn_First
            // 
            btn_First.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_First.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_First.ImageOptions.SvgImage");
            btn_First.Location = new Point(9, 26);
            btn_First.Name = "btn_First";
            btn_First.Size = new Size(42, 35);
            btn_First.TabIndex = 3;
            // 
            // btn_Previous
            // 
            btn_Previous.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Previous.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Previous.ImageOptions.SvgImage");
            btn_Previous.Location = new Point(65, 26);
            btn_Previous.Name = "btn_Previous";
            btn_Previous.Size = new Size(42, 35);
            btn_Previous.TabIndex = 2;
            // 
            // btn_Next
            // 
            btn_Next.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Next.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Next.ImageOptions.SvgImage");
            btn_Next.Location = new Point(121, 26);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(42, 35);
            btn_Next.TabIndex = 1;
            // 
            // btn_Last
            // 
            btn_Last.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btn_Last.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btn_Last.ImageOptions.SvgImage");
            btn_Last.Location = new Point(177, 26);
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
            groupBox1.Size = new Size(607, 55);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات الوحدة الدراسية";
            // 
            // txt_ClName
            // 
            txt_ClName.Location = new Point(9, 18);
            txt_ClName.Name = "txt_ClName";
            txt_ClName.Size = new Size(263, 30);
            txt_ClName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(278, 21);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 2;
            label2.Text = "تسمية الوحدة:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ClCode
            // 
            txt_ClCode.Location = new Point(383, 18);
            txt_ClCode.Name = "txt_ClCode";
            txt_ClCode.Size = new Size(91, 30);
            txt_ClCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(476, 21);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 0;
            label1.Text = "رمز الوحدة:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(simpleButton1);
            groupBox4.Controls.Add(simpleButton2);
            groupBox4.Controls.Add(simpleButton3);
            groupBox4.Controls.Add(simpleButton4);
            groupBox4.Location = new Point(266, 214);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(353, 73);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "العمليات المتاحة";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Droid Arabic Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(6, 26);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(74, 35);
            simpleButton1.TabIndex = 3;
            simpleButton1.Text = "حذف";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.Font = new Font("Droid Arabic Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            simpleButton2.Location = new Point(91, 26);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(74, 35);
            simpleButton2.TabIndex = 2;
            simpleButton2.Text = "تعديل";
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.Font = new Font("Droid Arabic Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            simpleButton3.Appearance.Options.UseFont = true;
            simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton3.ImageOptions.SvgImage");
            simpleButton3.Location = new Point(176, 26);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(74, 35);
            simpleButton3.TabIndex = 1;
            simpleButton3.Text = "إضافة";
            // 
            // simpleButton4
            // 
            simpleButton4.Appearance.Font = new Font("Droid Arabic Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            simpleButton4.Appearance.Options.UseFont = true;
            simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            simpleButton4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton4.ImageOptions.SvgImage");
            simpleButton4.Location = new Point(261, 26);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new Size(74, 35);
            simpleButton4.TabIndex = 0;
            simpleButton4.Text = "بحث";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(simpleButton5);
            groupBox5.Controls.Add(simpleButton6);
            groupBox5.Controls.Add(simpleButton7);
            groupBox5.Controls.Add(simpleButton8);
            groupBox5.Location = new Point(12, 214);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(229, 73);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            groupBox5.Text = "التنقل بين المواد";
            // 
            // simpleButton5
            // 
            simpleButton5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton5.ImageOptions.SvgImage");
            simpleButton5.Location = new Point(9, 26);
            simpleButton5.Name = "simpleButton5";
            simpleButton5.Size = new Size(42, 35);
            simpleButton5.TabIndex = 3;
            // 
            // simpleButton6
            // 
            simpleButton6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton6.ImageOptions.SvgImage");
            simpleButton6.Location = new Point(65, 26);
            simpleButton6.Name = "simpleButton6";
            simpleButton6.Size = new Size(42, 35);
            simpleButton6.TabIndex = 2;
            // 
            // simpleButton7
            // 
            simpleButton7.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton7.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton7.ImageOptions.SvgImage");
            simpleButton7.Location = new Point(121, 26);
            simpleButton7.Name = "simpleButton7";
            simpleButton7.Size = new Size(42, 35);
            simpleButton7.TabIndex = 1;
            // 
            // simpleButton8
            // 
            simpleButton8.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            simpleButton8.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton8.ImageOptions.SvgImage");
            simpleButton8.Location = new Point(177, 26);
            simpleButton8.Name = "simpleButton8";
            simpleButton8.Size = new Size(42, 35);
            simpleButton8.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox1);
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(textBox2);
            groupBox6.Controls.Add(label4);
            groupBox6.Location = new Point(12, 153);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(607, 55);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "مواد الوحدة";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 30);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(278, 21);
            label3.Name = "label3";
            label3.Size = new Size(83, 22);
            label3.TabIndex = 2;
            label3.Text = "تسمية المادة:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(383, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 30);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(480, 21);
            label4.Name = "label4";
            label4.Size = new Size(64, 22);
            label4.TabIndex = 0;
            label4.Text = "رمز المادة:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frm_UnitsAndSubjectsSet
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(631, 459);
            Controls.Add(groupBox4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_UnitsAndSubjectsSet";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الوحدات والمواد الدراسية";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
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
        private GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private GroupBox groupBox5;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private GroupBox groupBox6;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}