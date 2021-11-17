
namespace IEA_Erproject102AA_Main
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tabCUstMenu = new System.Windows.Forms.TabControl();
            this.tabPGenel = new System.Windows.Forms.TabPage();
            this.tabPYonetim = new System.Windows.Forms.TabPage();
            this.pnlAltMenu = new System.Windows.Forms.Panel();
            this.pnlSolMenu = new System.Windows.Forms.Panel();
            this.sConSolMenu = new System.Windows.Forms.SplitContainer();
            this.tvUrunIslemleri = new System.Windows.Forms.TreeView();
            this.tvBilgiGirisİslemleri = new System.Windows.Forms.TreeView();
            this.tv12 = new System.Windows.Forms.TreeView();
            this.tv11 = new System.Windows.Forms.TreeView();
            this.tv10 = new System.Windows.Forms.TreeView();
            this.tv9 = new System.Windows.Forms.TreeView();
            this.tv7 = new System.Windows.Forms.TreeView();
            this.tv6 = new System.Windows.Forms.TreeView();
            this.tv5 = new System.Windows.Forms.TreeView();
            this.tv8 = new System.Windows.Forms.TreeView();
            this.tv4 = new System.Windows.Forms.TreeView();
            this.tvDepoIslemleri = new System.Windows.Forms.TreeView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnDepoIslemleri = new System.Windows.Forms.Button();
            this.btnUrunGiris = new System.Windows.Forms.Button();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.pnlCUst = new System.Windows.Forms.Panel();
            this.btnMenuCollapse = new System.Windows.Forms.Button();
            this.lblMenuText = new System.Windows.Forms.Label();
            this.btnSolMenuAra = new System.Windows.Forms.Button();
            this.txtSolMenuAra = new System.Windows.Forms.TextBox();
            this.spltSolMenu = new System.Windows.Forms.Splitter();
            this.tabCUstMenu.SuspendLayout();
            this.pnlSolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sConSolMenu)).BeginInit();
            this.sConSolMenu.Panel1.SuspendLayout();
            this.sConSolMenu.Panel2.SuspendLayout();
            this.sConSolMenu.SuspendLayout();
            this.pnlCUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCUstMenu
            // 
            this.tabCUstMenu.Controls.Add(this.tabPGenel);
            this.tabCUstMenu.Controls.Add(this.tabPYonetim);
            this.tabCUstMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabCUstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabCUstMenu.Location = new System.Drawing.Point(0, 0);
            this.tabCUstMenu.Name = "tabCUstMenu";
            this.tabCUstMenu.SelectedIndex = 0;
            this.tabCUstMenu.Size = new System.Drawing.Size(1160, 100);
            this.tabCUstMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCUstMenu.TabIndex = 0;
            // 
            // tabPGenel
            // 
            this.tabPGenel.Location = new System.Drawing.Point(4, 25);
            this.tabPGenel.Name = "tabPGenel";
            this.tabPGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPGenel.Size = new System.Drawing.Size(1152, 71);
            this.tabPGenel.TabIndex = 0;
            this.tabPGenel.Text = "Genel";
            this.tabPGenel.UseVisualStyleBackColor = true;
            this.tabPGenel.Click += new System.EventHandler(this.a_Click);
            // 
            // tabPYonetim
            // 
            this.tabPYonetim.Location = new System.Drawing.Point(4, 25);
            this.tabPYonetim.Name = "tabPYonetim";
            this.tabPYonetim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPYonetim.Size = new System.Drawing.Size(1152, 71);
            this.tabPYonetim.TabIndex = 1;
            this.tabPYonetim.Text = "Yönetim";
            this.tabPYonetim.UseVisualStyleBackColor = true;
            // 
            // pnlAltMenu
            // 
            this.pnlAltMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAltMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAltMenu.Location = new System.Drawing.Point(0, 735);
            this.pnlAltMenu.Name = "pnlAltMenu";
            this.pnlAltMenu.Size = new System.Drawing.Size(1160, 31);
            this.pnlAltMenu.TabIndex = 1;
            // 
            // pnlSolMenu
            // 
            this.pnlSolMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlSolMenu.Controls.Add(this.sConSolMenu);
            this.pnlSolMenu.Controls.Add(this.pnlCUst);
            this.pnlSolMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSolMenu.Location = new System.Drawing.Point(0, 100);
            this.pnlSolMenu.Name = "pnlSolMenu";
            this.pnlSolMenu.Size = new System.Drawing.Size(275, 635);
            this.pnlSolMenu.TabIndex = 2;
            // 
            // sConSolMenu
            // 
            this.sConSolMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sConSolMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sConSolMenu.Location = new System.Drawing.Point(0, 55);
            this.sConSolMenu.Name = "sConSolMenu";
            this.sConSolMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sConSolMenu.Panel1
            // 
            this.sConSolMenu.Panel1.Controls.Add(this.tvDepoIslemleri);
            this.sConSolMenu.Panel1.Controls.Add(this.tvUrunIslemleri);
            this.sConSolMenu.Panel1.Controls.Add(this.tvBilgiGirisİslemleri);
            this.sConSolMenu.Panel1.Controls.Add(this.tv12);
            this.sConSolMenu.Panel1.Controls.Add(this.tv11);
            this.sConSolMenu.Panel1.Controls.Add(this.tv10);
            this.sConSolMenu.Panel1.Controls.Add(this.tv9);
            this.sConSolMenu.Panel1.Controls.Add(this.tv7);
            this.sConSolMenu.Panel1.Controls.Add(this.tv6);
            this.sConSolMenu.Panel1.Controls.Add(this.tv5);
            this.sConSolMenu.Panel1.Controls.Add(this.tv8);
            this.sConSolMenu.Panel1.Controls.Add(this.tv4);
            this.sConSolMenu.Panel1MinSize = 35;
            // 
            // sConSolMenu.Panel2
            // 
            this.sConSolMenu.Panel2.Controls.Add(this.button7);
            this.sConSolMenu.Panel2.Controls.Add(this.button8);
            this.sConSolMenu.Panel2.Controls.Add(this.button9);
            this.sConSolMenu.Panel2.Controls.Add(this.button4);
            this.sConSolMenu.Panel2.Controls.Add(this.button5);
            this.sConSolMenu.Panel2.Controls.Add(this.button6);
            this.sConSolMenu.Panel2.Controls.Add(this.btnDepoIslemleri);
            this.sConSolMenu.Panel2.Controls.Add(this.btnUrunGiris);
            this.sConSolMenu.Panel2.Controls.Add(this.btnBilgiGiris);
            this.sConSolMenu.Size = new System.Drawing.Size(275, 580);
            this.sConSolMenu.SplitterDistance = 212;
            this.sConSolMenu.TabIndex = 5;
            // 
            // tvUrunIslemleri
            // 
            this.tvUrunIslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUrunIslemleri.Location = new System.Drawing.Point(0, 0);
            this.tvUrunIslemleri.Name = "tvUrunIslemleri";
            this.tvUrunIslemleri.Size = new System.Drawing.Size(271, 208);
            this.tvUrunIslemleri.TabIndex = 1;
            this.tvUrunIslemleri.Visible = false;
            this.tvUrunIslemleri.DoubleClick += new System.EventHandler(this.tvUrunIslemleri_DoubleClick);
            // 
            // tvBilgiGirisİslemleri
            // 
            this.tvBilgiGirisİslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBilgiGirisİslemleri.Location = new System.Drawing.Point(0, 0);
            this.tvBilgiGirisİslemleri.Name = "tvBilgiGirisİslemleri";
            this.tvBilgiGirisİslemleri.Size = new System.Drawing.Size(271, 208);
            this.tvBilgiGirisİslemleri.TabIndex = 0;
            this.tvBilgiGirisİslemleri.Visible = false;
            this.tvBilgiGirisİslemleri.DoubleClick += new System.EventHandler(this.tvBilgiGirisİslemleri_DoubleClick);
            // 
            // tv12
            // 
            this.tv12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv12.Location = new System.Drawing.Point(0, 0);
            this.tv12.Name = "tv12";
            this.tv12.Size = new System.Drawing.Size(271, 208);
            this.tv12.TabIndex = 11;
            this.tv12.Visible = false;
            // 
            // tv11
            // 
            this.tv11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv11.Location = new System.Drawing.Point(0, 0);
            this.tv11.Name = "tv11";
            this.tv11.Size = new System.Drawing.Size(271, 208);
            this.tv11.TabIndex = 10;
            this.tv11.Visible = false;
            // 
            // tv10
            // 
            this.tv10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv10.Location = new System.Drawing.Point(0, 0);
            this.tv10.Name = "tv10";
            this.tv10.Size = new System.Drawing.Size(271, 208);
            this.tv10.TabIndex = 9;
            this.tv10.Visible = false;
            // 
            // tv9
            // 
            this.tv9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv9.Location = new System.Drawing.Point(0, 0);
            this.tv9.Name = "tv9";
            this.tv9.Size = new System.Drawing.Size(271, 208);
            this.tv9.TabIndex = 8;
            this.tv9.Visible = false;
            // 
            // tv7
            // 
            this.tv7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv7.Location = new System.Drawing.Point(0, 0);
            this.tv7.Name = "tv7";
            this.tv7.Size = new System.Drawing.Size(271, 208);
            this.tv7.TabIndex = 7;
            this.tv7.Visible = false;
            // 
            // tv6
            // 
            this.tv6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv6.Location = new System.Drawing.Point(0, 0);
            this.tv6.Name = "tv6";
            this.tv6.Size = new System.Drawing.Size(271, 208);
            this.tv6.TabIndex = 6;
            this.tv6.Visible = false;
            // 
            // tv5
            // 
            this.tv5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv5.Location = new System.Drawing.Point(0, 0);
            this.tv5.Name = "tv5";
            this.tv5.Size = new System.Drawing.Size(271, 208);
            this.tv5.TabIndex = 5;
            this.tv5.Visible = false;
            // 
            // tv8
            // 
            this.tv8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv8.Location = new System.Drawing.Point(0, 0);
            this.tv8.Name = "tv8";
            this.tv8.Size = new System.Drawing.Size(271, 208);
            this.tv8.TabIndex = 4;
            this.tv8.Visible = false;
            // 
            // tv4
            // 
            this.tv4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv4.Location = new System.Drawing.Point(0, 0);
            this.tv4.Name = "tv4";
            this.tv4.Size = new System.Drawing.Size(271, 208);
            this.tv4.TabIndex = 3;
            this.tv4.Visible = false;
            // 
            // tvDepoIslemleri
            // 
            this.tvDepoIslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDepoIslemleri.Location = new System.Drawing.Point(0, 0);
            this.tvDepoIslemleri.Name = "tvDepoIslemleri";
            this.tvDepoIslemleri.Size = new System.Drawing.Size(271, 208);
            this.tvDepoIslemleri.TabIndex = 2;
            this.tvDepoIslemleri.Visible = false;
            this.tvDepoIslemleri.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDepoIslemleri_AfterSelect);
            this.tvDepoIslemleri.DoubleClick += new System.EventHandler(this.tvDepoIslemleri_DoubleClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(179, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 60);
            this.button7.TabIndex = 8;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(93, 175);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 60);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 175);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 60);
            this.button9.TabIndex = 6;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 61);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 61);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDepoIslemleri
            // 
            this.btnDepoIslemleri.Location = new System.Drawing.Point(179, 17);
            this.btnDepoIslemleri.Name = "btnDepoIslemleri";
            this.btnDepoIslemleri.Size = new System.Drawing.Size(74, 62);
            this.btnDepoIslemleri.TabIndex = 2;
            this.btnDepoIslemleri.Text = "Depo İşlemleri";
            this.btnDepoIslemleri.UseVisualStyleBackColor = true;
            this.btnDepoIslemleri.Click += new System.EventHandler(this.btnDepoIslemleri_Click);
            // 
            // btnUrunGiris
            // 
            this.btnUrunGiris.Location = new System.Drawing.Point(93, 17);
            this.btnUrunGiris.Name = "btnUrunGiris";
            this.btnUrunGiris.Size = new System.Drawing.Size(72, 62);
            this.btnUrunGiris.TabIndex = 1;
            this.btnUrunGiris.Text = "Ürün İşlemleri";
            this.btnUrunGiris.UseVisualStyleBackColor = true;
            this.btnUrunGiris.Click += new System.EventHandler(this.btnUrunGiris_Click);
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.Location = new System.Drawing.Point(10, 17);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(74, 62);
            this.btnBilgiGiris.TabIndex = 0;
            this.btnBilgiGiris.Text = "Bilgi Giriş İşlemleri";
            this.btnBilgiGiris.UseVisualStyleBackColor = true;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pnlCUst
            // 
            this.pnlCUst.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlCUst.Controls.Add(this.btnMenuCollapse);
            this.pnlCUst.Controls.Add(this.lblMenuText);
            this.pnlCUst.Controls.Add(this.btnSolMenuAra);
            this.pnlCUst.Controls.Add(this.txtSolMenuAra);
            this.pnlCUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCUst.Location = new System.Drawing.Point(0, 0);
            this.pnlCUst.Name = "pnlCUst";
            this.pnlCUst.Size = new System.Drawing.Size(275, 55);
            this.pnlCUst.TabIndex = 4;
            // 
            // btnMenuCollapse
            // 
            this.btnMenuCollapse.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.RightLeft2Red;
            this.btnMenuCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuCollapse.Location = new System.Drawing.Point(208, 26);
            this.btnMenuCollapse.Name = "btnMenuCollapse";
            this.btnMenuCollapse.Size = new System.Drawing.Size(26, 25);
            this.btnMenuCollapse.TabIndex = 3;
            this.btnMenuCollapse.UseVisualStyleBackColor = true;
            // 
            // lblMenuText
            // 
            this.lblMenuText.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblMenuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuText.Location = new System.Drawing.Point(3, 26);
            this.lblMenuText.Name = "lblMenuText";
            this.lblMenuText.Size = new System.Drawing.Size(206, 23);
            this.lblMenuText.TabIndex = 2;
            this.lblMenuText.Text = "***";
            this.lblMenuText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSolMenuAra
            // 
            this.btnSolMenuAra.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.Ara32x32;
            this.btnSolMenuAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolMenuAra.Location = new System.Drawing.Point(203, 1);
            this.btnSolMenuAra.Name = "btnSolMenuAra";
            this.btnSolMenuAra.Size = new System.Drawing.Size(31, 23);
            this.btnSolMenuAra.TabIndex = 1;
            this.btnSolMenuAra.UseVisualStyleBackColor = true;
            // 
            // txtSolMenuAra
            // 
            this.txtSolMenuAra.Location = new System.Drawing.Point(0, 1);
            this.txtSolMenuAra.Name = "txtSolMenuAra";
            this.txtSolMenuAra.Size = new System.Drawing.Size(209, 22);
            this.txtSolMenuAra.TabIndex = 0;
            // 
            // spltSolMenu
            // 
            this.spltSolMenu.Location = new System.Drawing.Point(275, 100);
            this.spltSolMenu.Name = "spltSolMenu";
            this.spltSolMenu.Size = new System.Drawing.Size(41, 635);
            this.spltSolMenu.TabIndex = 3;
            this.spltSolMenu.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1160, 766);
            this.Controls.Add(this.spltSolMenu);
            this.Controls.Add(this.pnlSolMenu);
            this.Controls.Add(this.pnlAltMenu);
            this.Controls.Add(this.tabCUstMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "IEA_Erproject102AA_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabCUstMenu.ResumeLayout(false);
            this.pnlSolMenu.ResumeLayout(false);
            this.sConSolMenu.Panel1.ResumeLayout(false);
            this.sConSolMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sConSolMenu)).EndInit();
            this.sConSolMenu.ResumeLayout(false);
            this.pnlCUst.ResumeLayout(false);
            this.pnlCUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCUstMenu;
        private System.Windows.Forms.TabPage tabPGenel;
        private System.Windows.Forms.TabPage tabPYonetim;
        private System.Windows.Forms.Panel pnlAltMenu;
        private System.Windows.Forms.Panel pnlSolMenu;
        private System.Windows.Forms.Panel pnlCUst;
        private System.Windows.Forms.Button btnSolMenuAra;
        private System.Windows.Forms.TextBox txtSolMenuAra;
        private System.Windows.Forms.Splitter spltSolMenu;
        private System.Windows.Forms.Button btnMenuCollapse;
        private System.Windows.Forms.Label lblMenuText;
        private System.Windows.Forms.SplitContainer sConSolMenu;
        private System.Windows.Forms.TreeView tv12;
        private System.Windows.Forms.TreeView tv11;
        private System.Windows.Forms.TreeView tv10;
        private System.Windows.Forms.TreeView tv9;
        private System.Windows.Forms.TreeView tv7;
        private System.Windows.Forms.TreeView tv6;
        private System.Windows.Forms.TreeView tv5;
        private System.Windows.Forms.TreeView tv8;
        private System.Windows.Forms.TreeView tv4;
        private System.Windows.Forms.TreeView tvDepoIslemleri;
        private System.Windows.Forms.TreeView tvUrunIslemleri;
        private System.Windows.Forms.TreeView tvBilgiGirisİslemleri;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnDepoIslemleri;
        private System.Windows.Forms.Button btnUrunGiris;
        private System.Windows.Forms.Button btnBilgiGiris;
    }
}

