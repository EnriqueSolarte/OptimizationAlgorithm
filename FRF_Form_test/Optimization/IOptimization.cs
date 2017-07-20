using System.Collections.Generic;

namespace Optimization
{
    public interface IOptimization
    {           

        double[] Solve(ObjectiveFunction ObjFun);

        Result OPTResult { get;  }

        List<Result> OPTHistoryResult { get;}
    }

    public delegate double ObjectiveFunction(double[] parameters);

    public class Result
    {
        public double[] Parameters { get; set; }
        public double[] target { get; set; }
    }

   


}
