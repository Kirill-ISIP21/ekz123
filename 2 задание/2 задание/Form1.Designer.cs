namespace _2_задание
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStartInfo = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblSideC = new System.Windows.Forms.Label();
            this.rdBS = new System.Windows.Forms.RadioButton();
            this.rdBP = new System.Windows.Forms.RadioButton();
            this.btnCalculated = new System.Windows.Forms.Button();
            this.nUpDSideA = new System.Windows.Forms.NumericUpDown();
            this.nUpDSideB = new System.Windows.Forms.NumericUpDown();
            this.nUpDSideC = new System.Windows.Forms.NumericUpDown();
            this.txtBAnswer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDSideA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDSideB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDSideC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartInfo
            // 
            this.lblStartInfo.AutoSize = true;
            this.lblStartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartInfo.Location = new System.Drawing.Point(60, 40);
            this.lblStartInfo.Name = "lblStartInfo";
            this.lblStartInfo.Size = new System.Drawing.Size(174, 24);
            this.lblStartInfo.TabIndex = 0;
            this.lblStartInfo.Text = "Исходные данные";
            this.lblStartInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResults.Location = new System.Drawing.Point(489, 40);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(205, 24);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Результаты расчетов";
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSideA.Location = new System.Drawing.Point(60, 123);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(99, 24);
            this.lblSideA.TabIndex = 2;
            this.lblSideA.Text = "сторона a";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSideB.Location = new System.Drawing.Point(60, 184);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(100, 24);
            this.lblSideB.TabIndex = 3;
            this.lblSideB.Text = "сторона b";
            // 
            // lblSideC
            // 
            this.lblSideC.AutoSize = true;
            this.lblSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSideC.Location = new System.Drawing.Point(60, 249);
            this.lblSideC.Name = "lblSideC";
            this.lblSideC.Size = new System.Drawing.Size(99, 24);
            this.lblSideC.TabIndex = 4;
            this.lblSideC.Text = "сторона c";
            // 
            // rdBS
            // 
            this.rdBS.AutoSize = true;
            this.rdBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBS.Location = new System.Drawing.Point(467, 119);
            this.rdBS.Name = "rdBS";
            this.rdBS.Size = new System.Drawing.Size(209, 28);
            this.rdBS.TabIndex = 8;
            this.rdBS.TabStop = true;
            this.rdBS.Text = "Вычислить площадь";
            this.rdBS.UseVisualStyleBackColor = true;
            // 
            // rdBP
            // 
            this.rdBP.AutoSize = true;
            this.rdBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBP.Location = new System.Drawing.Point(467, 180);
            this.rdBP.Name = "rdBP";
            this.rdBP.Size = new System.Drawing.Size(220, 28);
            this.rdBP.TabIndex = 9;
            this.rdBP.TabStop = true;
            this.rdBP.Text = "Вычислить периметр";
            this.rdBP.UseVisualStyleBackColor = true;
            // 
            // btnCalculated
            // 
            this.btnCalculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculated.Location = new System.Drawing.Point(310, 296);
            this.btnCalculated.Name = "btnCalculated";
            this.btnCalculated.Size = new System.Drawing.Size(134, 41);
            this.btnCalculated.TabIndex = 10;
            this.btnCalculated.Text = "Вычислить";
            this.btnCalculated.UseVisualStyleBackColor = true;
            this.btnCalculated.Click += new System.EventHandler(this.btnCalculated_Click);
            // 
            // nUpDSideA
            // 
            this.nUpDSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUpDSideA.Location = new System.Drawing.Point(166, 121);
            this.nUpDSideA.Name = "nUpDSideA";
            this.nUpDSideA.Size = new System.Drawing.Size(120, 29);
            this.nUpDSideA.TabIndex = 11;
            this.nUpDSideA.ValueChanged += new System.EventHandler(this.nUpDSideA_ValueChanged);
            this.nUpDSideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nUpDSideA_KeyPress);
            // 
            // nUpDSideB
            // 
            this.nUpDSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUpDSideB.Location = new System.Drawing.Point(166, 182);
            this.nUpDSideB.Name = "nUpDSideB";
            this.nUpDSideB.Size = new System.Drawing.Size(120, 29);
            this.nUpDSideB.TabIndex = 12;
            this.nUpDSideB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nUpDSideB_KeyPress);
            // 
            // nUpDSideC
            // 
            this.nUpDSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUpDSideC.Location = new System.Drawing.Point(166, 247);
            this.nUpDSideC.Name = "nUpDSideC";
            this.nUpDSideC.Size = new System.Drawing.Size(120, 29);
            this.nUpDSideC.TabIndex = 13;
            this.nUpDSideC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nUpDSideC_KeyPress);
            // 
            // txtBAnswer
            // 
            this.txtBAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBAnswer.Location = new System.Drawing.Point(507, 301);
            this.txtBAnswer.Name = "txtBAnswer";
            this.txtBAnswer.Size = new System.Drawing.Size(108, 29);
            this.txtBAnswer.TabIndex = 14;
            this.txtBAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBAnswer_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 365);
            this.Controls.Add(this.txtBAnswer);
            this.Controls.Add(this.nUpDSideC);
            this.Controls.Add(this.nUpDSideB);
            this.Controls.Add(this.nUpDSideA);
            this.Controls.Add(this.btnCalculated);
            this.Controls.Add(this.rdBP);
            this.Controls.Add(this.rdBS);
            this.Controls.Add(this.lblSideC);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.lblSideA);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblStartInfo);
            this.Name = "Form1";
            this.Text = "Вычисление треугольника";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDSideA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDSideB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDSideC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartInfo;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.RadioButton rdBS;
        private System.Windows.Forms.RadioButton rdBP;
        private System.Windows.Forms.Button btnCalculated;
        private System.Windows.Forms.NumericUpDown nUpDSideA;
        private System.Windows.Forms.NumericUpDown nUpDSideB;
        private System.Windows.Forms.NumericUpDown nUpDSideC;
        private System.Windows.Forms.TextBox txtBAnswer;
    }
}

