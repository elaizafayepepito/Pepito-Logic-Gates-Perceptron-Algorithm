using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_LogicGates_PerceptronAlgorithm
{
    internal class Perceptron
    {
        // The weights for the inputs
        private double[] weights;
        // The bias for the Perceptron
        private double bias;
        // The learning rate for the Perceptron Algorithm
        private double learningRate;

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

        // The prediction function for the Perceptron
        public int Predict(double[] inputs)
        {
            double weightedSum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                weightedSum += inputs[i] * weights[i];
            }
            weightedSum += bias;

            return (weightedSum >= 0) ? 1 : -1;
        }

        // The training function for the Perceptron
        public void Train(double[][] inputs, int[] labels, int numEpochs)
        {
            for (int epoch = 0; epoch < numEpochs; epoch++)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    double output = Predict(inputs[i]);
                    double error = labels[i] - output;

                    // Update weights and bias
                    for (int j = 0; j < weights.Length; j++)
                    {
                        weights[j] += learningRate * error * inputs[i][j];
                    }
                    bias += learningRate * error;
                }
            }
        }
    }

    }
