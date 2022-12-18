// Name: Abiodun Oluwapelumi AMos
// Matric Number: 230865
//  Github link: https://github.com/A-Tech-Services/AdamsInput-Csharp.git

using System;
using System.IO;

namespace AdamsInputProgramming
{
    public class AdamsInput
    {
        // member variables
        string file; int testCase; string adamSteps;
        int lenAdamsStep; int steps; string[] lines;


        // checking and reading the external file.    
        public void ReadFromFile(){
            file = "adams.in";
            lines = File.ReadAllLines(file);


            // checking if lines are empty
            if(lines.Length == 0){
                Console.WriteLine("Error Opening File!");
            }         
        }

        // check steps taken
        public void CheckStepsTaken(){
           ReadFromFile();

            // get testCase and converting to integer
            testCase = Convert.ToInt32(lines[0]);


            // looping through number of testcases
            for(int i=1; i<=testCase; i++){

                adamSteps = lines[i];
                lenAdamsStep = adamSteps.Length;

                steps = 0;
                for(int j=0; j<lenAdamsStep; j++){
                    if(adamSteps[j] == 'U'){
                        steps++;
                    }else{
                        break;
                    }
                }

                // conditions for pluralizing my steps.
                if(steps > 1){
                    Console.WriteLine("Adam took {0} steps before falling", steps);
                }else{
                    Console.WriteLine("Adam took {0} step before falling", steps);
                }
                
            }   

        }
    }

    // executing Adams input
    class ExecuteAdamsInput
    {
        static void Main(string[] args)
        {
            AdamsInput adaminput = new AdamsInput();
            adaminput.CheckStepsTaken();
            Console.ReadKey();
        }
    }

}