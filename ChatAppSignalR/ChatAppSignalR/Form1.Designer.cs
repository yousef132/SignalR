namespace ChatAppSignalR
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
            name = new TextBox();
            send = new Button();
            join = new Button();
            sendgroup = new Button();
            message = new TextBox();
            group = new TextBox();
            messages = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(348, 30);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 0;
            // 
            // send
            // 
            send.Location = new Point(379, 93);
            send.Name = "send";
            send.Size = new Size(94, 29);
            send.TabIndex = 1;
            send.Text = "send";
            send.UseVisualStyleBackColor = true;
            send.Click += button1_Click;
            // 
            // join
            // 
            join.Location = new Point(379, 153);
            join.Name = "join";
            join.Size = new Size(94, 29);
            join.TabIndex = 2;
            join.Text = "join";
            join.UseVisualStyleBackColor = true;
            // 
            // sendgroup
            // 
            sendgroup.Location = new Point(268, 219);
            sendgroup.Name = "sendgroup";
            sendgroup.Size = new Size(181, 41);
            sendgroup.TabIndex = 3;
            sendgroup.Text = "sendgroup";
            sendgroup.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            message.Location = new Point(188, 93);
            message.Name = "message";
            message.Size = new Size(125, 27);
            message.TabIndex = 4;
            // 
            // group
            // 
            group.Location = new Point(188, 155);
            group.Name = "group";
            group.Size = new Size(125, 27);
            group.TabIndex = 5;
            // 
            // messages
            // 
            messages.FormattingEnabled = true;
            messages.Location = new Point(104, 356);
            messages.Name = "messages";
            messages.Size = new Size(645, 164);
            messages.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 95);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 7;
            label1.Text = "Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 158);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Group";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 31);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 576);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(messages);
            Controls.Add(group);
            Controls.Add(message);
            Controls.Add(sendgroup);
            Controls.Add(join);
            Controls.Add(send);
            Controls.Add(name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private Button send;
        private Button join;
        private Button sendgroup;
        private TextBox message;
        private TextBox group;
        private ListBox messages;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
