namespace WindowsFormsApplication1
{
    partial class frm_funcao_quadratica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_funcao_quadratica));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.lbl_x2 = new System.Windows.Forms.Label();
            this.tb_x2 = new System.Windows.Forms.TextBox();
            this.lbl_x1 = new System.Windows.Forms.Label();
            this.tb_x1 = new System.Windows.Forms.TextBox();
            this.lbl_delta = new System.Windows.Forms.Label();
            this.tb_delta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.chart_raizes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.pnl_toolbar = new System.Windows.Forms.Panel();
            this.pnl_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_raizes)).BeginInit();
            this.pnl_toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            resources.ApplyResources(this.btn_calcular, "btn_calcular");
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_title
            // 
            resources.ApplyResources(this.lbl_title, "lbl_title");
            this.lbl_title.Name = "lbl_title";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pnl_form
            // 
            this.pnl_form.Controls.Add(this.lbl_x2);
            this.pnl_form.Controls.Add(this.tb_x2);
            this.pnl_form.Controls.Add(this.lbl_x1);
            this.pnl_form.Controls.Add(this.tb_x1);
            this.pnl_form.Controls.Add(this.lbl_delta);
            this.pnl_form.Controls.Add(this.tb_delta);
            this.pnl_form.Controls.Add(this.label2);
            this.pnl_form.Controls.Add(this.label1);
            this.pnl_form.Controls.Add(this.lbl_c);
            this.pnl_form.Controls.Add(this.tb_c);
            this.pnl_form.Controls.Add(this.lbl_b);
            this.pnl_form.Controls.Add(this.tb_b);
            this.pnl_form.Controls.Add(this.lbl_a);
            this.pnl_form.Controls.Add(this.tb_a);
            this.pnl_form.Controls.Add(this.lbl_title);
            resources.ApplyResources(this.pnl_form, "pnl_form");
            this.pnl_form.Name = "pnl_form";
            // 
            // lbl_x2
            // 
            resources.ApplyResources(this.lbl_x2, "lbl_x2");
            this.lbl_x2.Name = "lbl_x2";
            // 
            // tb_x2
            // 
            resources.ApplyResources(this.tb_x2, "tb_x2");
            this.tb_x2.Name = "tb_x2";
            this.tb_x2.ReadOnly = true;
            this.tb_x2.TabStop = false;
            // 
            // lbl_x1
            // 
            resources.ApplyResources(this.lbl_x1, "lbl_x1");
            this.lbl_x1.Name = "lbl_x1";
            // 
            // tb_x1
            // 
            resources.ApplyResources(this.tb_x1, "tb_x1");
            this.tb_x1.Name = "tb_x1";
            this.tb_x1.ReadOnly = true;
            this.tb_x1.TabStop = false;
            // 
            // lbl_delta
            // 
            resources.ApplyResources(this.lbl_delta, "lbl_delta");
            this.lbl_delta.Name = "lbl_delta";
            // 
            // tb_delta
            // 
            resources.ApplyResources(this.tb_delta, "tb_delta");
            this.tb_delta.Name = "tb_delta";
            this.tb_delta.ReadOnly = true;
            this.tb_delta.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_c
            // 
            resources.ApplyResources(this.lbl_c, "lbl_c");
            this.lbl_c.Name = "lbl_c";
            // 
            // tb_c
            // 
            resources.ApplyResources(this.tb_c, "tb_c");
            this.tb_c.Name = "tb_c";
            // 
            // lbl_b
            // 
            resources.ApplyResources(this.lbl_b, "lbl_b");
            this.lbl_b.Name = "lbl_b";
            // 
            // tb_b
            // 
            resources.ApplyResources(this.tb_b, "tb_b");
            this.tb_b.Name = "tb_b";
            // 
            // lbl_a
            // 
            resources.ApplyResources(this.lbl_a, "lbl_a");
            this.lbl_a.Name = "lbl_a";
            // 
            // tb_a
            // 
            resources.ApplyResources(this.tb_a, "tb_a");
            this.tb_a.Name = "tb_a";
            // 
            // chart_raizes
            // 
            chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea4.Name = "ChartArea1";
            this.chart_raizes.ChartAreas.Add(chartArea4);
            resources.ApplyResources(this.chart_raizes, "chart_raizes");
            legend4.Name = "Legend1";
            this.chart_raizes.Legends.Add(legend4);
            this.chart_raizes.Name = "chart_raizes";
            title4.Name = "Raízes";
            this.chart_raizes.Titles.Add(title4);
            // 
            // btn_limpar
            // 
            resources.ApplyResources(this.btn_limpar, "btn_limpar");
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // pnl_toolbar
            // 
            this.pnl_toolbar.Controls.Add(this.btn_limpar);
            this.pnl_toolbar.Controls.Add(this.btn_calcular);
            resources.ApplyResources(this.pnl_toolbar, "pnl_toolbar");
            this.pnl_toolbar.Name = "pnl_toolbar";
            // 
            // frm_funcao_quadratica
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.chart_raizes);
            this.Controls.Add(this.pnl_toolbar);
            this.Name = "frm_funcao_quadratica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_raizes)).EndInit();
            this.pnl_toolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_x2;
        private System.Windows.Forms.TextBox tb_x2;
        private System.Windows.Forms.Label lbl_x1;
        private System.Windows.Forms.TextBox tb_x1;
        private System.Windows.Forms.Label lbl_delta;
        private System.Windows.Forms.TextBox tb_delta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_raizes;
        private System.Windows.Forms.Panel pnl_toolbar;
    }
}

