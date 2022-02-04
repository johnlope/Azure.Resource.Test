
namespace Azure.Resource.Test.SendMessages
{
    partial class Main
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnSendToEventGrid = new System.Windows.Forms.Button();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.lblAccessKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 316);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(13, 341);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(487, 201);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(67, 567);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(184, 23);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send Message To Service Bus";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(13, 13);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(103, 15);
            this.lblConnectionString.TabIndex = 3;
            this.lblConnectionString.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(13, 32);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(487, 94);
            this.txtConnectionString.TabIndex = 4;
            // 
            // btnSendToEventGrid
            // 
            this.btnSendToEventGrid.Location = new System.Drawing.Point(270, 567);
            this.btnSendToEventGrid.Name = "btnSendToEventGrid";
            this.btnSendToEventGrid.Size = new System.Drawing.Size(171, 23);
            this.btnSendToEventGrid.TabIndex = 5;
            this.btnSendToEventGrid.Text = "Send Message To Event Grid";
            this.btnSendToEventGrid.UseVisualStyleBackColor = true;
            this.btnSendToEventGrid.Click += new System.EventHandler(this.btnSendToEventGrid_Click);
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Location = new System.Drawing.Point(13, 186);
            this.txtAccessKey.Multiline = true;
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.Size = new System.Drawing.Size(487, 94);
            this.txtAccessKey.TabIndex = 7;
            // 
            // lblAccessKey
            // 
            this.lblAccessKey.AutoSize = true;
            this.lblAccessKey.Location = new System.Drawing.Point(13, 167);
            this.lblAccessKey.Name = "lblAccessKey";
            this.lblAccessKey.Size = new System.Drawing.Size(65, 15);
            this.lblAccessKey.TabIndex = 6;
            this.lblAccessKey.Text = "Access Key";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 619);
            this.Controls.Add(this.txtAccessKey);
            this.Controls.Add(this.lblAccessKey);
            this.Controls.Add(this.btnSendToEventGrid);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.MaximumSize = new System.Drawing.Size(550, 1500);
            this.Name = "Main";
            this.Text = "Send Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnSendToEventGrid;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.Label lblAccessKey;
    }
}

