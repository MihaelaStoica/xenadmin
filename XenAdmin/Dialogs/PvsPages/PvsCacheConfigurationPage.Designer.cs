namespace XenAdmin.Dialogs
{
    partial class PvsCacheConfigurationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PvsCacheConfigurationPage));
            this.tableLayoutPanelBody = new System.Windows.Forms.TableLayoutPanel();
            this.IpAddressSettingsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanelStaticSettings = new System.Windows.Forms.TableLayoutPanel();
            this.RangeEndLabel = new System.Windows.Forms.Label();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.SubnetMastLabel = new System.Windows.Forms.Label();
            this.SubnetTextBox = new System.Windows.Forms.TextBox();
            this.DHCPIPRadioButton = new System.Windows.Forms.RadioButton();
            this.FixedIPRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanelBody.SuspendLayout();
            this.tableLayoutPanelStaticSettings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBody
            // 
            this.tableLayoutPanelBody.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanelBody, "tableLayoutPanelBody");
            this.tableLayoutPanelBody.Controls.Add(this.IpAddressSettingsLabel, 0, 1);
            this.tableLayoutPanelBody.Controls.Add(this.DHCPIPRadioButton, 0, 2);
            this.tableLayoutPanelBody.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutPanelBody.Controls.Add(this.FixedIPRadioButton, 0, 4);
            this.tableLayoutPanelBody.Controls.Add(this.tableLayoutPanelStaticSettings, 1, 5);
            this.tableLayoutPanelBody.Name = "tableLayoutPanelBody";
            // 
            // IpAddressSettingsLabel
            // 
            resources.ApplyResources(this.IpAddressSettingsLabel, "IpAddressSettingsLabel");
            this.tableLayoutPanelBody.SetColumnSpan(this.IpAddressSettingsLabel, 3);
            this.IpAddressSettingsLabel.Name = "IpAddressSettingsLabel";
            // 
            // tableLayoutPanelStaticSettings
            // 
            resources.ApplyResources(this.tableLayoutPanelStaticSettings, "tableLayoutPanelStaticSettings");
            this.tableLayoutPanelBody.SetColumnSpan(this.tableLayoutPanelStaticSettings, 2);
            this.tableLayoutPanelStaticSettings.Controls.Add(this.IPAddressLabel, 0, 0);
            this.tableLayoutPanelStaticSettings.Controls.Add(this.RangeEndLabel, 2, 0);
            this.tableLayoutPanelStaticSettings.Controls.Add(this.IPAddressTextBox, 1, 0);
            this.tableLayoutPanelStaticSettings.Controls.Add(this.SubnetMastLabel, 0, 1);
            this.tableLayoutPanelStaticSettings.Controls.Add(this.SubnetTextBox, 1, 1);
            this.tableLayoutPanelStaticSettings.Name = "tableLayoutPanelStaticSettings";
            this.tableLayoutPanelStaticSettings.TabStop = true;
            // 
            // RangeEndLabel
            // 
            resources.ApplyResources(this.RangeEndLabel, "RangeEndLabel");
            this.RangeEndLabel.Name = "RangeEndLabel";
            // 
            // IPAddressTextBox
            // 
            resources.ApplyResources(this.IPAddressTextBox, "IPAddressTextBox");
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.TextChanged += new System.EventHandler(this.IPAddressTextBox_TextChanged);
            // 
            // SubnetMastLabel
            // 
            resources.ApplyResources(this.SubnetMastLabel, "SubnetMastLabel");
            this.SubnetMastLabel.Name = "SubnetMastLabel";
            // 
            // SubnetTextBox
            // 
            resources.ApplyResources(this.SubnetTextBox, "SubnetTextBox");
            this.SubnetTextBox.Name = "SubnetTextBox";
            this.SubnetTextBox.TextChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // DHCPIPRadioButton
            // 
            resources.ApplyResources(this.DHCPIPRadioButton, "DHCPIPRadioButton");
            this.tableLayoutPanelBody.SetColumnSpan(this.DHCPIPRadioButton, 3);
            this.DHCPIPRadioButton.Name = "DHCPIPRadioButton";
            this.DHCPIPRadioButton.TabStop = true;
            this.DHCPIPRadioButton.UseVisualStyleBackColor = true;
            this.DHCPIPRadioButton.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // FixedIPRadioButton
            // 
            resources.ApplyResources(this.FixedIPRadioButton, "FixedIPRadioButton");
            this.FixedIPRadioButton.Checked = true;
            this.tableLayoutPanelBody.SetColumnSpan(this.FixedIPRadioButton, 3);
            this.FixedIPRadioButton.Name = "FixedIPRadioButton";
            this.FixedIPRadioButton.TabStop = true;
            this.FixedIPRadioButton.UseVisualStyleBackColor = true;
            this.FixedIPRadioButton.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanelBody.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.TabStop = true;
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // IPAddressLabel
            // 
            resources.ApplyResources(this.IPAddressLabel, "IPAddressLabel");
            this.IPAddressLabel.Name = "IPAddressLabel";
            // 
            // PvsCacheConfigurationPage
            // 
            this.Controls.Add(this.tableLayoutPanelBody);
            this.DoubleBuffered = true;
            resources.ApplyResources(this, "$this");
            this.Name = "PvsCacheConfigurationPage";
            this.tableLayoutPanelBody.ResumeLayout(false);
            this.tableLayoutPanelBody.PerformLayout();
            this.tableLayoutPanelStaticSettings.ResumeLayout(false);
            this.tableLayoutPanelStaticSettings.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label RangeEndLabel;
        private System.Windows.Forms.Label SubnetMastLabel;
        internal System.Windows.Forms.TextBox SubnetTextBox;
        internal System.Windows.Forms.RadioButton FixedIPRadioButton;
        internal System.Windows.Forms.RadioButton DHCPIPRadioButton;
        internal System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStaticSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBody;
        private System.Windows.Forms.Label IpAddressSettingsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label IPAddressLabel;
    }
}
