namespace Methods
{
    public class Calculator
    {
        public int Add(params int[] number)
        {
            var sum =0;
            foreach (var item in number)
                 sum = sum + item;

            return sum;
        }

    }
    
}
