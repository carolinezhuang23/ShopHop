﻿
namespace ShopHop
{
    partial class GroceryDetailsForm
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
            this.lstGroceryList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editListButton = new System.Windows.Forms.Button();
            this.deleteListButton = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGroceryList
            // 
            this.lstGroceryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.lstGroceryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lstGroceryList.FormattingEnabled = true;
            this.lstGroceryList.ItemHeight = 25;
            this.lstGroceryList.Location = new System.Drawing.Point(42, 100);
            this.lstGroceryList.Name = "lstGroceryList";
            this.lstGroceryList.Size = new System.Drawing.Size(273, 429);
            this.lstGroceryList.TabIndex = 1;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grocery Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editListButton
            // 
            this.editListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.editListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.editListButton.Location = new System.Drawing.Point(418, 113);
            this.editListButton.Name = "editListButton";
            this.editListButton.Size = new System.Drawing.Size(210, 54);
            this.editListButton.TabIndex = 3;
            this.editListButton.Text = "Edit";
            this.editListButton.UseVisualStyleBackColor = false;
            this.editListButton.Click += new System.EventHandler(this.editListButton_Click);
            // 
            // deleteListButton
            // 
            this.deleteListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.deleteListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.deleteListButton.Location = new System.Drawing.Point(418, 234);
            this.deleteListButton.Name = "deleteListButton";
            this.deleteListButton.Size = new System.Drawing.Size(213, 57);
            this.deleteListButton.TabIndex = 4;
            this.deleteListButton.Text = "Delete";
            this.deleteListButton.UseVisualStyleBackColor = false;
            this.deleteListButton.Click += new System.EventHandler(this.deleteListButton_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnAdd.Location = new System.Drawing.Point(418, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 56);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Original Items";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GroceryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(685, 579);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.deleteListButton);
            this.Controls.Add(this.editListButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGroceryList);
            this.Name = "GroceryDetailsForm";
            this.Text = "GroceryDetailsForm";
            this.Load += new System.EventHandler(this.GroceryDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstGroceryList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editListButton;
        private System.Windows.Forms.Button deleteListButton;
        private System.Windows.Forms.Button btnAdd;
    }
}