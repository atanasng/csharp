namespace upr_3_zad_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.математическиФормулиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгебраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.класToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.класToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.степенуванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.математическиФормулиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // математическиФормулиToolStripMenuItem
            // 
            this.математическиФормулиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алгебраToolStripMenuItem});
            this.математическиФормулиToolStripMenuItem.Name = "математическиФормулиToolStripMenuItem";
            this.математическиФормулиToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.математическиФормулиToolStripMenuItem.Text = "Математически формули";
            this.математическиФормулиToolStripMenuItem.Click += new System.EventHandler(this.математическиФормулиToolStripMenuItem_Click);
            // 
            // алгебраToolStripMenuItem
            // 
            this.алгебраToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.класToolStripMenuItem,
            this.класToolStripMenuItem1,
            this.изходToolStripMenuItem});
            this.алгебраToolStripMenuItem.Name = "алгебраToolStripMenuItem";
            this.алгебраToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.алгебраToolStripMenuItem.Text = "Алгебра";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.степенуванеToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "6 клас";
            // 
            // класToolStripMenuItem
            // 
            this.класToolStripMenuItem.Name = "класToolStripMenuItem";
            this.класToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.класToolStripMenuItem.Text = "7 клас";
            // 
            // класToolStripMenuItem1
            // 
            this.класToolStripMenuItem1.Name = "класToolStripMenuItem1";
            this.класToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.класToolStripMenuItem1.Text = "8 клас";
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.изходToolStripMenuItem.Text = "Изход";
            // 
            // степенуванеToolStripMenuItem
            // 
            this.степенуванеToolStripMenuItem.Name = "степенуванеToolStripMenuItem";
            this.степенуванеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.степенуванеToolStripMenuItem.Text = "Степенуване";
            this.степенуванеToolStripMenuItem.Click += new System.EventHandler(this.степенуванеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem математическиФормулиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгебраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem степенуванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem класToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem класToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
    }
}

