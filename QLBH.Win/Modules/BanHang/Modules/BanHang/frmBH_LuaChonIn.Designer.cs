﻿using QLBH.Core.Form;

namespace QLBanHang.Modules.BanHang
{
    partial class frmBH_LuaChonIn
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
            this.chkBill = new System.Windows.Forms.CheckBox();
            this.chkReceipt = new System.Windows.Forms.CheckBox();
            this.chkPayment = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBill
            // 
            this.chkBill.AutoSize = true;
            this.chkBill.Location = new System.Drawing.Point(22, 30);
            this.chkBill.Name = "chkBill";
            this.chkBill.Size = new System.Drawing.Size(90, 17);
            this.chkBill.TabIndex = 0;
            this.chkBill.Text = "In phiếu xuất";
            this.chkBill.UseVisualStyleBackColor = true;
            // 
            // chkReceipt
            // 
            this.chkReceipt.AutoSize = true;
            this.chkReceipt.Location = new System.Drawing.Point(133, 30);
            this.chkReceipt.Name = "chkReceipt";
            this.chkReceipt.Size = new System.Drawing.Size(78, 17);
            this.chkReceipt.TabIndex = 1;
            this.chkReceipt.Text = "In hóa đơn";
            this.chkReceipt.UseVisualStyleBackColor = true;
            // 
            // chkPayment
            // 
            this.chkPayment.AutoSize = true;
            this.chkPayment.Location = new System.Drawing.Point(248, 30);
            this.chkPayment.Name = "chkPayment";
            this.chkPayment.Size = new System.Drawing.Size(84, 17);
            this.chkPayment.TabIndex = 2;
            this.chkPayment.Text = "In phiếu thu";
            this.chkPayment.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBill);
            this.groupBox1.Controls.Add(this.chkPayment);
            this.groupBox1.Controls.Add(this.chkReceipt);
            this.groupBox1.Location = new System.Drawing.Point(20, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "In phiếu bán hàng";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(119, 119);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(201, 119);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBH_LuaChonIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 154);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBH_LuaChonIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In phiếu bán hàng";
            this.Load += new System.EventHandler(this.frmPhieuXuat_LuaChonIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBill;
        private System.Windows.Forms.CheckBox chkReceipt;
        private System.Windows.Forms.CheckBox chkPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private QLBH.Core.Form.GtidButton btnPrint;
        private QLBH.Core.Form.GtidButton btnClose;
    }
}