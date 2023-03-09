namespace Pepito_LogicGates_PerceptronAlgorithm
{
    public partial class Form1 : Form
    {
        Perceptron p = new Perceptron(2);

        private double bias = -1; 
        private readonly double[,] weights = new double[3, 2];     
        private readonly double learningRate = 0.1;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOr_Click(object sender, EventArgs e)
        {
            // set weights and bias value
            weights[0, 0] = 0.5;
            weights[0, 1] = 0.5;
            bias = -0.5;
            double[] inputs = new double[2];
            if (double.TryParse(num1.Text, out double input1) && double.TryParse(num2.Text, out double input2))
            {
                inputs[0] = input1;
                inputs[1] = input2;
                double calculatedOutput = CalculateOutput(inputs, weights, bias);
                outputOr.Text = calculatedOutput.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void buttonAnd_Click(object sender, EventArgs e)
        {
            // set weights and bias value
            weights[0, 0] = 0.5;
            weights[0, 1] = 0.5;
            bias = -1;
            double[] inputs = new double[2];
            if (double.TryParse(num1.Text, out double input1) && double.TryParse(num2.Text, out double input2))
            {
                inputs[0] = input1;
                inputs[1] = input2;
                double calculatedOutput = CalculateOutput(inputs, weights, bias);
                outputAnd.Text = calculatedOutput.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private double CalculateOutput(double[] inputs, double[,] weights, double bias)
        {
            double sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * weights[0, i];
            }
            sum += bias;
            double output = (sum >= 0) ? 1 : 0;
            if (output != inputs[0])
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    weights[0, i] += learningRate * (inputs[0] - output) * inputs[i];
                }
                bias += learningRate * (inputs[0] - output);
            }
            return output;
        }

        private void buttonXor_Click(object sender, EventArgs e)
        {
            // set weights and bias value
            weights[0, 0] = 0.5;
            weights[0, 1] = -0.5;
            bias = -0.5;
            // apply perceptron algorithm
            double[] inputs = new double[2];
            if (double.TryParse(num1.Text, out double input1) && double.TryParse(num2.Text, out double input2))
            {
                inputs[0] = input1;
                inputs[1] = input2;
                double calculatedOutput = CalculateOutput(inputs, weights, bias);
                outputXor.Text = calculatedOutput.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void buttonNand_Click(object sender, EventArgs e)
        {
            // set weights and bias value
            weights[0, 0] = -0.5;
            weights[0, 1] = -0.5;
            bias = 0.75;
            double[] inputs = new double[2];
            if (double.TryParse(num1.Text, out double input1) && double.TryParse(num2.Text, out double input2))
            {
                inputs[0] = input1;
                inputs[1] = input2;
                double calculatedOutput = CalculateOutput(inputs, weights, bias);
                outputNand.Text = calculatedOutput.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void buttonNor_Click(object sender, EventArgs e)
        {
            // set weights and bias value
            weights[0, 0] = -0.5;
            weights[0, 1] = -0.5;
            bias = -0.5;
            double[] inputs = new double[2];
            if (double.TryParse(num1.Text, out double input1) && double.TryParse(num1.Text, out double input2))
            {
                inputs[0] = input1;
                inputs[1] = input2;
                double calculatedOutput = CalculateOutput(inputs, weights, bias);
                outputNor.Text = calculatedOutput.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }
    }
}