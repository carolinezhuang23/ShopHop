
namespace ShopHop
{
    partial class AddItemsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.addFormCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Items";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(113, 88);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(265, 20);
            this.txtItem.TabIndex = 1;
            // 
            // addItemButton
            // 
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addItemButton.Location = new System.Drawing.Point(113, 148);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(260, 61);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // addFormCloseButton
            // 
            this.addFormCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addFormCloseButton.Location = new System.Drawing.Point(113, 251);
            this.addFormCloseButton.Name = "addFormCloseButton";
            this.addFormCloseButton.Size = new System.Drawing.Size(260, 68);
            this.addFormCloseButton.TabIndex = 3;
            this.addFormCloseButton.Text = "Close ";
            this.addFormCloseButton.UseVisualStyleBackColor = true;
            this.addFormCloseButton.Click += new System.EventHandler(this.addFormCloseButton_Click);
            // 
            // AddItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(477, 350);
            this.Controls.Add(this.addFormCloseButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Name = "AddItemsForm";
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.AddItemsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button addFormCloseButton;
    }
}