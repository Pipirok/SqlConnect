namespace SqlConnect
{
    partial class Form1
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
            this.buttonSqlAction = new System.Windows.Forms.Button();
            this.labelConnectionState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSqlAction
            // 
            this.buttonSqlAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSqlAction.Location = new System.Drawing.Point(389, 88);
            this.buttonSqlAction.Name = "buttonSqlAction";
            this.buttonSqlAction.Size = new System.Drawing.Size(180, 60);
            this.buttonSqlAction.TabIndex = 0;
            this.buttonSqlAction.Text = "Connect";
            this.buttonSqlAction.UseVisualStyleBackColor = true;
            this.buttonSqlAction.Click += new System.EventHandler(this.buttonSqlAction_Click);
            // 
            // labelConnectionState
            // 
            this.labelConnectionState.AutoSize = true;
            this.labelConnectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionState.Location = new System.Drawing.Point(36, 101);
            this.labelConnectionState.Name = "labelConnectionState";
            this.labelConnectionState.Size = new System.Drawing.Size(249, 32);
            this.labelConnectionState.TabIndex = 1;
            this.labelConnectionState.Text = "Connection closed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 277);
            this.Controls.Add(this.labelConnectionState);
            this.Controls.Add(this.buttonSqlAction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSqlAction;
        private System.Windows.Forms.Label labelConnectionState;
    }
}

