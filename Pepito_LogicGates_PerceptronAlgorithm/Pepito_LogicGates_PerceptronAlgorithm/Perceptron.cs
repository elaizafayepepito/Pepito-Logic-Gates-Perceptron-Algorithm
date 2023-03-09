using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_LogicGates_PerceptronAlgorithm
{
    internal class Perceptron
    {

        // The learning rate for the Perceptron Algorithm
        private double learningRate = 0.1;

        // The weights for the inputs
        private double[] weights;

        // The bias for the Perceptron
        private double bias;

        // Constructor to initialize the weights and bias to random values
        public Perceptron(int numInputs)
        {
            weights = new double[numInputs];
            Random rand = new Random();
            for (int i = 0; i < numInputs; i++)
            {
                weights[i] = rand.NextDouble();
            }
            bias = rand.NextDouble();
        }

        // The activation function for the Perceptron (returns 1 if the sum of the inputs
        // and the bias is greater than 0, 0 otherwise)
        private int Activation(double sum)
        {
            if (sum > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // The training function for the Perceptron
        public void Train(double[][] inputs, int[] outputs, int maxIterations)
        {
            int numInputs = inputs[0].Length;
            int numSamples = outputs.Length;
            int iteration = 0;
            while (iteration < maxIterations)
            {
                int numErrors = 0;
                for (int i = 0; i < numSamples; i++)
                {
                    double sum = bias;
                    for (int j = 0; j < numInputs; j++)
                    {
                        sum += weights[j] * inputs[i][j];
                    }
                    int output = Activation(sum);
                    int error = outputs[i] - output;
                    if (error != 0)
                    {
                        numErrors++;
                        for (int j = 0; j < numInputs; j++)
                        {
                            weights[j] += learningRate * error * inputs[i][j];
                        }
                        bias += learningRate * error;
                    }
                }
                iteration++;
                if (numErrors == 0)
                {
                    Console.WriteLine("Training completed after " + iteration + " iterations.");
                    return;
                }
            }
            Console.WriteLine("Training failed after " + maxIterations + " iterations.");
        }

        // The prediction function for the Perceptron (returns 1 if the sum of the inputs
        // and the bias is greater than 0, 0 otherwise)
        public int Predict(double[] inputs)
        {
            double sum = bias;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += weights[i] * inputs[i];
            }
            return Activation(sum);
        }
    }

    }
