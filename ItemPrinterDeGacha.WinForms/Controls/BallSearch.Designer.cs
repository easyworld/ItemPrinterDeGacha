namespace ItemPrinterDeGacha.WinForms.Controls
{
    partial class BallSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tickToggle1 = new TickToggle();
            L_Seconds = new Label();
            NUD_Seconds = new NumericUpDown();
            CB_Seek = new ComboBox();
            B_Search = new Button();
            L_Seek = new Label();
            L_Item = new Label();
            CB_Item = new ComboBox();
            L_Max = new Label();
            L_Min = new Label();
            NUD_Max = new NumericUpDown();
            NUD_Min = new NumericUpDown();
            L_Jobs = new Label();
            CB_Count = new ComboBox();
            DGV_View = new ItemResultGridView();
            RTB_Result = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)NUD_Seconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Min).BeginInit();
            SuspendLayout();
            // 
            // tickToggle1
            // 
            tickToggle1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tickToggle1.Location = new Point(4, 0);
            tickToggle1.Name = "tickToggle1";
            tickToggle1.Size = new Size(112, 82);
            tickToggle1.TabIndex = 1;
            // 
            // L_Seconds
            // 
            L_Seconds.Location = new Point(410, 55);
            L_Seconds.Name = "L_Seconds";
            L_Seconds.Size = new Size(136, 24);
            L_Seconds.TabIndex = 18;
            L_Seconds.Text = "Seconds:";
            L_Seconds.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NUD_Seconds
            // 
            NUD_Seconds.Location = new Point(552, 57);
            NUD_Seconds.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NUD_Seconds.Name = "NUD_Seconds";
            NUD_Seconds.Size = new Size(80, 23);
            NUD_Seconds.TabIndex = 5;
            NUD_Seconds.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // CB_Seek
            // 
            CB_Seek.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Seek.FormattingEnabled = true;
            CB_Seek.Items.AddRange(new object[] { "单道具最大", "最多特殊奖励" });
            CB_Seek.Location = new Point(194, 6);
            CB_Seek.Name = "CB_Seek";
            CB_Seek.Size = new Size(100, 23);
            CB_Seek.TabIndex = 1;
            CB_Seek.SelectedIndexChanged += CB_Seek_SelectedIndexChanged;
            // 
            // B_Search
            // 
            B_Search.Location = new Point(500, 6);
            B_Search.Name = "B_Search";
            B_Search.Size = new Size(132, 48);
            B_Search.TabIndex = 0;
            B_Search.Text = "Search";
            B_Search.UseVisualStyleBackColor = false;
            B_Search.Click += B_Search_Click;
            // 
            // L_Seek
            // 
            L_Seek.Location = new Point(121, 4);
            L_Seek.Name = "L_Seek";
            L_Seek.Size = new Size(71, 24);
            L_Seek.TabIndex = 20;
            L_Seek.Text = "Seek:";
            L_Seek.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_Item
            // 
            L_Item.Location = new Point(121, 29);
            L_Item.Name = "L_Item";
            L_Item.Size = new Size(71, 24);
            L_Item.TabIndex = 24;
            L_Item.Text = "Item:";
            L_Item.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CB_Item
            // 
            CB_Item.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CB_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
            CB_Item.FormattingEnabled = true;
            CB_Item.Location = new Point(194, 31);
            CB_Item.Name = "CB_Item";
            CB_Item.Size = new Size(100, 23);
            CB_Item.TabIndex = 2;
            // 
            // L_Max
            // 
            L_Max.Location = new Point(308, 29);
            L_Max.Name = "L_Max";
            L_Max.Size = new Size(96, 24);
            L_Max.TabIndex = 32;
            L_Max.Text = "Max Seconds:";
            L_Max.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_Min
            // 
            L_Min.Location = new Point(308, 4);
            L_Min.Name = "L_Min";
            L_Min.Size = new Size(96, 24);
            L_Min.TabIndex = 31;
            L_Min.Text = "Min Seconds:";
            L_Min.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NUD_Max
            // 
            NUD_Max.Location = new Point(410, 31);
            NUD_Max.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            NUD_Max.Name = "NUD_Max";
            NUD_Max.Size = new Size(44, 23);
            NUD_Max.TabIndex = 4;
            NUD_Max.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // NUD_Min
            // 
            NUD_Min.Location = new Point(410, 6);
            NUD_Min.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            NUD_Min.Name = "NUD_Min";
            NUD_Min.Size = new Size(44, 23);
            NUD_Min.TabIndex = 3;
            NUD_Min.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // L_Jobs
            // 
            L_Jobs.Location = new Point(121, 55);
            L_Jobs.Name = "L_Jobs";
            L_Jobs.Size = new Size(71, 24);
            L_Jobs.TabIndex = 34;
            L_Jobs.Text = "Jobs:";
            L_Jobs.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CB_Count
            // 
            CB_Count.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Count.FormattingEnabled = true;
            CB_Count.Items.AddRange(new object[] { "1", "5", "10" });
            CB_Count.Location = new Point(194, 56);
            CB_Count.Name = "CB_Count";
            CB_Count.Size = new Size(39, 23);
            CB_Count.TabIndex = 35;
            // 
            // DGV_View
            // 
            DGV_View.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DGV_View.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DGV_View.Location = new Point(4, 86);
            DGV_View.Name = "DGV_View";
            DGV_View.Size = new Size(235, 160);
            DGV_View.TabIndex = 42;
            // 
            // RTB_Result
            // 
            RTB_Result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RTB_Result.Location = new Point(240, 86);
            RTB_Result.Name = "RTB_Result";
            RTB_Result.ReadOnly = true;
            RTB_Result.Size = new Size(400, 161);
            RTB_Result.TabIndex = 41;
            RTB_Result.Text = "";
            // 
            // BallSearch
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(DGV_View);
            Controls.Add(RTB_Result);
            Controls.Add(CB_Count);
            Controls.Add(L_Jobs);
            Controls.Add(L_Max);
            Controls.Add(L_Min);
            Controls.Add(NUD_Max);
            Controls.Add(NUD_Min);
            Controls.Add(L_Item);
            Controls.Add(CB_Item);
            Controls.Add(L_Seek);
            Controls.Add(tickToggle1);
            Controls.Add(L_Seconds);
            Controls.Add(NUD_Seconds);
            Controls.Add(CB_Seek);
            Controls.Add(B_Search);
            Margin = new Padding(0);
            Name = "BallSearch";
            Size = new Size(640, 250);
            ((System.ComponentModel.ISupportInitialize)NUD_Seconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Max).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Min).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TickToggle tickToggle1;
        private Label L_Seconds;
        private NumericUpDown NUD_Seconds;
        private ComboBox CB_Seek;
        private Button B_Search;
        private Label L_Seek;
        private Label L_Item;
        private ComboBox CB_Item;
        private Label L_Max;
        private Label L_Min;
        private NumericUpDown NUD_Max;
        private NumericUpDown NUD_Min;
        private Label L_Jobs;
        private ComboBox CB_Count;
        private ItemResultGridView DGV_View;
        private RichTextBox RTB_Result;
    }
}
