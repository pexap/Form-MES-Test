﻿namespace Form_MES_Test
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
            this.button_AddResource = new System.Windows.Forms.Button();
            this.button_UpdateResource = new System.Windows.Forms.Button();
            this.button_DeleteResource = new System.Windows.Forms.Button();
            this.button_GetResource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MoveStd
            // 
            this.button_MoveStd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_MoveStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MoveStd.Location = new System.Drawing.Point(186, 87);
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
            this.button_AddFactory.Location = new System.Drawing.Point(303, 87);
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
            this.button_UpdateFactory.Location = new System.Drawing.Point(420, 87);
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
            this.button_DelFactory.Location = new System.Drawing.Point(537, 87);
            this.button_DelFactory.Name = "button_DelFactory";
            this.button_DelFactory.Size = new System.Drawing.Size(111, 62);
            this.button_DelFactory.TabIndex = 5;
            this.button_DelFactory.Text = "Delete Factory";
            this.button_DelFactory.UseVisualStyleBackColor = true;
            this.button_DelFactory.Click += new System.EventHandler(this.btn_FactoryDelete);
            // 
            // button_AddResource
            // 
            this.button_AddResource.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_AddResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddResource.Location = new System.Drawing.Point(186, 155);
            this.button_AddResource.Name = "button_AddResource";
            this.button_AddResource.Size = new System.Drawing.Size(111, 62);
            this.button_AddResource.TabIndex = 6;
            this.button_AddResource.Text = "Add Resource";
            this.button_AddResource.UseVisualStyleBackColor = true;
            this.button_AddResource.Click += new System.EventHandler(this.btn_ResourceAdd);
            // 
            // button_UpdateResource
            // 
            this.button_UpdateResource.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_UpdateResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateResource.Location = new System.Drawing.Point(303, 155);
            this.button_UpdateResource.Name = "button_UpdateResource";
            this.button_UpdateResource.Size = new System.Drawing.Size(111, 62);
            this.button_UpdateResource.TabIndex = 7;
            this.button_UpdateResource.Text = "Update Resource";
            this.button_UpdateResource.UseVisualStyleBackColor = true;
            this.button_UpdateResource.Click += new System.EventHandler(this.btn_ResourceUpdate);
            // 
            // button_DeleteResource
            // 
            this.button_DeleteResource.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_DeleteResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteResource.Location = new System.Drawing.Point(420, 155);
            this.button_DeleteResource.Name = "button_DeleteResource";
            this.button_DeleteResource.Size = new System.Drawing.Size(111, 62);
            this.button_DeleteResource.TabIndex = 8;
            this.button_DeleteResource.Text = "Delete Resource";
            this.button_DeleteResource.UseVisualStyleBackColor = true;
            this.button_DeleteResource.Click += new System.EventHandler(this.btn_ResourceDelete);
            // 
            // button_GetResource
            // 
            this.button_GetResource.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_GetResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetResource.Location = new System.Drawing.Point(537, 155);
            this.button_GetResource.Name = "button_GetResource";
            this.button_GetResource.Size = new System.Drawing.Size(111, 62);
            this.button_GetResource.TabIndex = 9;
            this.button_GetResource.Text = "Get Resource";
            this.button_GetResource.UseVisualStyleBackColor = true;
            this.button_GetResource.Click += new System.EventHandler(this.btn_ResourceGet);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_GetResource);
            this.Controls.Add(this.button_DeleteResource);
            this.Controls.Add(this.button_UpdateResource);
            this.Controls.Add(this.button_AddResource);
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
        private System.Windows.Forms.Button button_AddResource;
        private System.Windows.Forms.Button button_UpdateResource;
        private System.Windows.Forms.Button button_DeleteResource;
        private System.Windows.Forms.Button button_GetResource;
    }
}

