namespace Form_MES_Test
{
    partial class Main
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
            this.button_MoveStd = new System.Windows.Forms.Button();
            this.button_AddFactory = new System.Windows.Forms.Button();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_UpdateFactory = new System.Windows.Forms.Button();
            this.button_DelFactory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MoveStd
            // 
            this.button_MoveStd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_MoveStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MoveStd.Location = new System.Drawing.Point(121, 160);
            this.button_MoveStd.Name = "button_MoveStd";
            this.button_MoveStd.Size = new System.Drawing.Size(111, 62);
            this.button_MoveStd.TabIndex = 0;
            this.button_MoveStd.Text = "Move Std";
            this.button_MoveStd.UseVisualStyleBackColor = true;
            this.button_MoveStd.Click += new System.EventHandler(this.btn_MoveStd);
            // 
            // button_AddFactory
            // 
            this.button_AddFactory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_AddFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddFactory.Location = new System.Drawing.Point(238, 160);
            this.button_AddFactory.Name = "button_AddFactory";
            this.button_AddFactory.Size = new System.Drawing.Size(111, 62);
            this.button_AddFactory.TabIndex = 1;
            this.button_AddFactory.Text = "Add Factory";
            this.button_AddFactory.UseVisualStyleBackColor = true;
            this.button_AddFactory.Click += new System.EventHandler(this.btn_FactoryAdd);
            // 
            // textBox_Log
            // 
            this.textBox_Log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Log.Location = new System.Drawing.Point(26, 270);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Log.Size = new System.Drawing.Size(745, 155);
            this.textBox_Log.TabIndex = 2;
            this.textBox_Log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log";
            // 
            // button_UpdateFactory
            // 
            this.button_UpdateFactory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_UpdateFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateFactory.Location = new System.Drawing.Point(355, 160);
            this.button_UpdateFactory.Name = "button_UpdateFactory";
            this.button_UpdateFactory.Size = new System.Drawing.Size(111, 62);
            this.button_UpdateFactory.TabIndex = 4;
            this.button_UpdateFactory.Text = "Update Factory";
            this.button_UpdateFactory.UseVisualStyleBackColor = true;
            this.button_UpdateFactory.Click += new System.EventHandler(this.btn_FactoryUpdate);
            // 
            // button_DelFactory
            // 
            this.button_DelFactory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_DelFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DelFactory.Location = new System.Drawing.Point(472, 160);
            this.button_DelFactory.Name = "button_DelFactory";
            this.button_DelFactory.Size = new System.Drawing.Size(111, 62);
            this.button_DelFactory.TabIndex = 5;
            this.button_DelFactory.Text = "Delete Factory";
            this.button_DelFactory.UseVisualStyleBackColor = true;
            this.button_DelFactory.Click += new System.EventHandler(this.btn_FactoryDelete);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DelFactory);
            this.Controls.Add(this.button_UpdateFactory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.button_AddFactory);
            this.Controls.Add(this.button_MoveStd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_MoveStd;
        private System.Windows.Forms.Button button_AddFactory;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_UpdateFactory;
        private System.Windows.Forms.Button button_DelFactory;
    }
}

