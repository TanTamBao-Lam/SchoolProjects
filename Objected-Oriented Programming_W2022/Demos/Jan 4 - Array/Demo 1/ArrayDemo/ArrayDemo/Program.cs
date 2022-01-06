using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array is a data structure used for storing a collection of
            // variables of the same time

            // With an array, we can store a group of data in a single variable

            // We are familiar with declaring variables to store a single literal value
            


            // But what if we had a group of numbers or a group of names to store
            
            // We could store each number in a variable
            




            // This may seem ok for a small amount of numbers, but think about how cumbersome this would 
            // be for a lot of numbers

            // Let's store all of those numbers in a single variable by declaring and initializing the array

            // Declaring an array is similar to declaring a variable for a single literal value,
            // but we include square brackets after the data type.  The brackets indicate to the compiler
            // that we want to create an array.

            

            // The array is declared above, but we now need to instantiate the array.  When we instantiate 
            // an array, we have to set the size of the array - the size represents the number of items (elements)
            // that are stored in the array.  In our case, we are going to store 5 numbers
            // Since an array is a reference type, we must use the "new" keyword to allocate memory for it

            

            // More commonly we will wee the declaration and instantiation in a single line of code like this:
            


            // Next we want to initialize the array by assigning values to individual array elements 
            // using their index number
            




            // we can also initialize an array at the same time we declare and instantiate it
            // By doing it this way, we do not have to specify the length becuase it is already supplied by the
            // number of elements in the initialization list.
            



            // we can access an array element by referring to it's index number
            

            // we can also change the value of an element in array
            

            // now the value of the second element in the array is 77

            // Now, let's write out the items in the array.  We can write out the items of the array one by one
           




            // That could get ugly pretty fast when you have a large amount of items in the array.
            // Instead, we will use a loop
            // First, let's use a for loop
            


            // Another way we can loop through it is to use a Foreach loop
            



            // lets do another quick example but this time using strings
            // let's create an array to hold the names of your instructors
            



            // Now, let's loop through and write them all out
            
          


            Console.ReadLine();

        }
    }

    
}
