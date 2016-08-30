namespace XenAdmin.Dialogs
{
    partial class PvsCacheConfigurationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PvsCacheConfigurationDialog));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.blueBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            resources.ApplyResources(this.ContentPanel, "ContentPanel");
            // 
            // verticalTabs
            // 
            this.verticalTabs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.verticalTabs, "verticalTabs");
            this.verticalTabs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.verticalTabs_MouseClick);
            this.verticalTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.verticalTabs_DrawItem);
            this.verticalTabs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.verticalTabs_MouseMove);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer.Panel1.Resize += new System.EventHandler(this.splitContainer_Panel1_Resize);
            resources.ApplyResources(this.splitContainer, "splitContainer");
            // 
            // blueBorder
            // 
            this.blueBorder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.blueBorder, "blueBorder");
            // 
            // PvsCacheConfigurationDialog
            // 
            resources.ApplyResources(this, "$this");
            this.Name = "PvsCacheConfigurationDialog";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.PvsCacheConfigurationDialog_HelpButtonClicked);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PvsCacheConfigurationDialog_HelpRequested);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.blueBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
