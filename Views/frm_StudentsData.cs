using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduProfFiler.Views
{
    public partial class frm_StudentData : Form
    {
        public frm_StudentData()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btn_Save = new Button();
            St_Code = new TextBox();
            label1 = new Label();
            label2 = new Label();
            St_Name = new TextBox();
            label3 = new Label();
            St_Gender = new TextBox();
            label4 = new Label();
            St_DOB = new TextBox();
            label5 = new Label();
            St_Notes = new TextBox();
            SuspendLayout();
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(233, 214);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(180, 30);
            btn_Save.TabIndex = 0;
            btn_Save.Text = "حفظ";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // St_Code
            // 
            St_Code.Location = new Point(233, 22);
            St_Code.Name = "St_Code";
            St_Code.Size = new Size(180, 30);
            St_Code.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 2;
            label1.Text = "رمز التلميذ: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 61);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 4;
            label2.Text = "الاسم والنسب: ";
            // 
            // St_Name
            // 
            St_Name.Location = new Point(233, 58);
            St_Name.Name = "St_Name";
            St_Name.Size = new Size(180, 30);
            St_Name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 97);
            label3.Name = "label3";
            label3.Size = new Size(51, 22);
            label3.TabIndex = 6;
            label3.Text = "الجنس: ";
            // 
            // St_Gender
            // 
            St_Gender.Location = new Point(233, 94);
            St_Gender.Name = "St_Gender";
            St_Gender.Size = new Size(180, 30);
            St_Gender.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 133);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 8;
            label4.Text = "تاريخ الازدياد: ";
            // 
            // St_DOB
            // 
            St_DOB.Location = new Point(233, 130);
            St_DOB.Name = "St_DOB";
            St_DOB.Size = new Size(180, 30);
            St_DOB.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 168);
            label5.Name = "label5";
            label5.Size = new Size(64, 22);
            label5.TabIndex = 10;
            label5.Text = "ملاحظات: ";
            // 
            // St_Notes
            // 
            St_Notes.Location = new Point(233, 165);
            St_Notes.Name = "St_Notes";
            St_Notes.Size = new Size(180, 30);
            St_Notes.TabIndex = 9;
            // 
            // frm_StudentData
            // 
            ClientSize = new Size(594, 269);
            Controls.Add(label5);
            Controls.Add(St_Notes);
            Controls.Add(label4);
            Controls.Add(St_DOB);
            Controls.Add(label3);
            Controls.Add(St_Gender);
            Controls.Add(label2);
            Controls.Add(St_Name);
            Controls.Add(label1);
            Controls.Add(St_Code);
            Controls.Add(btn_Save);
            Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frm_StudentData";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
