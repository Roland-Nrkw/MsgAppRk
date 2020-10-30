namespace Msg_Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Receive = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Send = new System.Windows.Forms.Button();
            this.numericUpDown_Nr_Msgs = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Queue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_Msgs = new System.Windows.Forms.RichTextBox();
            this.textBox_ConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nr_Msgs)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(159, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "buggy, see note in code-behind.Thanks for fixing me!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Demo for the Azure Service Bus, course day 3";
            // 
            // button_Receive
            // 
            this.button_Receive.Location = new System.Drawing.Point(45, 222);
            this.button_Receive.Name = "button_Receive";
            this.button_Receive.Size = new System.Drawing.Size(75, 23);
            this.button_Receive.TabIndex = 21;
            this.button_Receive.Text = "Receive";
            this.button_Receive.UseVisualStyleBackColor = true;
            this.button_Receive.Click += new System.EventHandler(this.button_Receive_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear.Location = new System.Drawing.Point(296, 241);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 20;
            this.button_Clear.Text = "clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(45, 177);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 19;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // numericUpDown_Nr_Msgs
            // 
            this.numericUpDown_Nr_Msgs.Location = new System.Drawing.Point(150, 130);
            this.numericUpDown_Nr_Msgs.Name = "numericUpDown_Nr_Msgs";
            this.numericUpDown_Nr_Msgs.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Nr_Msgs.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nr of Messages:";
            // 
            // textBox_Queue
            // 
            this.textBox_Queue.Location = new System.Drawing.Point(150, 91);
            this.textBox_Queue.Name = "textBox_Queue";
            this.textBox_Queue.Size = new System.Drawing.Size(100, 20);
            this.textBox_Queue.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Queue:";
            // 
            // richTextBox_Msgs
            // 
            this.richTextBox_Msgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Msgs.Location = new System.Drawing.Point(11, 270);
            this.richTextBox_Msgs.Name = "richTextBox_Msgs";
            this.richTextBox_Msgs.Size = new System.Drawing.Size(360, 161);
            this.richTextBox_Msgs.TabIndex = 14;
            this.richTextBox_Msgs.Text = "";
            // 
            // textBox_ConnectionString
            // 
            this.textBox_ConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ConnectionString.Location = new System.Drawing.Point(150, 51);
            this.textBox_ConnectionString.Name = "textBox_ConnectionString";
            this.textBox_ConnectionString.Size = new System.Drawing.Size(221, 20);
            this.textBox_ConnectionString.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Connection string:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Receive);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.numericUpDown_Nr_Msgs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Queue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_Msgs);
            this.Controls.Add(this.textBox_ConnectionString);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(402, 489);
            this.Name = "Form1";
            this.Text = "Message App";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nr_Msgs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Receive;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.NumericUpDown numericUpDown_Nr_Msgs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Queue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_Msgs;
        private System.Windows.Forms.TextBox textBox_ConnectionString;
        private System.Windows.Forms.Label label1;
    }
}

