﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Optimization
{
    public class GeneticAlgorithm : IOptimization
    {
        #region Properties
        public Settings GA_Settings { get; set; }
        public List<double[][]> PopulationsHistory { get; }
        public List<Fitness> FitnessHistory { get; }
        public bool IsPatternAvailable { get; set; }
        private double[] patternFeature;
        public double[] PatternFeature
        {
            get
            {
                return patternFeature;
            }

            set
            {
                patternFeature = new double[GA_Settings.RangeFeatures.Count];
                patternFeature = value;
            }
        }


        #endregion

        #region Interface properties

        public Result OPTResult { get; }
        public List<Result> OPTHistoryResult { get; }
        public double[] Solve(ObjectiveFunction ObjFunc)
        {
            if (Validation())
            {
                PopulationsHistory.Clear();
                FitnessHistory.Clear();

                #region Initial Population and its Fitness

                double[][] initilaPopulation = initializePopulation(); // Get a new population
                PopulationsHistory.Add(initilaPopulation); // add new population to the History populaion

                Fitness initialFitness = new Fitness(GA_Settings.PopulationSize); //Make a new obj Fitness
                Parallel.For(0, GA_Settings.PopulationSize, i =>
                {
                    initialFitness.FitnessPopulation[i] = ObjFunc(initilaPopulation[i]);
                }); // Evaluate the new population 

                initialFitness.SetFitenessData();  // Getting the Data of this Fitness evaluation, Max, Mean, index of the max feature...so on.

                initialFitness.BestFeature = (double[])initilaPopulation[initialFitness.MaxFitnessIndex].Clone(); ;
                FitnessHistory.Add(initialFitness);

                OPTHistoryResult.Add(new Result
                {
                    Parameters = (double[])initialFitness.BestFeature.Clone(),
                    target = new double[2] { initialFitness.MaxFitness, initialFitness.MeanFitness }
                });

                #endregion

                int gen = 0;

                #region While Loop for Genereations
                while (gen < GA_Settings.Generations - 1)
                {
                    double[][] currentPopulation = PopulationsHistory.Last();
                    Fitness currentFitness = FitnessHistory.Last();

                    double[][] newPopulation = new double[GA_Settings.PopulationSize][];

                    #region GA
                    newPopulation = Selection(currentPopulation, currentFitness.FitnessPopulation);
                    newPopulation[0] = (double[])currentFitness.BestFeature.Clone();
                    newPopulation = Crossover(newPopulation);
                    newPopulation = Mutation(newPopulation);
                    #endregion

                    Fitness newFitness = new Fitness(GA_Settings.PopulationSize);
                    Parallel.For(0, GA_Settings.PopulationSize, i =>
                    {
                        newFitness.FitnessPopulation[i] = ObjFunc(newPopulation[i]);
                    });

                    newFitness.SetFitenessData();
                    newFitness.BestFeature = (double[])newPopulation[newFitness.MaxFitnessIndex].Clone();

                    #region Saving Best fearture  NEW Vs CURRENT
                    if (newFitness.MaxFitness <= currentFitness.MaxFitness)
                    {
                        newPopulation[0] = (double[])currentFitness.BestFeature.Clone();
                        newFitness.BestFeature = (double[])currentFitness.BestFeature.Clone();
                        newFitness.FitnessPopulation[0] = currentFitness.MaxFitness;
                        newFitness.SetFitenessData();
                    }
                    #endregion

                    PopulationsHistory.Add(newPopulation);
                    FitnessHistory.Add(newFitness);


                    OPTHistoryResult.Add(new Result
                    {
                        Parameters = (double[])newFitness.BestFeature.Clone(),
                        target = new double[2] { newFitness.MaxFitness, newFitness.MeanFitness }
                    });

                    gen++;

                }
                #endregion

                OPTResult.Parameters = OPTHistoryResult.Last().Parameters;
                OPTResult.target = OPTHistoryResult.Last().target;

            }


            return OPTHistoryResult.Last().Parameters;
        }

        #endregion

        #region Getting Data by outside
        public double[] GetMaxFitnessHistory()
        {
            double[] MaxFitnessHistory = new double[GA_Settings.Generations];

            Parallel.For(0, GA_Settings.Generations, i =>
            {
                MaxFitnessHistory[i] = FitnessHistory[i].MaxFitness;
            });

            return MaxFitnessHistory;
        }

        public double[] GetMeanFitnessHistory()
        {
            double[] MeanFitnessHistory = new double[GA_Settings.Generations];
            Parallel.For(0, GA_Settings.Generations, i =>
            {
                MeanFitnessHistory[i] = FitnessHistory[i].MeanFitness;
            });

            return MeanFitnessHistory;
        }

        public double[] GetFeatureHistory(int index = 0)
        {
            double[] Feature = new double[GA_Settings.Generations];
            Parallel.For(0, GA_Settings.Generations, i =>
            {
                Feature[i] = FitnessHistory[i].BestFeature[index];
            });

            return Feature;
        }
        #endregion

        #region Consntructors
        public GeneticAlgorithm(int populationSize, List<Range> rangeFeatures, double pCross, double pMutation, int generations)
        {
            GA_Settings = new Settings();
            GA_Settings.PopulationSize = populationSize;
            GA_Settings.RangeFeatures = rangeFeatures;
            GA_Settings.PCrossover = pCross;
            GA_Settings.PMutation = pMutation;
            GA_Settings.Generations = generations;
            GA_Settings.TargetRange = new Range { MinValue = 0, MaxValue = 0 };

          
            PopulationsHistory = new List<double[][]>();
            FitnessHistory = new List<Fitness>();

            OPTResult = new Result();
            OPTHistoryResult = new List<Result>();

        }

        public GeneticAlgorithm(int populationSize, List<Range> rangeFeatures, double pCross, double pMutation, Range range)
        {
            GA_Settings = new Settings();
            GA_Settings.PopulationSize = populationSize;
            GA_Settings.RangeFeatures = rangeFeatures;
            GA_Settings.PCrossover = pCross;
            GA_Settings.PMutation = pMutation;
            GA_Settings.TargetRange = range;
            GA_Settings.Generations = 100;

            PopulationsHistory = new List<double[][]>();
            FitnessHistory = new List<Fitness>();

            OPTResult = new Result();
            OPTHistoryResult = new List<Result>();

        }

        public GeneticAlgorithm()
        {
            GA_Settings = new Settings();
            GA_Settings.TargetRange = new Range { MinValue = 0, MaxValue = 0 };
            GA_Settings.Generations = 100;

            PopulationsHistory = new List<double[][]>();
            FitnessHistory = new List<Fitness>();

            OPTResult = new Result();
            OPTHistoryResult = new List<Result>();
        }
        #endregion

        #region Internal Function to GA

        private double[][] initializePopulation()
        {
            ///Initialize a new population with the related parameters at GA_Settings
            Random rnd = new Random();
            double[][] newPopulation = new double[GA_Settings.PopulationSize][];
            for (int i = 0; i < GA_Settings.PopulationSize; i++)
            {
                double[] aux = new double[GA_Settings.RangeFeatures.Count];
                           
                    for (int j = 0; j < GA_Settings.RangeFeatures.Count; j++)
                    {
                        aux[j] = GA_Settings.RangeFeatures.ElementAt(j).MinValue + rnd.NextDouble() * (GA_Settings.RangeFeatures.ElementAt(j).MaxValue - GA_Settings.RangeFeatures.ElementAt(j).MinValue);
                    }

                if (IsPatternAvailable)
                {
                    if (rnd.NextDouble() < 0.01)
                    {
                        aux = patternFeature;
                    }

                }

                newPopulation[i] = aux;

            }
            return newPopulation;
        }

        private double[][] Selection(double[][] currentPopulation, double[] currentFitness)
        {
            Random rnd = new Random();
            double sumatoryFitness = currentFitness.Sum();

            double[][] selectedPopulation = new double[GA_Settings.PopulationSize][];

            Parallel.For(0, GA_Settings.PopulationSize, i =>
             {
                 double test = rnd.NextDouble() * sumatoryFitness;
                 double partSum = currentFitness[0];
                 int j = 0;

                 while (partSum < test)
                 {
                     partSum = partSum + currentFitness[j + 1];
                     j++;

                     if (j == GA_Settings.PopulationSize) j = 0;
                 }

                 selectedPopulation[i] = (double[])currentPopulation[j].Clone(); ;
             });

            return selectedPopulation;
        }

        private double[][] Crossover(double[][] currentPopulation)
        {
            Random rnd = new Random();
            double[][] selectedPopulation = (double[][])currentPopulation.Clone();

            Parallel.For(0, (int)GA_Settings.PopulationSize-1, i =>
              {
                  
                  if (rnd.NextDouble() <= GA_Settings.PCrossover)
                  {
                      for (int j = 0; j < GA_Settings.RangeFeatures.Count; j++)
                      {
                          double aux = rnd.NextDouble();
                          selectedPopulation[i][j] = (1 - aux) * currentPopulation[i][j] + aux * currentPopulation[i + 1][j];
                          selectedPopulation[i + 1][j] = aux * currentPopulation[i][j] + (1 - aux) * currentPopulation[i + 1][j];
                      }
                  }
                  i = i + 2;
              });
            return selectedPopulation;
        }

        private double[][] Mutation(double[][] currentPopulation)
        {
            Random rnd = new Random();
            double[][] selectedPopulation = (double[][])currentPopulation.Clone();

            Parallel.For(0, GA_Settings.PopulationSize, i =>
            {
                if (rnd.NextDouble() <= GA_Settings.PMutation)
                {
                    for (int j = 0; j < GA_Settings.RangeFeatures.Count; j++)
                    {
                        selectedPopulation[i][j] = GA_Settings.RangeFeatures.ElementAt(j).MinValue + rnd.NextDouble() * (GA_Settings.RangeFeatures.ElementAt(j).MaxValue - GA_Settings.RangeFeatures.ElementAt(j).MinValue);
                    }
                }
            });

            return selectedPopulation;
        }

        private bool Validation()
        {
            bool validation = true;
            return validation;
        }

        #endregion

        public class Fitness
        {
            public double MaxFitness { get; set; }
            public double MeanFitness { get; set; }
            public int MaxFitnessIndex { get; set; }
            public double[] BestFeature { get; set; }
            public double[] FitnessPopulation { get; set; }

            public Fitness(int populationSize)
            {
                FitnessPopulation = new double[populationSize];
            }

            internal void SetFitenessData()
            {
                MaxFitness = FitnessPopulation.Max();
                MeanFitness = FitnessPopulation.Sum() / FitnessPopulation.Count();
                MaxFitnessIndex = FitnessPopulation.ToList().IndexOf(MaxFitness);
            }

        }
        public class Settings
        {
            public int PopulationSize { get; set; }
            public List<Range> RangeFeatures { get; set; }
            public double PCrossover { get; set; }
            public double PMutation { get; set; }
            public Range TargetRange { get; set; }
            public int Generations { get; set; }
        }

    }

   

    public struct Range
    {
        public double MaxValue { get; set; }
        public double MinValue { get; set; }
    }



}

