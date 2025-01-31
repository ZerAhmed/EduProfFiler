namespace EduProfFiler.Views.Forms
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.EmptyAreaImageOptions.ImagePadding = new Padding(40, 51, 40, 51);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5 });
            ribbon.Location = new Point(0, 0);
            ribbon.Margin = new Padding(4, 5, 4, 5);
            ribbon.MaxItemId = 6;
            ribbon.Name = "ribbon";
            ribbon.OptionsMenuMinWidth = 440;
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(857, 167);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "الموسم الدراسي";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.ItemAppearance.Hovered.Font = new Font("Droid Arabic Kufi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem1.ItemAppearance.Hovered.Options.UseTextOptions = true;
            barButtonItem1.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem1.ItemAppearance.Normal.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem1.ItemAppearance.Normal.Options.UseTextOptions = true;
            barButtonItem1.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem1.ItemAppearance.Pressed.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            barButtonItem1.ItemAppearance.Pressed.Options.UseTextOptions = true;
            barButtonItem1.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "الأقسام";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.ItemAppearance.Hovered.Font = new Font("Droid Arabic Kufi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem2.ItemAppearance.Hovered.Options.UseTextOptions = true;
            barButtonItem2.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem2.ItemAppearance.Normal.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem2.ItemAppearance.Normal.Options.UseTextOptions = true;
            barButtonItem2.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem2.ItemAppearance.Pressed.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            barButtonItem2.ItemAppearance.Pressed.Options.UseTextOptions = true;
            barButtonItem2.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "التلاميذ";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem3.ImageOptions.SvgImage");
            barButtonItem3.ItemAppearance.Hovered.Font = new Font("Droid Arabic Kufi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem3.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem3.ItemAppearance.Hovered.Options.UseTextOptions = true;
            barButtonItem3.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem3.ItemAppearance.Normal.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem3.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem3.ItemAppearance.Normal.Options.UseTextOptions = true;
            barButtonItem3.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem3.ItemAppearance.Pressed.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem3.ItemAppearance.Pressed.Options.UseFont = true;
            barButtonItem3.ItemAppearance.Pressed.Options.UseTextOptions = true;
            barButtonItem3.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "المواد الدراسية";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem4.ImageOptions.SvgImage");
            barButtonItem4.ItemAppearance.Hovered.Font = new Font("Droid Arabic Kufi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem4.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem4.ItemAppearance.Hovered.Options.UseTextOptions = true;
            barButtonItem4.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem4.ItemAppearance.Normal.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem4.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem4.ItemAppearance.Normal.Options.UseTextOptions = true;
            barButtonItem4.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem4.ItemAppearance.Pressed.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem4.ItemAppearance.Pressed.Options.UseFont = true;
            barButtonItem4.ItemAppearance.Pressed.Options.UseTextOptions = true;
            barButtonItem4.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem4.Name = "barButtonItem4";
            barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonItem4.ItemClick += barButtonItem4_ItemClick;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "المراقبة المستمرة";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem5.ImageOptions.SvgImage");
            barButtonItem5.ItemAppearance.Hovered.Font = new Font("Droid Arabic Kufi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem5.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem5.ItemAppearance.Hovered.Options.UseTextOptions = true;
            barButtonItem5.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem5.ItemAppearance.Normal.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem5.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem5.ItemAppearance.Normal.Options.UseTextOptions = true;
            barButtonItem5.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem5.ItemAppearance.Pressed.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barButtonItem5.ItemAppearance.Pressed.Options.UseFont = true;
            barButtonItem5.ItemAppearance.Pressed.Options.UseTextOptions = true;
            barButtonItem5.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonItem5.ItemClick += barButtonItem5_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Appearance.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ribbonPage1.Appearance.Options.UseFont = true;
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup4, ribbonPageGroup5 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "إعدادات";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 469);
            ribbonStatusBar.Margin = new Padding(4, 5, 4, 5);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(857, 24);
            // 
            // frm_Main
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(857, 493);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("frm_Main.IconOptions.SvgImage");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frm_Main";
            Ribbon = ribbon;
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "RibbonForm1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}