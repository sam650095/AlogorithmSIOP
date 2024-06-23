using AlogorithmSIOP;
using System;

class SAFunction
{
    static Random rand = new Random();

    public static double ObjectiveFunction2(double[] x)
    {
        double leftsum = 0;
        double rightsum = 0;

        for (int i = 0; i < x.Length; i++)
        {
            leftsum += Math.Pow(Math.Sqrt(Math.Pow(10, -5)) * (x[i] - 1), 2);
        }

        for (int j = 0; j < x.Length; j++)
        {
            rightsum += Math.Pow(Math.Pow(x[j], 2) - 0.25, 2);
        }
        return leftsum + rightsum;
    }
    public static double ObjectiveFunction(double[] x)
    {
        double sum = 0;
        for (int i = 0; i < x.Length; i++)
        {
            sum += x[i] * Math.Sin(Math.Sqrt(Math.Abs(x[i])));
        }
        return 418.9829 * x.Length - sum;
    }
    static double[] GenerateNeighbor(double[] x, double random_N1, double random_N2)
    {
        double[] neighbor = new double[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            neighbor[i] = x[i] + (rand.NextDouble() * (random_N2 - random_N1) + random_N1);
        }
        return neighbor;
    }

    public static (double[] bestSolution, double bestObjective, List<(int iteration, double temperature, double fitness)> fitnessHistory)
        SimulatedAnnealing(int dimension, int once_Inter, double init_T, double random_N1, double random_N2, double drop_T_Coeffient, double leave_T)
    {
        double[] currentSolution = new double[dimension];
        for (int i = 0; i < dimension; i++)
        {
            currentSolution[i] = rand.NextDouble();
            // Console.WriteLine(currentSolution[i]);
        }
        double currentObjective = ObjectiveFunction(currentSolution);
        double temperature = init_T;

        double[] bestSolution = currentSolution;
        double bestObjective = currentObjective;

        List<(int iteration, double temperature, double fitness)> fitnessHistory = new List<(int iteration, double temperature, double fitness)>();
        int totalIterations = 0;

        while (temperature > leave_T)
        {
            for (int iteration = 0; iteration < once_Inter; iteration++)
            {
                double[] candidateSolution = GenerateNeighbor(currentSolution, random_N1, random_N2);
                double candidateObjective = ObjectiveFunction(candidateSolution);

                if (candidateObjective < currentObjective || Math.Exp((currentObjective - candidateObjective) / temperature) > rand.NextDouble())
                {
                    currentSolution = candidateSolution;
                    currentObjective = candidateObjective;

                    if (candidateObjective < bestObjective)
                    {
                        bestSolution = candidateSolution;
                        bestObjective = candidateObjective;
                    }
                }
                if (iteration % 50 == 0)
                {
                    fitnessHistory.Add((totalIterations, temperature, currentObjective));
                }
                totalIterations++;
            }
            temperature *= drop_T_Coeffient;
        }
        return (bestSolution, bestObjective, fitnessHistory);
    }
}