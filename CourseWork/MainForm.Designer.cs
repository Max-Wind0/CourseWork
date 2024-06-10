namespace CourseWork
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.PlotBox = new System.Windows.Forms.PictureBox();
            this.CreatePlotButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.IntervalTLable = new System.Windows.Forms.Label();
            this.IntervalTText = new System.Windows.Forms.TextBox();
            this.NumberOfElementsLabel = new System.Windows.Forms.Label();
            this.NumberOfElementsText = new System.Windows.Forms.TextBox();
            this.NumberOfPointsLable = new System.Windows.Forms.Label();
            this.NumberOfPointsText = new System.Windows.Forms.TextBox();
            this.FuctionLabel = new System.Windows.Forms.Label();
            this.FunctionChoice = new System.Windows.Forms.ComboBox();
            this.ParameterX0Label = new System.Windows.Forms.Label();
            this.ParameterX0Text = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.errorProviderIntervalT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumberOfElements = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumberOfPoints = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderParameterX0 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlotBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIntervalT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberOfElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberOfPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParameterX0)).BeginInit();
            this.SuspendLayout();
            // 
            // PlotBox
            // 
            this.PlotBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlotBox.Location = new System.Drawing.Point(262, 161);
            this.PlotBox.Margin = new System.Windows.Forms.Padding(8);
            this.PlotBox.Name = "PlotBox";
            this.PlotBox.Size = new System.Drawing.Size(648, 395);
            this.PlotBox.TabIndex = 0;
            this.PlotBox.TabStop = false;
            // 
            // CreatePlotButton
            // 
            this.CreatePlotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePlotButton.Location = new System.Drawing.Point(14, 469);
            this.CreatePlotButton.Margin = new System.Windows.Forms.Padding(8);
            this.CreatePlotButton.Name = "CreatePlotButton";
            this.CreatePlotButton.Size = new System.Drawing.Size(195, 41);
            this.CreatePlotButton.TabIndex = 1;
            this.CreatePlotButton.Text = "Построить график";
            this.CreatePlotButton.UseVisualStyleBackColor = true;
            this.CreatePlotButton.Click += new System.EventHandler(this.CreatePlotButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::CourseWork.Properties.Resources.Дифференциальное_уравнение;
            this.PictureBox.Location = new System.Drawing.Point(14, 15);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(8);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(896, 129);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 10;
            this.PictureBox.TabStop = false;
            // 
            // IntervalTLable
            // 
            this.IntervalTLable.AutoSize = true;
            this.IntervalTLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntervalTLable.Location = new System.Drawing.Point(11, 161);
            this.IntervalTLable.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.IntervalTLable.Name = "IntervalTLable";
            this.IntervalTLable.Size = new System.Drawing.Size(126, 17);
            this.IntervalTLable.TabIndex = 12;
            this.IntervalTLable.Text = "Интервал t (ось x)";
            this.IntervalTLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntervalTText
            // 
            this.IntervalTText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntervalTText.Location = new System.Drawing.Point(14, 185);
            this.IntervalTText.Margin = new System.Windows.Forms.Padding(4);
            this.IntervalTText.Name = "IntervalTText";
            this.IntervalTText.Size = new System.Drawing.Size(196, 23);
            this.IntervalTText.TabIndex = 11;
            this.IntervalTText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PositiveDoubleInputCheck_KeyPress);
            this.IntervalTText.Leave += new System.EventHandler(this.IntervalTText_Leave);
            // 
            // NumberOfElementsLabel
            // 
            this.NumberOfElementsLabel.AutoSize = true;
            this.NumberOfElementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfElementsLabel.Location = new System.Drawing.Point(11, 219);
            this.NumberOfElementsLabel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.NumberOfElementsLabel.Name = "NumberOfElementsLabel";
            this.NumberOfElementsLabel.Size = new System.Drawing.Size(174, 17);
            this.NumberOfElementsLabel.TabIndex = 14;
            this.NumberOfElementsLabel.Text = "Количество элементов N";
            this.NumberOfElementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfElementsText
            // 
            this.NumberOfElementsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfElementsText.Location = new System.Drawing.Point(14, 244);
            this.NumberOfElementsText.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfElementsText.Name = "NumberOfElementsText";
            this.NumberOfElementsText.Size = new System.Drawing.Size(196, 23);
            this.NumberOfElementsText.TabIndex = 13;
            this.NumberOfElementsText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInputCheck_KeyPress);
            this.NumberOfElementsText.Leave += new System.EventHandler(this.NumberOfElementsText_Leave);
            // 
            // NumberOfPointsLable
            // 
            this.NumberOfPointsLable.AutoSize = true;
            this.NumberOfPointsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfPointsLable.Location = new System.Drawing.Point(11, 278);
            this.NumberOfPointsLable.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.NumberOfPointsLable.Name = "NumberOfPointsLable";
            this.NumberOfPointsLable.Size = new System.Drawing.Size(187, 17);
            this.NumberOfPointsLable.TabIndex = 16;
            this.NumberOfPointsLable.Text = "Количество точек графика";
            this.NumberOfPointsLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfPointsText
            // 
            this.NumberOfPointsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfPointsText.Location = new System.Drawing.Point(14, 302);
            this.NumberOfPointsText.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfPointsText.Name = "NumberOfPointsText";
            this.NumberOfPointsText.Size = new System.Drawing.Size(196, 23);
            this.NumberOfPointsText.TabIndex = 15;
            this.NumberOfPointsText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInputCheck_KeyPress);
            this.NumberOfPointsText.Leave += new System.EventHandler(this.NumberOfPointsText_Leave);
            // 
            // FuctionLabel
            // 
            this.FuctionLabel.AutoSize = true;
            this.FuctionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuctionLabel.Location = new System.Drawing.Point(11, 395);
            this.FuctionLabel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.FuctionLabel.Name = "FuctionLabel";
            this.FuctionLabel.Size = new System.Drawing.Size(101, 17);
            this.FuctionLabel.TabIndex = 18;
            this.FuctionLabel.Text = "Функция f ( t )";
            this.FuctionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FunctionChoice
            // 
            this.FunctionChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FunctionChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionChoice.FormattingEnabled = true;
            this.FunctionChoice.Location = new System.Drawing.Point(14, 418);
            this.FunctionChoice.Margin = new System.Windows.Forms.Padding(2);
            this.FunctionChoice.Name = "FunctionChoice";
            this.FunctionChoice.Size = new System.Drawing.Size(196, 25);
            this.FunctionChoice.TabIndex = 20;
            // 
            // ParameterX0Label
            // 
            this.ParameterX0Label.AutoSize = true;
            this.ParameterX0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterX0Label.Location = new System.Drawing.Point(11, 336);
            this.ParameterX0Label.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.ParameterX0Label.Name = "ParameterX0Label";
            this.ParameterX0Label.Size = new System.Drawing.Size(92, 17);
            this.ParameterX0Label.TabIndex = 21;
            this.ParameterX0Label.Text = "Параметр x0";
            this.ParameterX0Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParameterX0Text
            // 
            this.ParameterX0Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParameterX0Text.Location = new System.Drawing.Point(14, 361);
            this.ParameterX0Text.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterX0Text.Name = "ParameterX0Text";
            this.ParameterX0Text.Size = new System.Drawing.Size(196, 23);
            this.ParameterX0Text.TabIndex = 19;
            this.ParameterX0Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleInputCheck_KeyPress);
            this.ParameterX0Text.Leave += new System.EventHandler(this.ParameterX0Text_Leave);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.Location = new System.Drawing.Point(11, 526);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(69, 17);
            this.ErrorLabel.TabIndex = 22;
            this.ErrorLabel.Text = "Ошибка: ";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderIntervalT
            // 
            this.errorProviderIntervalT.ContainerControl = this;
            // 
            // errorProviderNumberOfElements
            // 
            this.errorProviderNumberOfElements.ContainerControl = this;
            // 
            // errorProviderNumberOfPoints
            // 
            this.errorProviderNumberOfPoints.ContainerControl = this;
            // 
            // errorProviderParameterX0
            // 
            this.errorProviderParameterX0.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(924, 571);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ParameterX0Label);
            this.Controls.Add(this.ParameterX0Text);
            this.Controls.Add(this.FunctionChoice);
            this.Controls.Add(this.FuctionLabel);
            this.Controls.Add(this.NumberOfPointsLable);
            this.Controls.Add(this.NumberOfPointsText);
            this.Controls.Add(this.NumberOfElementsLabel);
            this.Controls.Add(this.NumberOfElementsText);
            this.Controls.Add(this.IntervalTLable);
            this.Controls.Add(this.IntervalTText);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.CreatePlotButton);
            this.Controls.Add(this.PlotBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Численное решение задачи теплообмена";
            ((System.ComponentModel.ISupportInitialize)(this.PlotBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIntervalT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberOfElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberOfPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParameterX0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlotBox;
        private System.Windows.Forms.Button CreatePlotButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label IntervalTLable;
        private System.Windows.Forms.TextBox IntervalTText;
        private System.Windows.Forms.Label NumberOfElementsLabel;
        private System.Windows.Forms.TextBox NumberOfElementsText;
        private System.Windows.Forms.Label NumberOfPointsLable;
        private System.Windows.Forms.TextBox NumberOfPointsText;
        private System.Windows.Forms.Label FuctionLabel;
        private System.Windows.Forms.ComboBox FunctionChoice;
        private System.Windows.Forms.Label ParameterX0Label;
        private System.Windows.Forms.TextBox ParameterX0Text;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ErrorProvider errorProviderIntervalT;
        private System.Windows.Forms.ErrorProvider errorProviderNumberOfElements;
        private System.Windows.Forms.ErrorProvider errorProviderNumberOfPoints;
        private System.Windows.Forms.ErrorProvider errorProviderParameterX0;
    }
}

