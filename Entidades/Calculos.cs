using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Entidades
{
    public class Calculos
    {
       double Sumxy = 0;
        double Sumx = 0;
        double SumY = 0;
        double SumX2 = 0;
        double SumY2 = 0;
        double SUMXY= 0;
        int N = 0;
        double B1 = 0;
        double B0 = 0;
        double SCR = 0;
        double SCE = 0;
        double SCT =0;
        double MCE = 0;
        double RV = 0;
        double Rcuadrado = 0;
        double chi = 0;
        double t = 0;

        public double     b1( double Sumxy, double sumx, double sumy, double sumx2, int n )
        {
            SUMXY = Sumxy;
            Sumx= sumx;
            SumY= sumy;
            SumX2= sumx2;
            N = n;
            B1 = (Sumxy-((sumx*sumy)/n)) / (sumx2-((sumx*sumx)/n));
            return B1;
        }
        public double b0()
        {
            B0 = (SumY - ((B1 * Sumx)))/N;
            return B0;
        }

        public double RV1(double sumy2)
        {
            SCR = (B1) * (SUMXY - ((Sumx * SumY) / N));
            SCT = sumy2 - ((SumY*SumY)/N);
            SCE = SCT - SCR;
            MCE = SCE/(N-2);
            RV = SCR/MCE;
            return RV;
        }
        public double R2()
        {
            Rcuadrado = SCR / SCT;
            return Rcuadrado;
        }
        public double R()
        {
            return Math.Sqrt(Rcuadrado);
        }
        public double t_student() 
        {
            chi = (SumX2) - ((Sumx * Sumx) / N);
            t = (B1) / (Math.Sqrt(MCE/chi));
            return t;
        }
       




    }
}
