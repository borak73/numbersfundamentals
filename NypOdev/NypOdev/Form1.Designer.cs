
namespace NypOdev
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.teksayilarLV = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ciftsayilarLV = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.asalsayilarLV = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.mukemmelLV = new System.Windows.Forms.ListView();
            this.calistirBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.basTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.bitTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 197);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 241);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.teksayilarLV);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tek Sayılar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // teksayilarLV
            // 
            this.teksayilarLV.HideSelection = false;
            this.teksayilarLV.Location = new System.Drawing.Point(0, 0);
            this.teksayilarLV.Name = "teksayilarLV";
            this.teksayilarLV.Size = new System.Drawing.Size(767, 213);
            this.teksayilarLV.TabIndex = 0;
            this.teksayilarLV.UseCompatibleStateImageBehavior = false;
            this.teksayilarLV.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ciftsayilarLV);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çift Sayılar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ciftsayilarLV
            // 
            this.ciftsayilarLV.HideSelection = false;
            this.ciftsayilarLV.Location = new System.Drawing.Point(0, 0);
            this.ciftsayilarLV.Name = "ciftsayilarLV";
            this.ciftsayilarLV.Size = new System.Drawing.Size(767, 213);
            this.ciftsayilarLV.TabIndex = 1;
            this.ciftsayilarLV.UseCompatibleStateImageBehavior = false;
            this.ciftsayilarLV.View = System.Windows.Forms.View.List;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.asalsayilarLV);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 213);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asal Sayılar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // asalsayilarLV
            // 
            this.asalsayilarLV.HideSelection = false;
            this.asalsayilarLV.Location = new System.Drawing.Point(0, 0);
            this.asalsayilarLV.Name = "asalsayilarLV";
            this.asalsayilarLV.Size = new System.Drawing.Size(767, 213);
            this.asalsayilarLV.TabIndex = 2;
            this.asalsayilarLV.UseCompatibleStateImageBehavior = false;
            this.asalsayilarLV.View = System.Windows.Forms.View.List;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.mukemmelLV);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(767, 213);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mükkemmel Sayılar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // mukemmelLV
            // 
            this.mukemmelLV.HideSelection = false;
            this.mukemmelLV.Location = new System.Drawing.Point(0, 0);
            this.mukemmelLV.Name = "mukemmelLV";
            this.mukemmelLV.Size = new System.Drawing.Size(767, 213);
            this.mukemmelLV.TabIndex = 3;
            this.mukemmelLV.UseCompatibleStateImageBehavior = false;
            this.mukemmelLV.View = System.Windows.Forms.View.List;
            // 
            // calistirBTN
            // 
            this.calistirBTN.Location = new System.Drawing.Point(489, 54);
            this.calistirBTN.Name = "calistirBTN";
            this.calistirBTN.Size = new System.Drawing.Size(75, 23);
            this.calistirBTN.TabIndex = 0;
            this.calistirBTN.Text = "Çalıştır";
            this.calistirBTN.UseVisualStyleBackColor = true;
            this.calistirBTN.Click += new System.EventHandler(this.calistirBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.basTxtBox);
            this.groupBox1.Controls.Add(this.bitTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.calistirBTN);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // basTxtBox
            // 
            this.basTxtBox.Location = new System.Drawing.Point(116, 55);
            this.basTxtBox.Mask = "00000";
            this.basTxtBox.Name = "basTxtBox";
            this.basTxtBox.Size = new System.Drawing.Size(100, 23);
            this.basTxtBox.TabIndex = 6;
            this.basTxtBox.ValidatingType = typeof(int);
            // 
            // bitTxtBox
            // 
            this.bitTxtBox.Location = new System.Drawing.Point(334, 54);
            this.bitTxtBox.Mask = "00000";
            this.bitTxtBox.Name = "bitTxtBox";
            this.bitTxtBox.Size = new System.Drawing.Size(100, 23);
            this.bitTxtBox.TabIndex = 5;
            this.bitTxtBox.ValidatingType = typeof(int);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.notify);
            this.Shown += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView teksayilarLV;
        private System.Windows.Forms.Button calistirBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ciftsayilarLV;
        private System.Windows.Forms.ListView asalsayilarLV;
        private System.Windows.Forms.MaskedTextBox bitTxtBox;
        private System.Windows.Forms.MaskedTextBox basTxtBox;
        private System.Windows.Forms.ListView mukemmelLV;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

