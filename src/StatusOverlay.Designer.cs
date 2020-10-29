using System.Windows.Forms;

namespace SurfSharkStatus
{
    partial class StatusOverlay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusOverlay));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.rightContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSurfsharkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightContextMenu.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.rightContextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Surfshark Status";
            this.notifyIcon1.Visible = true;
            // 
            // rightContextMenu
            // 
            this.rightContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSurfsharkToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.rightContextMenu.Name = "contextMenuStrip1";
            this.rightContextMenu.Size = new System.Drawing.Size(181, 98);
            // 
            // openSurfsharkToolStripMenuItem
            // 
            this.openSurfsharkToolStripMenuItem.Name = "openSurfsharkToolStripMenuItem";
            this.openSurfsharkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSurfsharkToolStripMenuItem.Text = "Open Surfshark";
            this.openSurfsharkToolStripMenuItem.Click += new System.EventHandler(this.OpenSurfsharkToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OpenExitToolStripMenuItem_Click);
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.Size = new System.Drawing.Size(237, 67);
            this.MainLayout.TabIndex = 2;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(55, 17);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(172, 32);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Disconnected";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.6087F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.3913F));
            this.mainLayoutPanel.Controls.Add(this.logoImage, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.statusLabel, 1, 0);
            this.mainLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(230, 66);
            this.mainLayoutPanel.TabIndex = 1;
            // 
            // logoImage
            // 
            this.logoImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logoImage.ErrorImage = null;
            this.logoImage.Image = global::SurfSharkStatus.Properties.Resources.logo;
            this.logoImage.InitialImage = null;
            this.logoImage.Location = new System.Drawing.Point(5, 11);
            this.logoImage.Margin = new System.Windows.Forms.Padding(5);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(42, 44);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 2;
            this.logoImage.TabStop = false;
            this.logoImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Logo_OnMouseDown);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // StatusOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(233, 86);
            this.Controls.Add(this.mainLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusOverlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "StatusOverlay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StatusOverlay_Load);
            this.rightContextMenu.ResumeLayout(false);
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip rightContextMenu;
        private ToolStripMenuItem openSurfsharkToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TableLayoutPanel MainLayout;
        private Label statusLabel;
        private PictureBox logoImage;
        private TableLayoutPanel mainLayoutPanel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem optionsToolStripMenuItem;
    }
}

