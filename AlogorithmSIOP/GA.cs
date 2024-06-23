using AlogorithmSIOP;
class GAFunction
{
    private static Random random = new Random();

    public static (double[] BestSolution, double BestFitness, List<double[]> AllSolutions, List<double> AllFitness) GeneticAlgorithm(
       int dimension, int chromosomeCount, double crossoverRate, double mutationRate)
    {
        const int MAX_GENERATIONS = 1000;

        var population = InitializePopulation(chromosomeCount, dimension);
        var allSolutions = new List<double[]>();
        var allFitness = new List<double>();

        for (int generation = 0; generation < MAX_GENERATIONS; generation++)
        {
            population = EvaluatePopulation(population);

            var bestOfGeneration = population.OrderBy(i => i.Fitness).First();
            allSolutions.Add((double[])bestOfGeneration.Genes.Clone());
            allFitness.Add(bestOfGeneration.Fitness);

            population = SelectPopulation(population, chromosomeCount / 2);
            population = CrossoverPopulation(population, chromosomeCount, crossoverRate);
            population = MutatePopulation(population, mutationRate);
        }

        var bestSolution = population.OrderBy(i => i.Fitness).First();
        return (bestSolution.Genes, bestSolution.Fitness, allSolutions, allFitness);
    }

    private static Individual[] InitializePopulation(int size, int dimension)
    {
        return Enumerable.Range(0, size)
            .Select(_ => new Individual(GenerateRandomGenes(dimension)))
            .ToArray();
    }

    private static double[] GenerateRandomGenes(int dimension)
    {
        return Enumerable.Range(0, dimension)
            .Select(_ => random.NextDouble() ) // Range: [-1, 1]
            .ToArray();
    }

    private static Individual[] EvaluatePopulation(Individual[] population)
    {
        foreach (var individual in population)
        {
            individual.Fitness = ObjectiveFunction(individual.Genes);
        }
        return population;
    }

    private static double ObjectiveFunction(double[] x)
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

    private static Individual[] SelectPopulation(Individual[] population, int selectCount)
    {
        return population.OrderBy(i => i.Fitness)
            .Take(selectCount)
            .ToArray();
    }

    private static Individual[] CrossoverPopulation(Individual[] population, int targetSize, double crossoverRate)
    {
        var offspring = new Individual[targetSize - population.Length];
        for (int i = 0; i < offspring.Length; i += 2)
        {
            var parent1 = population[random.Next(population.Length)];
            var parent2 = population[random.Next(population.Length)];
            if (random.NextDouble() < crossoverRate)
            {
                var (child1, child2) = Crossover(parent1, parent2);
                offspring[i] = child1;
                if (i + 1 < offspring.Length)
                    offspring[i + 1] = child2;
            }
            else
            {
                offspring[i] = parent1;
                if (i + 1 < offspring.Length)
                    offspring[i + 1] = parent2;
            }
        }
        return population.Concat(offspring).ToArray();
    }

    private static (Individual, Individual) Crossover(Individual parent1, Individual parent2)
    {
        var crossoverPoint = random.Next(1, parent1.Genes.Length);
        var child1Genes = parent1.Genes.Take(crossoverPoint).Concat(parent2.Genes.Skip(crossoverPoint)).ToArray();
        var child2Genes = parent2.Genes.Take(crossoverPoint).Concat(parent1.Genes.Skip(crossoverPoint)).ToArray();
        return (new Individual(child1Genes), new Individual(child2Genes));
    }

    private static Individual[] MutatePopulation(Individual[] population, double mutationRate)
    {
        foreach (var individual in population)
        {
            if (random.NextDouble() < mutationRate)
            {
                var geneToMutate = random.Next(individual.Genes.Length);
                individual.Genes[geneToMutate] = random.NextDouble() * 2 - 1; // Range: [-1, 1]
            }
        }
        return population;
    }

    private class Individual
    {
        public double[] Genes { get; }
        public double Fitness { get; set; }

        public Individual(double[] genes)
        {
            Genes = genes;
        }
    }
}