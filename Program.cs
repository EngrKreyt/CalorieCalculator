// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calorie Calculator\n");
Console.WriteLine("Using Harris-Benedict Formula");

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

Console.WriteLine("Current Level of Activity: ");
string[] activity = new string[] { "[1] Sedentary (little or no exercise)", "[2] Lightly active (exercise 1–3 days/week)", "[3] Moderately active (exercise 3–5 days/week)",
"[4] Active (exercise 6–7 days/week)","[5] Very active (hard exercise 6–7 days/week)"};
foreach (string item in activity)
{
    Console.WriteLine(item);
}
int act = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The Harris-Benedict formula is used to describe your basal metabolic rate (BMR) as a numeric value.\nYour BMR is determined by your sex, age, and body size, and calculating this\nnumber tells you how about how many calories you burn just being alive and awake\n");
Console.WriteLine("Once you get out of bed and begin to move around, you will need to adjust this figure as you expend more energy.\nThis value, called active metabolic rate (AMR), is calculated by multiplying your BMR by an assigned number\n representing the various activity levels.\n This number ranges from 1.2 for being sedentary up to 1.9 for being very active.\n");

Formula Formula = new Formula();
int bmr = Formula.BMR(age, height, weight, sex);
Console.WriteLine("BMR: " + bmr);
int amr = Formula.AMR(act, bmr);
Console.WriteLine("AMR: " + amr);

class Formula
{
    public static int BMR(int age, double height, double weight, string? sex)
    {
        int bmr = 0;
        try
        {
            if (sex == "M" || sex == "m")
            {
                bmr = Convert.ToInt32(66.5 + (13.75 * weight) + (5.003 * height) - (6.75 * age));
                return bmr;
            }
            else if (sex == "F" || sex == "f")
            {
                bmr = Convert.ToInt32(655.1 + (9.563 * weight) + (1.850 * height) - (4.676 * age));
                return bmr;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return bmr;

    }
    public static int AMR(int act, int bmr)
    {
        int amr = 0;
        try
        {
            if (act == 1)
            {
                amr = Convert.ToInt32(bmr * 1.2);
                return amr;
            }
            else if (act == 2)
            {
                amr = Convert.ToInt32(bmr * 1.375);
                return amr;
            }
            else if (act == 3)
            {
                amr = Convert.ToInt32(bmr * 1.55);
                return amr;
            }
            else if (act == 4)
            {
                amr = Convert.ToInt32(bmr * 1.725);
                return amr;
            }
            else if (act == 5)
            {
                amr = Convert.ToInt32(bmr * 1.9);
                return amr;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return amr;
    }
}
