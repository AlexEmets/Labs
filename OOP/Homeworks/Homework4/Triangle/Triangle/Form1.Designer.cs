
namespace Triangle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateTriangle = new System.Windows.Forms.Button();
            this.aField = new System.Windows.Forms.TextBox();
            this.bField = new System.Windows.Forms.TextBox();
            this.cField = new System.Windows.Forms.TextBox();
            this.TriangleInfo = new System.Windows.Forms.Label();
            this.aInfo = new System.Windows.Forms.Label();
            this.bInfo = new System.Windows.Forms.Label();
            this.cInfo = new System.Windows.Forms.Label();
            this.sideToChange = new System.Windows.Forms.TextBox();
            this.valueToChange = new System.Windows.Forms.TextBox();
            this.ChangeInfo = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.sideInfo = new System.Windows.Forms.Label();
            this.valueInfo = new System.Windows.Forms.Label();
            this.EquilTriangleInfo = new System.Windows.Forms.Label();
            this.EquilSide = new System.Windows.Forms.TextBox();
            this.CreateEquil = new System.Windows.Forms.Button();
            this.equilSideInfo = new System.Windows.Forms.Label();
            this.Perimeter = new System.Windows.Forms.Button();
            this.Angle = new System.Windows.Forms.Button();
            this.AngleName = new System.Windows.Forms.TextBox();
            this.angleNameInfo = new System.Windows.Forms.Label();
            this.PerimeterResult = new System.Windows.Forms.Label();
            this.ResultAngle = new System.Windows.Forms.Label();
            this.CalculateSquare = new System.Windows.Forms.Button();
            this.ResultSquare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateTriangle
            // 
            this.CreateTriangle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateTriangle.Location = new System.Drawing.Point(81, 116);
            this.CreateTriangle.Name = "CreateTriangle";
            this.CreateTriangle.Size = new System.Drawing.Size(75, 23);
            this.CreateTriangle.TabIndex = 0;
            this.CreateTriangle.Text = "Create ";
            this.CreateTriangle.UseVisualStyleBackColor = true;
            this.CreateTriangle.Click += new System.EventHandler(this.CreateTriangle_Click);
            // 
            // aField
            // 
            this.aField.Location = new System.Drawing.Point(70, 35);
            this.aField.Name = "aField";
            this.aField.Size = new System.Drawing.Size(100, 23);
            this.aField.TabIndex = 1;
            this.aField.TextChanged += new System.EventHandler(this.aField_TextChanged);
            // 
            // bField
            // 
            this.bField.Location = new System.Drawing.Point(70, 64);
            this.bField.Name = "bField";
            this.bField.Size = new System.Drawing.Size(100, 23);
            this.bField.TabIndex = 2;
            this.bField.TextChanged += new System.EventHandler(this.bField_TextChanged);
            // 
            // cField
            // 
            this.cField.Location = new System.Drawing.Point(70, 93);
            this.cField.Name = "cField";
            this.cField.Size = new System.Drawing.Size(100, 23);
            this.cField.TabIndex = 3;
            this.cField.TextChanged += new System.EventHandler(this.cField_TextChanged);
            // 
            // TriangleInfo
            // 
            this.TriangleInfo.AutoSize = true;
            this.TriangleInfo.Location = new System.Drawing.Point(70, 17);
            this.TriangleInfo.Name = "TriangleInfo";
            this.TriangleInfo.Size = new System.Drawing.Size(87, 15);
            this.TriangleInfo.TabIndex = 4;
            this.TriangleInfo.Text = "Create Triangle";
            this.TriangleInfo.Click += new System.EventHandler(this.TriangleInfo_Click);
            // 
            // aInfo
            // 
            this.aInfo.AutoSize = true;
            this.aInfo.Location = new System.Drawing.Point(27, 38);
            this.aInfo.Name = "aInfo";
            this.aInfo.Size = new System.Drawing.Size(38, 15);
            this.aInfo.TabIndex = 5;
            this.aInfo.Text = "Side a";
            this.aInfo.Click += new System.EventHandler(this.aInfo_Click);
            // 
            // bInfo
            // 
            this.bInfo.AutoSize = true;
            this.bInfo.Location = new System.Drawing.Point(26, 67);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(39, 15);
            this.bInfo.TabIndex = 6;
            this.bInfo.Text = "Side b";
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // cInfo
            // 
            this.cInfo.AutoSize = true;
            this.cInfo.Location = new System.Drawing.Point(26, 96);
            this.cInfo.Name = "cInfo";
            this.cInfo.Size = new System.Drawing.Size(38, 15);
            this.cInfo.TabIndex = 7;
            this.cInfo.Text = "Side c";
            this.cInfo.Click += new System.EventHandler(this.cInfo_Click);
            // 
            // sideToChange
            // 
            this.sideToChange.Location = new System.Drawing.Point(367, 63);
            this.sideToChange.Name = "sideToChange";
            this.sideToChange.Size = new System.Drawing.Size(100, 23);
            this.sideToChange.TabIndex = 8;
            this.sideToChange.TextChanged += new System.EventHandler(this.sideToChange_TextChanged);
            // 
            // valueToChange
            // 
            this.valueToChange.Location = new System.Drawing.Point(367, 92);
            this.valueToChange.Name = "valueToChange";
            this.valueToChange.Size = new System.Drawing.Size(100, 23);
            this.valueToChange.TabIndex = 9;
            this.valueToChange.TextChanged += new System.EventHandler(this.valueToChange_TextChanged);
            // 
            // ChangeInfo
            // 
            this.ChangeInfo.AutoSize = true;
            this.ChangeInfo.Location = new System.Drawing.Point(380, 45);
            this.ChangeInfo.Name = "ChangeInfo";
            this.ChangeInfo.Size = new System.Drawing.Size(72, 15);
            this.ChangeInfo.TabIndex = 10;
            this.ChangeInfo.Text = "Change side";
            this.ChangeInfo.Click += new System.EventHandler(this.ChangeInfo_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChangeButton.Location = new System.Drawing.Point(380, 116);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 11;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // sideInfo
            // 
            this.sideInfo.AutoSize = true;
            this.sideInfo.Location = new System.Drawing.Point(299, 66);
            this.sideInfo.Name = "sideInfo";
            this.sideInfo.Size = new System.Drawing.Size(62, 15);
            this.sideInfo.TabIndex = 12;
            this.sideInfo.Text = "Side name";
            this.sideInfo.Click += new System.EventHandler(this.sideInfo_Click);
            // 
            // valueInfo
            // 
            this.valueInfo.AutoSize = true;
            this.valueInfo.Location = new System.Drawing.Point(299, 95);
            this.valueInfo.Name = "valueInfo";
            this.valueInfo.Size = new System.Drawing.Size(62, 15);
            this.valueInfo.TabIndex = 13;
            this.valueInfo.Text = "New value";
            this.valueInfo.Click += new System.EventHandler(this.valueInfo_Click);
            // 
            // EquilTriangleInfo
            // 
            this.EquilTriangleInfo.AutoSize = true;
            this.EquilTriangleInfo.Location = new System.Drawing.Point(633, 74);
            this.EquilTriangleInfo.Name = "EquilTriangleInfo";
            this.EquilTriangleInfo.Size = new System.Drawing.Size(116, 15);
            this.EquilTriangleInfo.TabIndex = 14;
            this.EquilTriangleInfo.Text = "Create Equil Triangle";
            this.EquilTriangleInfo.Click += new System.EventHandler(this.EquilTriangleInfo_Click);
            // 
            // EquilSide
            // 
            this.EquilSide.Location = new System.Drawing.Point(633, 92);
            this.EquilSide.Name = "EquilSide";
            this.EquilSide.Size = new System.Drawing.Size(100, 23);
            this.EquilSide.TabIndex = 15;
            this.EquilSide.TextChanged += new System.EventHandler(this.EquilSide_TextChanged);
            // 
            // CreateEquil
            // 
            this.CreateEquil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateEquil.Location = new System.Drawing.Point(647, 116);
            this.CreateEquil.Name = "CreateEquil";
            this.CreateEquil.Size = new System.Drawing.Size(75, 23);
            this.CreateEquil.TabIndex = 16;
            this.CreateEquil.Text = "Create";
            this.CreateEquil.UseVisualStyleBackColor = true;
            this.CreateEquil.Click += new System.EventHandler(this.CreateEquil_Click);
            // 
            // equilSideInfo
            // 
            this.equilSideInfo.AutoSize = true;
            this.equilSideInfo.Location = new System.Drawing.Point(598, 95);
            this.equilSideInfo.Name = "equilSideInfo";
            this.equilSideInfo.Size = new System.Drawing.Size(29, 15);
            this.equilSideInfo.TabIndex = 17;
            this.equilSideInfo.Text = "Side";
            this.equilSideInfo.Click += new System.EventHandler(this.equilSideInfo_Click);
            // 
            // Perimeter
            // 
            this.Perimeter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Perimeter.Location = new System.Drawing.Point(473, 182);
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.Size = new System.Drawing.Size(75, 38);
            this.Perimeter.TabIndex = 18;
            this.Perimeter.Text = "Calculate Perimeter";
            this.Perimeter.UseVisualStyleBackColor = true;
            this.Perimeter.Click += new System.EventHandler(this.Perimeter_Click);
            // 
            // Angle
            // 
            this.Angle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Angle.Location = new System.Drawing.Point(473, 235);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(75, 38);
            this.Angle.TabIndex = 19;
            this.Angle.Text = "Calculate Angle";
            this.Angle.UseVisualStyleBackColor = true;
            this.Angle.Click += new System.EventHandler(this.Angle_Click);
            // 
            // AngleName
            // 
            this.AngleName.Location = new System.Drawing.Point(367, 244);
            this.AngleName.Name = "AngleName";
            this.AngleName.Size = new System.Drawing.Size(100, 23);
            this.AngleName.TabIndex = 20;
            this.AngleName.TextChanged += new System.EventHandler(this.AngleName_TextChanged);
            // 
            // angleNameInfo
            // 
            this.angleNameInfo.AutoSize = true;
            this.angleNameInfo.Location = new System.Drawing.Point(290, 247);
            this.angleNameInfo.Name = "angleNameInfo";
            this.angleNameInfo.Size = new System.Drawing.Size(71, 15);
            this.angleNameInfo.TabIndex = 21;
            this.angleNameInfo.Text = "Angle name";
            this.angleNameInfo.Click += new System.EventHandler(this.angleNameInfo_Click);
            // 
            // PerimeterResult
            // 
            this.PerimeterResult.AutoSize = true;
            this.PerimeterResult.ForeColor = System.Drawing.SystemColors.Control;
            this.PerimeterResult.Location = new System.Drawing.Point(555, 192);
            this.PerimeterResult.Name = "PerimeterResult";
            this.PerimeterResult.Size = new System.Drawing.Size(39, 15);
            this.PerimeterResult.TabIndex = 22;
            this.PerimeterResult.Text = "Result";
            this.PerimeterResult.Click += new System.EventHandler(this.PerimeterResult_Click);
            // 
            // ResultAngle
            // 
            this.ResultAngle.AutoSize = true;
            this.ResultAngle.Location = new System.Drawing.Point(555, 247);
            this.ResultAngle.Name = "ResultAngle";
            this.ResultAngle.Size = new System.Drawing.Size(39, 15);
            this.ResultAngle.TabIndex = 23;
            this.ResultAngle.Text = "Result";
            this.ResultAngle.Click += new System.EventHandler(this.ResultAngle_Click);
            // 
            // CalculateSquare
            // 
            this.CalculateSquare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateSquare.Location = new System.Drawing.Point(473, 289);
            this.CalculateSquare.Name = "CalculateSquare";
            this.CalculateSquare.Size = new System.Drawing.Size(75, 38);
            this.CalculateSquare.TabIndex = 24;
            this.CalculateSquare.Text = "Calculate Square";
            this.CalculateSquare.UseVisualStyleBackColor = true;
            this.CalculateSquare.Click += new System.EventHandler(this.CalculateSquare_Click);
            // 
            // ResultSquare
            // 
            this.ResultSquare.AutoSize = true;
            this.ResultSquare.Location = new System.Drawing.Point(555, 301);
            this.ResultSquare.Name = "ResultSquare";
            this.ResultSquare.Size = new System.Drawing.Size(39, 15);
            this.ResultSquare.TabIndex = 25;
            this.ResultSquare.Text = "Result";
            this.ResultSquare.Click += new System.EventHandler(this.ResultSquare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultSquare);
            this.Controls.Add(this.CalculateSquare);
            this.Controls.Add(this.ResultAngle);
            this.Controls.Add(this.PerimeterResult);
            this.Controls.Add(this.angleNameInfo);
            this.Controls.Add(this.AngleName);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.Perimeter);
            this.Controls.Add(this.equilSideInfo);
            this.Controls.Add(this.CreateEquil);
            this.Controls.Add(this.EquilSide);
            this.Controls.Add(this.EquilTriangleInfo);
            this.Controls.Add(this.valueInfo);
            this.Controls.Add(this.sideInfo);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ChangeInfo);
            this.Controls.Add(this.valueToChange);
            this.Controls.Add(this.sideToChange);
            this.Controls.Add(this.cInfo);
            this.Controls.Add(this.bInfo);
            this.Controls.Add(this.aInfo);
            this.Controls.Add(this.TriangleInfo);
            this.Controls.Add(this.cField);
            this.Controls.Add(this.bField);
            this.Controls.Add(this.aField);
            this.Controls.Add(this.CreateTriangle);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTriangle;
        private System.Windows.Forms.TextBox aField;
        private System.Windows.Forms.TextBox bField;
        private System.Windows.Forms.TextBox cField;
        private System.Windows.Forms.Label TriangleInfo;
        private System.Windows.Forms.Label aInfo;
        private System.Windows.Forms.Label bInfo;
        private System.Windows.Forms.Label cInfo;
        private System.Windows.Forms.TextBox sideToChange;
        private System.Windows.Forms.TextBox valueToChange;
        private System.Windows.Forms.Label ChangeInfo;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label sideInfo;
        private System.Windows.Forms.Label valueInfo;
        private System.Windows.Forms.Label EquilTriangleInfo;
        private System.Windows.Forms.TextBox EquilSide;
        private System.Windows.Forms.Button CreateEquil;
        private System.Windows.Forms.Label equilSideInfo;
        private System.Windows.Forms.Button Perimeter;
        private System.Windows.Forms.Button Angle;
        private System.Windows.Forms.TextBox AngleName;
        private System.Windows.Forms.Label angleNameInfo;
        private System.Windows.Forms.Label PerimeterResult;
        private System.Windows.Forms.Label ResultAngle;
        private System.Windows.Forms.Button CalculateSquare;
        private System.Windows.Forms.Label ResultSquare;
    }
}

