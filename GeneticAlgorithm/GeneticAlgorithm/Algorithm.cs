using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Algorithm<T>
    {

        public List<DNA<T>> Population { get; set; }

        public int Generation { get; set; }
        public float MutationRate { get; set; }

        private Random random;

        private float fitnessSum { get; set; }

        public Algorithm(int PopulationSize, int dnaSize, Random random, Func<T> getRandomGene, Func<float, int> fitnessFunction, float mutationRate = 0.01f)
        {
            Generation = 1;
            mutationRate = MutationRate;
            Population = new List<DNA<T>>();
            this.random = random;
            for (int i = 0; i < PopulationSize; i++)
            {
                Population.Add(new DNA<T>(dnaSize, random, getRandomGene, fitnessFunction, showInitGenes: true));
            }
        }

        public void newGeneration()
        {
            if (Population.Count < 0)
            {
                return;
            }
            calculateFitness();

            List<DNA<T>> newPopulation = new List<DNA<T>>();
            for (int i = 0; i < Population.Count; i++)
            {
                DNA<T> parent1 = null;
                DNA<T> parent2 = null;

                DNA<T> child = parent1.CrossOver(parent2);
                child.Mutate(MutationRate);
                newPopulation.Add(child);
            }
            Population = newPopulation;
            Generation++;
        }

        private void calculateFitness()
        {
            fitnessSum = 0;
            for (int i = 0; i < Population.Count; i++)
            {
              fitnessSum+=  Population[i].CalculateFitness(i);
            }
        }

     
    }
}
