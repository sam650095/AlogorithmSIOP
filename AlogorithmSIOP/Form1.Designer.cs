using System.Data;
using System.Runtime.InteropServices;
using ScottPlot.WinForms;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace AlogorithmSIOP
{
    public partial class Form1
    {
        // 建立新的視窗
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        private System.ComponentModel.IContainer components = null;
        //結束時釋放空間
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            chartBox = new GroupBox();
            formsPlot2 = new FormsPlot();
            formsPlot1 = new FormsPlot();
            dataGridView1 = new DataGridView();
            confirmbtn = new Button();
            Acombo = new ComboBox();
            dinput = new TextBox();
            Title = new Label();
            AText = new Label();
            AText2 = new Label();
            DText = new Label();
            DText2 = new Label();
            PSettings = new GroupBox();
            RNeighbor2Input = new TextBox();
            dash = new Label();
            label5 = new Label();
            LeaveTInput = new TextBox();
            label4 = new Label();
            DropTCoeffientInput = new TextBox();
            label3 = new Label();
            RNeighbor1Input = new TextBox();
            label2 = new Label();
            InitTInput = new TextBox();
            label1 = new Label();
            OnceInteractionInput = new TextBox();
            PSettings3 = new GroupBox();
            mutationRInput = new TextBox();
            crossoverRInput = new TextBox();
            chromasomeInput = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            PSettings2 = new GroupBox();
            label6 = new Label();
            C2Input = new TextBox();
            label7 = new Label();
            C1Input = new TextBox();
            label9 = new Label();
            WInput = new TextBox();
            label10 = new Label();
            InteractionInput = new TextBox();
            label11 = new Label();
            ParticleInput = new TextBox();
            resultBox = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            fileSystemWatcher1 = new FileSystemWatcher();
            chartBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            PSettings.SuspendLayout();
            PSettings3.SuspendLayout();
            PSettings2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // chartBox
            // 
            chartBox.Controls.Add(formsPlot2);
            chartBox.Controls.Add(formsPlot1);
            chartBox.Controls.Add(dataGridView1);
            chartBox.Location = new Point(24, 274);
            chartBox.Name = "chartBox";
            chartBox.Size = new Size(663, 379);
            chartBox.TabIndex = 14;
            chartBox.TabStop = false;
            chartBox.Text = "chartBox";
            chartBox.Visible = false;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(381, 22);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(276, 196);
            formsPlot2.TabIndex = 30;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(6, 15);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(387, 362);
            formsPlot1.TabIndex = 29;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(399, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(258, 149);
            dataGridView1.TabIndex = 28;
            // 
            // confirmbtn
            // 
            confirmbtn.Location = new Point(836, 239);
            confirmbtn.Name = "confirmbtn";
            confirmbtn.Size = new Size(75, 23);
            confirmbtn.TabIndex = 0;
            confirmbtn.Text = "確定";
            confirmbtn.UseVisualStyleBackColor = true;
            confirmbtn.Click += confirmbtnclicked;
            // 
            // Acombo
            // 
            Acombo.FormattingEnabled = true;
            Acombo.Items.AddRange(new object[] { "SA", "PSO", "GA" });
            Acombo.Location = new Point(103, 90);
            Acombo.Name = "Acombo";
            Acombo.Size = new Size(121, 23);
            Acombo.TabIndex = 1;
            Acombo.SelectedIndexChanged += Acombo_changed;
            // 
            // dinput
            // 
            dinput.Location = new Point(200, 119);
            dinput.Name = "dinput";
            dinput.Size = new Size(24, 23);
            dinput.TabIndex = 2;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("新細明體", 24F);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(374, 32);
            Title.TabIndex = 3;
            Title.Text = "Optimize Schwefel's Function";
            // 
            // AText
            // 
            AText.AutoSize = true;
            AText.Location = new Point(58, 93);
            AText.Name = "AText";
            AText.Size = new Size(39, 15);
            AText.TabIndex = 4;
            AText.Text = "Using";
            // 
            // AText2
            // 
            AText2.AutoSize = true;
            AText2.Location = new Point(230, 94);
            AText2.Name = "AText2";
            AText2.Size = new Size(71, 15);
            AText2.TabIndex = 6;
            AText2.Text = "Alogorithm";
            // 
            // DText
            // 
            DText.AutoSize = true;
            DText.Location = new Point(152, 122);
            DText.Name = "DText";
            DText.Size = new Size(17, 15);
            DText.TabIndex = 5;
            DText.Text = "In";
            // 
            // DText2
            // 
            DText2.AutoSize = true;
            DText2.Location = new Point(230, 122);
            DText2.Name = "DText2";
            DText2.Size = new Size(72, 15);
            DText2.TabIndex = 7;
            DText2.Text = "Dimensions";
            // 
            // PSettings
            // 
            PSettings.Controls.Add(RNeighbor2Input);
            PSettings.Controls.Add(dash);
            PSettings.Controls.Add(label5);
            PSettings.Controls.Add(LeaveTInput);
            PSettings.Controls.Add(label4);
            PSettings.Controls.Add(DropTCoeffientInput);
            PSettings.Controls.Add(label3);
            PSettings.Controls.Add(RNeighbor1Input);
            PSettings.Controls.Add(label2);
            PSettings.Controls.Add(InitTInput);
            PSettings.Controls.Add(label1);
            PSettings.Controls.Add(OnceInteractionInput);
            PSettings.Location = new Point(618, 17);
            PSettings.Name = "PSettings";
            PSettings.Size = new Size(293, 204);
            PSettings.TabIndex = 13;
            PSettings.TabStop = false;
            PSettings.Text = "Parameters Setting";
            PSettings.Visible = false;
            // 
            // RNeighbor2Input
            // 
            RNeighbor2Input.Location = new Point(236, 84);
            RNeighbor2Input.Name = "RNeighbor2Input";
            RNeighbor2Input.Size = new Size(22, 23);
            RNeighbor2Input.TabIndex = 25;
            // 
            // dash
            // 
            dash.AutoSize = true;
            dash.Location = new Point(214, 88);
            dash.Name = "dash";
            dash.Size = new Size(16, 15);
            dash.TabIndex = 24;
            dash.Text = "~";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 148);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 22;
            label5.Text = "Leave Temperature";
            // 
            // LeaveTInput
            // 
            LeaveTInput.Location = new Point(189, 145);
            LeaveTInput.Name = "LeaveTInput";
            LeaveTInput.Size = new Size(69, 23);
            LeaveTInput.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 120);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 18;
            label4.Text = "Drop Temperature Coeffient";
            // 
            // DropTCoeffientInput
            // 
            DropTCoeffientInput.Location = new Point(189, 117);
            DropTCoeffientInput.Name = "DropTCoeffientInput";
            DropTCoeffientInput.Size = new Size(69, 23);
            DropTCoeffientInput.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 91);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 20;
            label3.Text = "Random Neighbor";
            // 
            // RNeighbor1Input
            // 
            RNeighbor1Input.Location = new Point(189, 84);
            RNeighbor1Input.Name = "RNeighbor1Input";
            RNeighbor1Input.Size = new Size(20, 23);
            RNeighbor1Input.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 62);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 16;
            label2.Text = "Initial Temperature";
            // 
            // InitTInput
            // 
            InitTInput.Location = new Point(189, 58);
            InitTInput.Name = "InitTInput";
            InitTInput.Size = new Size(69, 23);
            InitTInput.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 14;
            label1.Text = "Once Interaction";
            // 
            // OnceInteractionInput
            // 
            OnceInteractionInput.Location = new Point(189, 29);
            OnceInteractionInput.Name = "OnceInteractionInput";
            OnceInteractionInput.Size = new Size(69, 23);
            OnceInteractionInput.TabIndex = 8;
            // 
            // PSettings3
            // 
            PSettings3.Controls.Add(mutationRInput);
            PSettings3.Controls.Add(crossoverRInput);
            PSettings3.Controls.Add(chromasomeInput);
            PSettings3.Controls.Add(label13);
            PSettings3.Controls.Add(label12);
            PSettings3.Controls.Add(label8);
            PSettings3.Location = new Point(395, 17);
            PSettings3.Name = "PSettings3";
            PSettings3.Size = new Size(208, 136);
            PSettings3.TabIndex = 27;
            PSettings3.TabStop = false;
            PSettings3.Text = "Parameters Setting";
            PSettings3.Visible = false;
            // 
            // mutationRInput
            // 
            mutationRInput.Location = new Point(117, 85);
            mutationRInput.Name = "mutationRInput";
            mutationRInput.Size = new Size(65, 23);
            mutationRInput.TabIndex = 5;
            // 
            // crossoverRInput
            // 
            crossoverRInput.Location = new Point(117, 56);
            crossoverRInput.Name = "crossoverRInput";
            crossoverRInput.Size = new Size(65, 23);
            crossoverRInput.TabIndex = 4;
            // 
            // chromasomeInput
            // 
            chromasomeInput.Location = new Point(117, 30);
            chromasomeInput.Name = "chromasomeInput";
            chromasomeInput.Size = new Size(65, 23);
            chromasomeInput.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 90);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 2;
            label13.Text = "Mutation Rate";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 61);
            label12.Name = "label12";
            label12.Size = new Size(91, 15);
            label12.TabIndex = 1;
            label12.Text = "Crossover Rate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 33);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 0;
            label8.Text = "Chromosome #";
            // 
            // PSettings2
            // 
            PSettings2.Controls.Add(label6);
            PSettings2.Controls.Add(C2Input);
            PSettings2.Controls.Add(label7);
            PSettings2.Controls.Add(C1Input);
            PSettings2.Controls.Add(label9);
            PSettings2.Controls.Add(WInput);
            PSettings2.Controls.Add(label10);
            PSettings2.Controls.Add(InteractionInput);
            PSettings2.Controls.Add(label11);
            PSettings2.Controls.Add(ParticleInput);
            PSettings2.Location = new Point(312, 156);
            PSettings2.Name = "PSettings2";
            PSettings2.Size = new Size(254, 127);
            PSettings2.TabIndex = 26;
            PSettings2.TabStop = false;
            PSettings2.Text = "Parameters Setting";
            PSettings2.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 56);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 24;
            label6.Text = "C2";
            // 
            // C2Input
            // 
            C2Input.Location = new Point(184, 54);
            C2Input.Name = "C2Input";
            C2Input.Size = new Size(61, 23);
            C2Input.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 29);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 22;
            label7.Text = "C1";
            // 
            // C1Input
            // 
            C1Input.Location = new Point(184, 27);
            C1Input.Name = "C1Input";
            C1Input.Size = new Size(61, 23);
            C1Input.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 81);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 20;
            label9.Text = "W";
            // 
            // WInput
            // 
            WInput.Location = new Point(93, 78);
            WInput.Name = "WInput";
            WInput.Size = new Size(61, 23);
            WInput.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 55);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 16;
            label10.Text = "Interaction";
            // 
            // InteractionInput
            // 
            InteractionInput.Location = new Point(93, 52);
            InteractionInput.Name = "InteractionInput";
            InteractionInput.Size = new Size(61, 23);
            InteractionInput.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 29);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 14;
            label11.Text = "Particle";
            // 
            // ParticleInput
            // 
            ParticleInput.Location = new Point(93, 27);
            ParticleInput.Name = "ParticleInput";
            ParticleInput.Size = new Size(61, 23);
            ParticleInput.TabIndex = 8;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(693, 274);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(218, 377);
            resultBox.TabIndex = 15;
            resultBox.TabStop = false;
            resultBox.Text = "Final Result";
            resultBox.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 663);
            Controls.Add(PSettings2);
            Controls.Add(PSettings3);
            Controls.Add(PSettings);
            Controls.Add(resultBox);
            Controls.Add(chartBox);
            Controls.Add(Title);
            Controls.Add(AText);
            Controls.Add(Acombo);
            Controls.Add(AText2);
            Controls.Add(DText);
            Controls.Add(dinput);
            Controls.Add(DText2);
            Controls.Add(confirmbtn);
            Name = "Form1";
            Text = "Form1";
            chartBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            PSettings.ResumeLayout(false);
            PSettings.PerformLayout();
            PSettings3.ResumeLayout(false);
            PSettings3.PerformLayout();
            PSettings2.ResumeLayout(false);
            PSettings2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Acombo_changed(object sender, EventArgs e)
        {

            chartBox.Visible = true;
            chartBox.Text = Acombo.Text;
            resultBox.Visible = true;

            PSettings.Visible = false;
            PSettings2.Visible = false;
            PSettings3.Visible = false;
            switch (Acombo.SelectedIndex)
            {
                case 0:
                    PSettings.Visible = true;
                    dataGridView1.Visible = false;
                    formsPlot2.Visible = false;
                    formsPlot1.Dock = DockStyle.Fill;
                    break;
                case 1:
                    PSettings2.Visible = true;
                    formsPlot2.Visible = true;
                    dataGridView1.Visible = true;
                    formsPlot1.Dock = DockStyle.None;
                    dataGridView1.Dock = DockStyle.None;
                    break;
                case 2:
                    PSettings3.Visible = true;
                    formsPlot2.Visible = false;
                    dataGridView1.Visible = true;
                    formsPlot1.Dock = DockStyle.None;
                    dataGridView1.Dock = DockStyle.Right;
                    break;
            }
        }

        private void confirmbtnclicked(object sender, EventArgs e)
        {
            int dimension = Convert.ToInt32(dinput.Text);
            switch (Acombo.SelectedIndex)
            {
                case 0:
                    int once_Inter = Convert.ToInt32(OnceInteractionInput.Text);
                    double init_T = Convert.ToDouble(InitTInput.Text);
                    double random_N1 = Convert.ToDouble(RNeighbor1Input.Text);
                    double random_N2 = Convert.ToDouble(RNeighbor2Input.Text);
                    double drop_T_Coeffient = Convert.ToDouble(DropTCoeffientInput.Text);
                    double leave_T = Convert.ToDouble(LeaveTInput.Text);

                    var (SA_optimalSolution, optimalObjective, SAfitnessHistory) = SAFunction.SimulatedAnnealing(dimension, once_Inter, init_T, random_N1, random_N2, drop_T_Coeffient, leave_T);
                    
                    DisplayResults(SA_optimalSolution, optimalObjective);
                    #region plot
                    double[] fitnessArray = new double[SAfitnessHistory.Count];
                    double[] iterationsArray = new double[SAfitnessHistory.Count];

                    for (int i = 0; i < SAfitnessHistory.Count; i++)
                    {
                        fitnessArray[i] = SAfitnessHistory[i].fitness;
                        iterationsArray[i] = SAfitnessHistory[i].iteration;
                    }
                    double maxFitness = fitnessArray[0];
                    double minFitness = fitnessArray[0];
                    for (int i = 1; i < fitnessArray.Length; i++)
                    {
                        if (fitnessArray[i] > maxFitness) maxFitness = fitnessArray[i];
                        if (fitnessArray[i] < minFitness) minFitness = fitnessArray[i];
                    }

                    double yMidpoint = (maxFitness + minFitness) / 2;
                    double yRange = maxFitness - minFitness;

                    formsPlot1.Dock = DockStyle.Fill;
                    var saplt = formsPlot1.Plot;

                    saplt.Add.ScatterPoints(iterationsArray, fitnessArray);
                    saplt.Axes.AutoScale();
                    saplt.XLabel("Time");
                    saplt.YLabel("Fitness");
                    formsPlot1.Refresh();
                    #endregion

                    break;
                case 1:
                    int particle = Convert.ToInt32(ParticleInput.Text);
                    int interaction = Convert.ToInt32(InteractionInput.Text);
                    double w = Convert.ToDouble(WInput.Text);
                    double c1 = Convert.ToDouble(C1Input.Text);
                    double c2 = Convert.ToDouble(C2Input.Text);
                    var result = PSOFunction.PSO(dimension, particle, interaction, w, c1, c2);

                    double[] PSO_bestPosition = result.BestPosition;
                    double PSO_bestFitness = result.BestFitness;
                    DisplayResults(PSO_bestPosition, PSO_bestFitness);
                    break;
                case 2:
                    int chromosome = Convert.ToInt32(chromasomeInput.Text);
                    double crossover_R = Convert.ToDouble(crossoverRInput.Text);
                    double mutation_R = Convert.ToDouble(mutationRInput.Text);
                    var (GA_bestSolution, GA_bestFitness, allSolutions, allFitness) = GAFunction.GeneticAlgorithm(dimension, chromosome, crossover_R, mutation_R);

                    DisplayResults(GA_bestSolution, GA_bestFitness);
                    DisplayDataResults(allSolutions, allFitness);
                    var gaplt = formsPlot1.Plot;

                    //gaplt.Add.Scatter(generationTimes, fitnessValuesArray);
                    gaplt.Axes.AutoScale();
                    gaplt.Title("Fitness Chart");
                    gaplt.XLabel("Iteration Times");
                    gaplt.YLabel("Fitness");
                    formsPlot1.Refresh();
                    break;
                
            }
        }
        public void DisplayResults(double[] solution, double fitness)
        {
            resultBox.Controls.Clear();

            TextBox resultTextBox = new TextBox();
            resultTextBox.Multiline = true;
            resultTextBox.Dock = DockStyle.Fill;
            resultTextBox.ReadOnly = true;
            resultBox.Controls.Add(resultTextBox);

            StringBuilder resultText = new StringBuilder();
            for (int i = 0; i < solution.Length; i++)
            {
                resultText.AppendLine($"X{i + 1}: {solution[i].ToString("0.00000")}");
            }
            resultText.AppendLine($"Fitness: {fitness.ToString("0.00000")}");

            resultTextBox.Text = resultText.ToString();
        }

        public void DisplayDataResults(List<double[]> solutions, List<double> fitnessValues)
        {
            var dataTable = new DataTable();
            for (int i = 1; i <= solutions[0].Length; i++)
            {
                dataTable.Columns.Add($"X{i}");
            }
            dataTable.Columns.Add("Fitness");

            for (int i = 0; i < solutions.Count; i++)
            {
                var row = dataTable.NewRow();
                for (int j = 0; j < solutions[i].Length; j++)
                {
                    row[$"X{j + 1}"] = solutions[i][j];
                }
                row["Fitness"] = fitnessValues[i];
                dataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = dataTable;
        }
        

        #region 參數
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label AText;
        private System.Windows.Forms.Label DText;
        private System.Windows.Forms.Label AText2;
        private System.Windows.Forms.Label DText2;
        private TextBox OnceInteractionInput;
        private System.Windows.Forms.GroupBox PSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private TextBox DropTCoeffientInput;
        private System.Windows.Forms.Label label2;
        private TextBox InitTInput;
        private System.Windows.Forms.Label label3;
        private TextBox RNeighbor1Input;
        private System.Windows.Forms.Label label5;
        private TextBox LeaveTInput;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.Label dash;
        private TextBox RNeighbor2Input;
        private System.Windows.Forms.GroupBox PSettings2;
        private System.Windows.Forms.Label label9;
        private TextBox WInput;
        private System.Windows.Forms.Label label10;
        private TextBox InteractionInput;
        private System.Windows.Forms.Label label11;
        private TextBox ParticleInput;
        private System.Windows.Forms.Label label6;
        private TextBox C2Input;
        private System.Windows.Forms.Label label7;
        private TextBox C1Input;
        private System.Windows.Forms.GroupBox PSettings3;
        private TextBox mutationRInput;
        private TextBox crossoverRInput;
        private TextBox chromasomeInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox chartBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private Button confirmbtn;
        private ComboBox Acombo;
        private TextBox dinput;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private FileSystemWatcher fileSystemWatcher1;
        #endregion

        private FormsPlot formsPlot1;
        private DataGridView dataGridView1;
        private FormsPlot formsPlot2;
    }
}
