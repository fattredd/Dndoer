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
            this.DiceInput = new System.Windows.Forms.TextBox();
            this.errorMsg = new System.Windows.Forms.Label();
            this.d20Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.d20Image)).BeginInit();
            this.SuspendLayout();
            // 
            // d20RollBttn
            // 
            this.d20RollBttn.Font = new System.Drawing.Font("Arial Unicode", 12F);
            this.d20RollBttn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.d20RollBttn.Location = new System.Drawing.Point(191, 215);
            this.d20RollBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.d20RollBttn.Name = "d20RollBttn";
            this.d20RollBttn.Size = new System.Drawing.Size(140, 48);
            this.d20RollBttn.TabIndex = 1;
            this.d20RollBttn.Text = "Roll Dice";
            this.d20RollBttn.UseVisualStyleBackColor = true;
            this.d20RollBttn.Click += new System.EventHandler(this.d20RollBttn_Click);
            // 
            // resultD20
            // 
            this.resultD20.Font = new System.Drawing.Font("Arial Unicode", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultD20.ForeColor = System.Drawing.Color.Black;
            this.resultD20.Location = new System.Drawing.Point(191, 18);
            this.resultD20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultD20.Name = "resultD20";
            this.resultD20.Size = new System.Drawing.Size(140, 186);
            this.resultD20.TabIndex = 0;
            this.resultD20.Text = "0";
            this.resultD20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultD20.Click += new System.EventHandler(this.resultD20_Click);
            // 
            // DiceInput
            // 
            this.DiceInput.BackColor = System.Drawing.Color.Snow;
            this.DiceInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiceInput.Font = new System.Drawing.Font("Arial Unicode", 12F);
            this.DiceInput.Location = new System.Drawing.Point(19, 217);
            this.DiceInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiceInput.Name = "DiceInput";
            this.DiceInput.Size = new System.Drawing.Size(164, 40);
            this.DiceInput.TabIndex = 2;
            this.DiceInput.Text = "1d20+2";
            // 
            // errorMsg
            // 
            this.errorMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMsg.Location = new System.Drawing.Point(196, 18);
            this.errorMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(135, 62);
            this.errorMsg.TabIndex = 6;
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // d20Image
            // 
            this.d20Image.Image = global::Dndoer.Properties.Resources.twenty_sided_dice;
            this.d20Image.Location = new System.Drawing.Point(18, 18);
            this.d20Image.Margin = new System.Windows.Forms.Padding(0);
            this.d20Image.Name = "d20Image";
            this.d20Image.Size = new System.Drawing.Size(165, 189);
            this.d20Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.d20Image.TabIndex = 2;
            this.d20Image.TabStop = false;
            this.d20Image.Click += new System.EventHandler(this.d20Image_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(350, 288);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.DiceInput);
            this.Controls.Add(this.d20Image);
            this.Controls.Add(this.resultD20);
            this.Controls.Add(this.d20RollBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "DnDoer";
            this.TransparencyKey = System.Drawing.Color.White;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_keypress);
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

