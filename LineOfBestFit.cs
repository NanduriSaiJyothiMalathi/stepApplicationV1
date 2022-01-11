using System;
using System.Collections.Generic;
using System.Text;

namespace StepTestApplication
{
    public class LineOfBestFit
    {
        public decimal age;
        public bool isFemale;
        public decimal maxHr;
        public decimal maxhr85;
        public decimal maxhr50;

        public decimal[] x_values = null;
        public decimal[] y_values = new decimal[5];

        public decimal m_slope;
        public decimal b_interceptor;

        public decimal YMaxHr;
        public decimal X;
        decimal xSum = 0;
        decimal ySum = 0;


        public LineOfBestFit(int stepHeight)
        {
            if(stepHeight == 15)
            {
                x_values = new decimal[] { 11, 14, 18, 21, 25 };
            }
            else if(stepHeight == 20)
            {
                x_values = new decimal[] { 12, 17, 21, 25, 29 };
            }
            else if (stepHeight == 25)
            {
                x_values = new decimal[] { 14, 19, 24, 28, 31 };
            }
            else if (stepHeight == 30)
            {
                x_values = new decimal[] { 16, 2127, 32, 37 };
            }
            
        }

        public decimal calculateGradient()
        {
            try
            {
               
                decimal XYSum = 0;
                decimal XsqSum = 0;
                for (int i= 0;i < 5;i++)
                {
                    xSum += x_values[i];
                    XsqSum += (x_values[i] * x_values[i]);
                    XYSum += (x_values[i] * y_values[i]);
                    ySum += y_values[i];

                }

                m_slope = (XYSum - (xSum * ySum / 5)) / (XsqSum - (xSum * xSum / 5));
                return m_slope;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public decimal calculateInterceptor()
        {

            try
            {
                b_interceptor = (ySum / 5) - (m_slope * xSum / 5);
                return b_interceptor;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void calculateX()
        {
            try
            {
                YMaxHr = maxHr;
                m_slope = calculateGradient();
                b_interceptor = calculateInterceptor();
                X = (YMaxHr - b_interceptor) / m_slope;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
