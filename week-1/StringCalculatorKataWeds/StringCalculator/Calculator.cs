
using System.Reflection.Metadata.Ecma335;

public class Calculator
{
    public int Add(string numbers)
    {
        string[] fruit;
        string[] veggie;

        int total = 0;

        if (string.IsNullOrEmpty(numbers))
        {
            return 0; 
        }

        if (numbers.Contains(",") && numbers.Contains("\n"))
        {

            veggie = numbers.Split('\n');

            foreach (string character in veggie)
            {
                if (!numbers.Contains("\n"))
                {
                    break;
                }

                total += int.Parse(character);
                
            }

            fruit = numbers.Split(',');

            foreach (string num in fruit)
            {
                if (!numbers.Contains(","))
                {
                    break;
                }

                total += int.Parse(num);
                
            }

            return total;
        }

        if (numbers.Contains(","))
        {
            fruit = numbers.Split(',');

            foreach (string num in fruit)
            {
                total += int.Parse(num);
            }

            return total;
        }
        if (numbers.Contains("\n"))
        {
            fruit = numbers.Split('\n');

            foreach (string num in fruit)
            {
                total += int.Parse(num);
            }

            return total;
        }
        else
        {
            return int.Parse(numbers);
        }
    }

    
}
