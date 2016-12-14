namespace TicTacToe
{
    partial class TicTacToeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A0 = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.C0 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.gridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.newGameToolStripMenuItem.Text = "Restart";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A0
            // 
            this.A0.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A0.Location = new System.Drawing.Point(3, 3);
            this.A0.Name = "A0";
            this.A0.Size = new System.Drawing.Size(197, 197);
            this.A0.TabIndex = 1;
            this.A0.UseVisualStyleBackColor = true;
            // 
            // B0
            // 
            this.B0.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B0.Location = new System.Drawing.Point(206, 3);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(197, 197);
            this.B0.TabIndex = 2;
            this.B0.UseVisualStyleBackColor = true;
            // 
            // C0
            // 
            this.C0.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C0.Location = new System.Drawing.Point(409, 3);
            this.C0.Name = "C0";
            this.C0.Size = new System.Drawing.Size(197, 197);
            this.C0.TabIndex = 3;
            this.C0.UseVisualStyleBackColor = true;
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(3, 206);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(197, 197);
            this.A1.TabIndex = 4;
            this.A1.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(206, 206);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(197, 197);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(409, 206);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(197, 197);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(3, 409);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(197, 197);
            this.A2.TabIndex = 7;
            this.A2.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(206, 409);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(197, 197);
            this.B2.TabIndex = 8;
            this.B2.UseVisualStyleBackColor = true;
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(409, 409);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(197, 197);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = true;
            // 
            // gridPanel
            // 
            this.gridPanel.ColumnCount = 3;
            this.gridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.gridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.gridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.gridPanel.Controls.Add(this.A0, 0, 0);
            this.gridPanel.Controls.Add(this.C2, 2, 2);
            this.gridPanel.Controls.Add(this.B0, 1, 0);
            this.gridPanel.Controls.Add(this.B2, 1, 2);
            this.gridPanel.Controls.Add(this.C0, 2, 0);
            this.gridPanel.Controls.Add(this.A2, 0, 2);
            this.gridPanel.Controls.Add(this.A1, 0, 1);
            this.gridPanel.Controls.Add(this.C1, 2, 1);
            this.gridPanel.Controls.Add(this.B1, 1, 1);
            this.gridPanel.Location = new System.Drawing.Point(12, 51);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.RowCount = 3;
            this.gridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gridPanel.Size = new System.Drawing.Size(612, 612);
            this.gridPanel.TabIndex = 10;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 675);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicTacToeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A0;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button C0;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.TableLayoutPanel gridPanel;
    }
}

