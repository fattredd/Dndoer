namespace Dndoer
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
            this.d20RollBttn = new System.Windows.Forms.Button();
            this.resultD20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qtD20 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtD20)).BeginInit();
            this.SuspendLayout();
            // 
            // d20RollBttn
            // 
            this.d20RollBttn.Font = new System.Drawing.Font("Arial Unicode", 12F);
            this.d20RollBttn.Location = new System.Drawing.Point(142, 94);
            this.d20RollBttn.Name = "d20RollBttn";
            this.d20RollBttn.Size = new System.Drawing.Size(75, 30);
            this.d20RollBttn.TabIndex = 1;
            this.d20RollBttn.Text = "Roll D20";
            this.d20RollBttn.UseVisualStyleBackColor = true;
            this.d20RollBttn.Click += new System.EventHandler(this.d20RollBttn_Click);
            // 
            // resultD20
            // 
            this.resultD20.AutoSize = true;
            this.resultD20.Font = new System.Drawing.Font("Arial Unicode", 12F);
            this.resultD20.Location = new System.Drawing.Point(127, 40);
            this.resultD20.Name = "resultD20";
            this.resultD20.Size = new System.Drawing.Size(90, 21);
            this.resultD20.TabIndex = 2;
            this.resultD20.Text = "No Roll Yet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dndoer.Properties.Resources.twenty_sided_dice;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // qtD20
            // 
            this.qtD20.AllowDrop = true;
            this.qtD20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qtD20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtD20.Font = new System.Drawing.Font("Arial Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtD20.Location = new System.Drawing.Point(12, 94);
            this.qtD20.Name = "qtD20";
            this.qtD20.Size = new System.Drawing.Size(124, 29);
            this.qtD20.TabIndex = 0;
            this.qtD20.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 139);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resultD20);
            this.Controls.Add(this.d20RollBttn);
            this.Controls.Add(this.qtD20);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DnDoer";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtD20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button d20RollBttn;
        private System.Windows.Forms.Label resultD20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown qtD20;
    }
}

