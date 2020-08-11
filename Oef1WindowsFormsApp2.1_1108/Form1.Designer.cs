namespace Oef1WindowsFormsApp2._1_1108
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
            this.tbToevoegen = new System.Windows.Forms.TextBox();
            this.lbAfwezig = new System.Windows.Forms.ListBox();
            this.lbAanwezig = new System.Windows.Forms.ListBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnAanwezig = new System.Windows.Forms.Button();
            this.btnAfwezig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbToevoegen
            // 
            this.tbToevoegen.Location = new System.Drawing.Point(35, 13);
            this.tbToevoegen.Name = "tbToevoegen";
            this.tbToevoegen.Size = new System.Drawing.Size(149, 20);
            this.tbToevoegen.TabIndex = 0;
            // 
            // lbAfwezig
            // 
            this.lbAfwezig.FormattingEnabled = true;
            this.lbAfwezig.Location = new System.Drawing.Point(35, 58);
            this.lbAfwezig.Name = "lbAfwezig";
            this.lbAfwezig.Size = new System.Drawing.Size(149, 173);
            this.lbAfwezig.TabIndex = 1;
            // 
            // lbAanwezig
            // 
            this.lbAanwezig.FormattingEnabled = true;
            this.lbAanwezig.Location = new System.Drawing.Point(345, 58);
            this.lbAanwezig.Name = "lbAanwezig";
            this.lbAanwezig.Size = new System.Drawing.Size(149, 173);
            this.lbAanwezig.TabIndex = 2;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(202, 8);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(126, 28);
            this.btnToevoegen.TabIndex = 3;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnAanwezig
            // 
            this.btnAanwezig.Location = new System.Drawing.Point(202, 99);
            this.btnAanwezig.Name = "btnAanwezig";
            this.btnAanwezig.Size = new System.Drawing.Size(126, 28);
            this.btnAanwezig.TabIndex = 4;
            this.btnAanwezig.Text = "==>";
            this.btnAanwezig.UseVisualStyleBackColor = true;
            this.btnAanwezig.Click += new System.EventHandler(this.btnAanwezig_Click);
            // 
            // btnAfwezig
            // 
            this.btnAfwezig.Location = new System.Drawing.Point(202, 156);
            this.btnAfwezig.Name = "btnAfwezig";
            this.btnAfwezig.Size = new System.Drawing.Size(126, 28);
            this.btnAfwezig.TabIndex = 5;
            this.btnAfwezig.Text = "<==";
            this.btnAfwezig.UseVisualStyleBackColor = true;
            this.btnAfwezig.Click += new System.EventHandler(this.btnAfwezig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 263);
            this.Controls.Add(this.btnAfwezig);
            this.Controls.Add(this.btnAanwezig);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lbAanwezig);
            this.Controls.Add(this.lbAfwezig);
            this.Controls.Add(this.tbToevoegen);
            this.Name = "Form1";
            this.Text = "Aanwezigheidsformulier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbToevoegen;
        private System.Windows.Forms.ListBox lbAfwezig;
        private System.Windows.Forms.ListBox lbAanwezig;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnAanwezig;
        private System.Windows.Forms.Button btnAfwezig;
    }
}

