// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calorie Counter");

int age;
string? sex;
double height;
double weight;


Console.WriteLine("Enter Age:");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Gender (M or F):");
sex = Console.ReadLine();

Console.WriteLine("Enter height (cm):");
height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter weight (kg):");
weight = Convert.ToInt32(Console.ReadLine());

//Program Program = new Program();
Formula Formula = new Formula();
Formula.BMR(age, height, weight, sex);


class Formula
{
    public int BMR(int age, double height, double weight, string? sex)
    {
        int bmr = 0;
        try
        {
            if (sex == "M" || sex == "m")
            {
                bmr = (66.5 + (13.75 * weight) + (5.003 * height) - (6.75 * age));
                return bmr;
            }
            else if (sex == "F" || sex == "f")
            {
                bmr = 655.1 + (9.563 * weight) + (1.850 * height) - (4.676 * age);
                return bmr;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return bmr;
    }
}
