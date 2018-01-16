using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExerciseSoapCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Extract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Calculate(double a, double b, out double Extract, out double Multiply, out double Divide)
        {
            Extract = a - b;
            Multiply = a * b;
            Divide = a / b;

            return a + b;
        }

        public double Calculate(double a, double b, out double Extract, out double Multiply)
        {
            Extract = a - b;
            Multiply = a * b;
            
            return a + b;
        }
    }
}
