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
            this.d20Image = new System.Windows.Forms.PictureBox();
            this.DiceInput = new System.Windows.Forms.TextBox();
            this.errorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.d20Image)).BeginInit();
            this.SuspendLayout();
            // 
            // d20RollBttn
            // 
            this.d20RollBttn.Font = new System.Drawing.Font("Arial Unicode", 12F);
            this.d20RollBttn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.d20RollBttn.Location = new System.Drawing.Point(131, 97);
            this.d20RollBttn.Name = "d20RollBttn";
            this.d20RollBttn.Size = new System.Drawing.Size(90, 31);
            this.d20RollBttn.TabIndex = 1;
            this.d20RollBttn.Text = "Roll Dice";
            this.d20RollBttn.UseVisualStyleBackColor = true;
            this.d20RollBttn.Click += new System.EventHandler(this.d20RollBttn_Click);
            // 
            // resultD20
            // 
            this.resultD20.Font = new System.Drawing.Font("Arial Unicode", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultD20.ForeColor = System.Drawing.Color.Black;
            this.resultD20.Location = new System.Drawing.Point(131, 12);
            this.resultD20.Name = "resultD20";
            this.resultD20.Size = new System.Drawing.Size(90, 80);
            this.resultD20.TabIndex = 5;
            this.resultD20.Text = "0";
            this.resultD20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d20Image
            // 
            this.d20Image.Image = global::Dndoer.Properties.Resources.twenty_sided_dice;
            this.d20Image.Location = new System.Drawing.Point(12, 12);
            this.d20Image.Name = "d20Image";
            this.d20Image.Size = new System.Drawing.Size(109, 80);
            this.d20Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d20Image.TabIndex = 2;
            this.d20Image.TabStop = false;
            this.d20Image.Click += new System.EventHandler(this.d20Image_Click);
            // 
            // DiceInput
            // 
            this.DiceInput.BackColor = System.Drawing.Color.Snow;
            this.DiceInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiceInput.Font = new System.Drawing.Font("Arial Unicode", 12F);
            this.DiceInput.Location = new System.Drawing.Point(12, 98);
            this.DiceInput.Name = "DiceInput";
            this.DiceInput.Size = new System.Drawing.Size(110, 29);
            this.DiceInput.TabIndex = 4;
            this.DiceInput.Text = "1d20+2";
            // 
            // errorMsg
            // 
            this.errorMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMsg.Location = new System.Drawing.Point(106, 12);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(115, 26);
            this.errorMsg.TabIndex = 6;
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 139);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.DiceInput);
            this.Controls.Add(this.d20Image);
            this.Controls.Add(this.resultD20);
            this.Controls.Add(this.d20RollBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DnDoer";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.d20Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button d20RollBttn;
        private System.Windows.Forms.Label resultD20;
        private System.Windows.Forms.PictureBox d20Image;
        private System.Windows.Forms.TextBox DiceInput;
        private System.Windows.Forms.Label errorMsg;
    }
}

