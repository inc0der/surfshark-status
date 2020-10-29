namespace SurfSharkStatus
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.onlyDisplayOption = new System.Windows.Forms.CheckBox();
            this.disconnectNotifyOption = new System.Windows.Forms.CheckBox();
            this.connectNotifyOption = new System.Windows.Forms.CheckBox();
            this.opacityBar = new System.Windows.Forms.TrackBar();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // onlyDisplayOption
            // 
            this.onlyDisplayOption.AutoSize = true;
            this.onlyDisplayOption.Location = new System.Drawing.Point(6, 19);
            this.onlyDisplayOption.Name = "onlyDisplayOption";
            this.onlyDisplayOption.Size = new System.Drawing.Size(178, 17);
            this.onlyDisplayOption.TabIndex = 0;
            this.onlyDisplayOption.Text = "Only display when disconnected";
            this.onlyDisplayOption.UseVisualStyleBackColor = true;
            this.onlyDisplayOption.CheckedChanged += new System.EventHandler(this.OnlyDisplayOnDisconnectOption_CheckedChanged);
            // 
            // disconnectNotifyOption
            // 
            this.disconnectNotifyOption.AutoSize = true;
            this.disconnectNotifyOption.Location = new System.Drawing.Point(6, 35);
            this.disconnectNotifyOption.Name = "disconnectNotifyOption";
            this.disconnectNotifyOption.Size = new System.Drawing.Size(123, 17);
            this.disconnectNotifyOption.TabIndex = 2;
            this.disconnectNotifyOption.Text = "Notify on disconnect";
            this.disconnectNotifyOption.UseVisualStyleBackColor = true;
            this.disconnectNotifyOption.CheckedChanged += new System.EventHandler(this.DisconnectNotifyOption_CheckedChanged);
            // 
            // connectNotifyOption
            // 
            this.connectNotifyOption.AutoSize = true;
            this.connectNotifyOption.Location = new System.Drawing.Point(6, 19);
            this.connectNotifyOption.Name = "connectNotifyOption";
            this.connectNotifyOption.Size = new System.Drawing.Size(110, 17);
            this.connectNotifyOption.TabIndex = 3;
            this.connectNotifyOption.Text = "Notify on connect";
            this.connectNotifyOption.UseVisualStyleBackColor = true;
            this.connectNotifyOption.CheckedChanged += new System.EventHandler(this.ConnectNotifyOption_CheckedChanged);
            // 
            // opacityBar
            // 
            this.opacityBar.BackColor = System.Drawing.SystemColors.Control;
            this.opacityBar.Location = new System.Drawing.Point(-1, 62);
            this.opacityBar.Maximum = 255;
            this.opacityBar.Minimum = 1;
            this.opacityBar.Name = "opacityBar";
            this.opacityBar.Size = new System.Drawing.Size(200, 32);
            this.opacityBar.TabIndex = 0;
            this.opacityBar.Value = 155;
            this.opacityBar.Scroll += new System.EventHandler(this.OpacityBar_Scroll);
            // 
            // opacityLabel
            // 
            this.opacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(3, 46);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(43, 13);
            this.opacityLabel.TabIndex = 1;
            this.opacityLabel.Text = "Opacity";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.okButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cancelButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 195);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(183, 34);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(3, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(85, 28);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(94, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnectNotifyOption);
            this.groupBox1.Controls.Add(this.connectNotifyOption);
            this.groupBox1.Location = new System.Drawing.Point(13, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.onlyDisplayOption);
            this.groupBox2.Controls.Add(this.opacityLabel);
            this.groupBox2.Controls.Add(this.opacityBar);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Window Options";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(225, 240);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox onlyDisplayOption;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.TrackBar opacityBar;
        private System.Windows.Forms.CheckBox disconnectNotifyOption;
        private System.Windows.Forms.CheckBox connectNotifyOption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}