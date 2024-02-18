# Eligibility-for-Engineering-Admission
## Aim:
To write a C# program to check whether the student is eligibile for the engineering admission

## Algorithm:

### Step1: 
Get the maths, chemistry and physics marks from the user using ReadLine().

### Step2: 
Calculate the sum of all three subjects and check whether the sum is greater than and equal to 180

### Step3:
Calculate the sum of physics,maths,chemistry marks

### Step4:
Check the conditions and end the program

### Step5:
Get the output

## Program:

NAME: SACHIN.C

REG NO: 212222230125

```python
using System;

namespace EngineeringAdmission
{
    class Program
    {
        static void Main(string[] args)
        {
            int maths, physics, chemistry;
            Console.WriteLine("Welcome to Engineering Admission Eligibility Checker");

            Console.Write("Enter Math marks: ");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Physics marks: ");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry marks: ");
            chemistry = Convert.ToInt32(Console.ReadLine());

            int totalMarks = maths + physics + chemistry;

            if (maths >= 65 && physics >= 55 && chemistry >= 50)
            {
                if (totalMarks >= 180)
                {
                    Console.WriteLine("Congratulations! You are eligible for admission.");

                }
                else
                {
                    Console.WriteLine("Sorry, you are not eligible for admission.");

                }
            }
        }
    }
}
```

## Output:

![image](https://github.com/Sachin-vlr/Eligibility-for-Engineering-Admission/assets/113497666/12346326-ab19-4418-8c60-2e82cb2c4e5a)

## Result:
Thus the above C# program to check the eligibility of engineering admission is successfully executed.

