using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class DNA<T>
    {
        public T[] Genes { get; set; }

        public float Fitness { get; set; }
        private Random _random;
        private Func<T> getRandomGene;
        private Func<float, int> fitnessFunction; 
        public DNA(int size, Random random, Func<T> getRandomGene, Func<float, int> fitnessFunction,bool showInitGenes = true)
        {
            Genes = new T[size];
            this._random = random;
            this.getRandomGene = getRandomGene;
            this.fitnessFunction = fitnessFunction;

            if (showInitGenes)
            {
                for (int i = 0; i < Genes.Length; i++)
                {
                    Genes[i] = getRandomGene();
                }
            }
        }
        public float CalculateFitness(int index)
        {
            Fitness = fitnessFunction(index);
            return Fitness;

        }
        public DNA<T> CrossOver(DNA<T> OtherParent)
        {
            DNA<T> child = new DNA<T>(Genes.Length, _random, getRandomGene,fitnessFunction, showInitGenes: false);
            Random random = new Random();
            for (int i = 0; i < Genes.Length; i++)
            {
                child.Genes[i] = random.NextDouble() < 0.5 ? Genes[i] : OtherParent.Genes[i];

            }
            return child;
        }
        public void Mutate(float mutationRate)
        {
            for (int i = 0; i < Genes.Length; i++)
            {
                if (_random.NextDouble() < mutationRate)
                {
                    Genes[i] = getRandomGene();
                }
            }
        }
    }
}
