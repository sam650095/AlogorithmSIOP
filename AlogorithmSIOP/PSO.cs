using System;
using AlogorithmSIOP;
class PSOFunction
{
    static Random random = new Random();
    public class Particle
    {
        public double[] Position;
        public double[] Velocity;
        public double[] BestPosition;
        public double BestFitness;

        public Particle(int dimensions)
        {
            Position = new double[dimensions];
            Velocity = new double[dimensions];
            BestPosition = new double[dimensions];
            BestFitness = double.MaxValue;
        }
    }
    public static double SchwefelFunction(double[] position)
    {
        double sum = 0;
        foreach (double x in position)
        {
            sum += x * Math.Sin(Math.Sqrt(Math.Abs(x)));
        }
        return 418.9829 * position.Length - sum;
    }

    public static void InitializeParticles(List<Particle> particles, int dimensions, int particleCount)
    {
        for (int i = 0; i < particleCount; i++)
        {
            Particle particle = new Particle(dimensions);
            for (int d = 0; d < dimensions; d++)
            {
                particle.Position[d] = random.NextDouble() * 1000 - 500;
                particle.Velocity[d] = random.NextDouble() * 100 - 50;
            }
            particle.BestPosition = (double[])particle.Position.Clone();
            particle.BestFitness = SchwefelFunction(particle.Position);
            particles.Add(particle);
        }
    }

    public static void UpdateVelocity(Particle particle, double[] globalBestPosition, double inertiaWeight, double cognitiveCoefficient, double socialCoefficient, int dimensions)
    {
        for (int d = 0; d < dimensions; d++)
        {
            double r1 = random.NextDouble();
            double r2 = random.NextDouble();

            particle.Velocity[d] = inertiaWeight * particle.Velocity[d] +
                                   cognitiveCoefficient * r1 * (particle.BestPosition[d] - particle.Position[d]) +
                                   socialCoefficient * r2 * (globalBestPosition[d] - particle.Position[d]);
        }
    }

    public static void UpdatePosition(Particle particle, int dimensions)
    {
        for (int d = 0; d < dimensions; d++)
        {
            particle.Position[d] += particle.Velocity[d];
            if (particle.Position[d] > 500)
                particle.Position[d] = 500;
            else if (particle.Position[d] < -500)
                particle.Position[d] = -500;
        }
    }

    public static (double[] BestPosition, double BestFitness, List<double> GBestFitness, List<double[]> ParticlePositions) PSO(int dimensions, int particleCount, int iterations, double inertiaWeight, double cognitiveCoefficient, double socialCoefficient)
    {
        List<Particle> particles = new List<Particle>();
        InitializeParticles(particles, dimensions, particleCount);

        double[] globalBestPosition = new double[dimensions];
        double globalBestFitness = double.MaxValue;
        List<double> gBestFitness = new List<double>();
        List<double[]> particlePositions = new List<double[]>();

        for (int i = 0; i < iterations; i++)
        {
            foreach (Particle particle in particles)
            {
                double fitness = SchwefelFunction(particle.Position);
                if (fitness < particle.BestFitness)
                {
                    particle.BestFitness = fitness;
                    particle.BestPosition = (double[])particle.Position.Clone();
                }
                if (fitness < globalBestFitness)
                {
                    globalBestFitness = fitness;
                    globalBestPosition = (double[])particle.Position.Clone();
                }
            }

            gBestFitness.Add(globalBestFitness);

            foreach (Particle particle in particles)
            {
                particlePositions.Add((double[])particle.Position.Clone());
                UpdateVelocity(particle, globalBestPosition, inertiaWeight, cognitiveCoefficient, socialCoefficient, dimensions);
                UpdatePosition(particle, dimensions);
            }
        }

        return (globalBestPosition, globalBestFitness, gBestFitness, particlePositions);
    }
}
