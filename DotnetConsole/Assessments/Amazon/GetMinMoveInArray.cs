using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetConsole.Assessments.Amazon
{
    public class GetMinMoveInArray
    {
        public static void Go()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int platesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> plates = new List<int>();

            for (int i = 0; i < platesCount; i++)
            {
                int platesItem = Convert.ToInt32(Console.ReadLine().Trim());
                plates.Add(platesItem);
            }

            int result = getMinMoves(plates);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        static int getMinMoves(List<int> plates)
        {
            int minValueIndex = 1, maxValueIndex = plates.Count, tempMin = plates[0], tempMax = 0;
            for (int i = 1; i < plates.Count; i++)
            {
                int value = plates[i];

                if (value > tempMax)
                {
                    tempMax = value;
                    maxValueIndex = i;
                }
                if (value < tempMin)
                {
                    tempMin = value;
                    minValueIndex = i;
                }

            }
            int result = 0;
            if (minValueIndex != 1 && minValueIndex != 2 && maxValueIndex != plates.Count)
            {
                result = (plates.Count - (minValueIndex - 1)) + (plates.Count - (maxValueIndex + 1));
            }
            return result;
        }
    }
}
