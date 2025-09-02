using System.Xml.Linq;

namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if (a == 0 || b == 0 || c == 0)
            {
                answer = false;
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                answer = true;
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here

            if (a % b == 0 || b % a == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == 0 || b == 0)
            {
                answer = false;
            }
            else
            {
                if (a * a == b)
                {
                    answer = true;
                }
                if (b * b == a)
                {
                    answer = true;
                }
                if (a * a * a == b)
                {
                    answer = true;
                }
                if (b * b * b == a)
                {
                    answer = true;
                }
            }
                // end

                return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = f * f - 4 * d * g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 1;
            }
            if (-1 < x && x <= 1)
            {
                answer = -1 * x;
            }
            if (x > 1)
            {
                answer = -1;
            }
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            double storona = 2 * Math.Sqrt(circleS / Math.PI);
            if (storona * storona <= squareS)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s)
            {
                if (t)
                {
                    answer = 6;
                }
                else
                {
                    if (f)
                    {
                        answer = 10;
                    }
                    else
                    {
                        answer = 2;
                    }
                }
            }

            else
            {
                if (t)
                {
                    answer = 3;
                }
                else
                {
                    if (f)
                    {
                        answer = 5;
                    }
                    else
                    {
                        answer = 1;
                    }
                }
            }
            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;
            var aur = (pupils / 7) * salary;
            var uchen = pupils * 5;

            // code here
            if (year % 4 == 0)
            {
                answer = false;
            }
            else
            {
                if (aur + uchen <= bank)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
    }
}