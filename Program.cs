using System;

namespace Code_Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Console.WriteLine("Hello World!");
            Question1();
            //Question2()
        }
        static void Question1()
        {
            //Create array that takes length and elements from console
            Console.Write("Enter Length of array:");
            int lengthOfArray = int.Parse(Console.ReadLine());
            int [] nums = new int [lengthOfArray];
            for (int i = 0; i < lengthOfArray; i++)
            {
            Console.Write("Input elements of array: ");
            nums[i] = int.Parse(Console.ReadLine()); 
            //Write code to check first condition an lonely elements (appears only once with no neighbor number)
                int occurence = 0;
                foreach (var item in nums)
                {
                    if(nums[i] == nums[i+1])
                    {
                        occurence++;
                        if(occurence == 1)
                        {
                            //use conditional statement to check if neigbour of elements are present in array to certify second condition
                            if((nums[i] + 1) != nums[i+1] || (nums[i] - 1) != nums[i+1])
                            {
                                Console.WriteLine(nums[i]+ ",");
                            }
                        }
                    }
                }
            }

        }
        static void Question2()
        {
            //Create array that takes length and elements from console
            Console.Write("Enter Length of array:");
            int lengthOfArray = int.Parse(Console.ReadLine());
            int [] nums = new int [lengthOfArray];
            for (int i = 0; i < lengthOfArray; i++)
            {
               Console.Write("Input elements of array: ");
               nums[i] = int.Parse(Console.ReadLine());
               //Write code that allows to search for the original
               Console.Write("Enter the element to be searched for in the array: ");
               int original = int.Parse(Console.ReadLine());
               //Check if the original is present in nums
               if(original != nums[i]){
                Console.WriteLine("Original not present in array");
               }
               else{
                do
                {
                    original*=2;
                } while (original == nums[i]);
                Console.WriteLine(original);
               }
            }
        }
    }
}
