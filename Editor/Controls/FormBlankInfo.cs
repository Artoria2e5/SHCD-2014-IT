﻿namespace Qisi.Editor.Controls
{
    using Qisi.Editor.Properties;
    using Qisi.General.Controls;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
	/// <summary>
	/// Form blank info.
	/// </summary>
    public class FormBlankInfo : Form
    {
        private IContainer components = null;
        private CrystalButtonLeftRight crystalButtonLeftRight1;
        private Label Label1;
        private Label Label2;
        private Label Label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;

        public FormBlankInfo()
        {
            this.InitializeComponent();
        }

        private void crystalButtonLeftRight1_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormBlankInfo_Load(object sender, EventArgs e)
        {
            this.Label3.Text = "供参考，本窗口的宽度为" + base.Width.ToString() + "像素。";
        }

        private void InitializeComponent()
        {
            this.Label1 = new Label();
            this.numericUpDown1 = new NumericUpDown();
            this.numericUpDown2 = new NumericUpDown();
            this.Label2 = new Label();
            this.crystalButtonLeftRight1 = new CrystalButtonLeftRight();
            this.Label3 = new Label();
            this.numericUpDown1.BeginInit();
            this.numericUpDown2.BeginInit();
            base.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.Label1.Location = new Point(12, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x5c, 0x11);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "最大输入字符数";
            this.numericUpDown1.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.numericUpDown1.Location = new Point(0x8e, 12);
            int[] bits = new int[4];
            bits[0] = 0x2710;
            this.numericUpDown1.Maximum = new decimal(bits);
            bits = new int[4];
            bits[0] = 1;
            this.numericUpDown1.Minimum = new decimal(bits);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(120, 0x17);
            this.numericUpDown1.TabIndex = 1;
            bits = new int[4];
            bits[0] = 1;
            this.numericUpDown1.Value = new decimal(bits);
            this.numericUpDown2.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.numericUpDown2.Location = new Point(0x8e, 0x35);
            bits = new int[4];
            bits[0] = 0x2710;
            this.numericUpDown2.Maximum = new decimal(bits);
            bits = new int[4];
            bits[0] = 50;
            this.numericUpDown2.Minimum = new decimal(bits);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new Size(120, 0x17);
            this.numericUpDown2.TabIndex = 3;
            bits = new int[4];
            bits[0] = 50;
            this.numericUpDown2.Value = new decimal(bits);
            this.numericUpDown2.ValueChanged += new EventHandler(this.numericUpDown2_ValueChanged);
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.Label2.Location = new Point(12, 0x37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x7c, 0x11);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "最小长度(单位：像素)";
            this.crystalButtonLeftRight1.ButtonText = "确定";
            this.crystalButtonLeftRight1.Cursor = Cursors.Hand;
            this.crystalButtonLeftRight1.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.crystalButtonLeftRight1.Image = Resources.confirm;
            this.crystalButtonLeftRight1.Location = new Point(110, 0x77);
            this.crystalButtonLeftRight1.Margin = new Padding(3, 4, 3, 4);
            this.crystalButtonLeftRight1.Name = "crystalButtonLeftRight1";
            this.crystalButtonLeftRight1.Size = new Size(70, 0x1c);
            this.crystalButtonLeftRight1.Speed = 10;
            this.crystalButtonLeftRight1.TabIndex = 4;
            this.crystalButtonLeftRight1.Click += new EventHandler(this.crystalButtonLeftRight1_Click);
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(15, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x29, 12);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Label3";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x11c, 160);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.crystalButtonLeftRight1);
            base.Controls.Add(this.numericUpDown2);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.numericUpDown1);
            base.Controls.Add(this.Label1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Name = "FormBlankInfo";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "填空格信息";
            base.Load += new EventHandler(this.FormBlankInfo_Load);
            this.numericUpDown1.EndInit();
            this.numericUpDown2.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }
		/// <summary>
		/// Gets the max count.
		/// </summary>
		/// <value>The max count.</value>
        public int MaxCount
        {
            get
            {
                return (int) this.numericUpDown1.Value;
            }
        }
		/// <summary>
		/// Gets the minimum width.
		/// </summary>
		/// <value>The minimum width.</value>
        public float MinWidth
        {
            get
            {
                return (float) this.numericUpDown2.Value;
            }
        }
    }
}

