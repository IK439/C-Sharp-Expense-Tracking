using System;
using System.Text;

namespace ExpenseTrackerApp
{
    // Flags enum allows combining multiple expense types
    [Flags]
    public enum ExpenseType
    {
        None = 0,
        Travel = 1,
        Meals = 2,
        OfficeSupplies = 4,
        Software = 8,
        Entertainment = 16
    }

    // Enum representing approval workflow stages
    public enum ApprovalStage
    {
        Draft = 1,
        Submitted = 2,
        UnderReview = 3,
        Approved = 4,
        Rejected = 5
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Use StringBuilder to accumulate output efficiently
            StringBuilder output = new StringBuilder();

            // Display all names in the ExpenseType enum
            output.AppendLine("ExpenseType Enum Names:");
            foreach (string name in Enum.GetNames(typeof(ExpenseType)))
            {
                output.AppendLine(name);
            }
            output.AppendLine();

            // Combine multiple expense types using bitwise OR
            ExpenseType expenses = ExpenseType.Travel | ExpenseType.Meals;

            // Check if Meals is included using bitwise AND
            if ((expenses & ExpenseType.Meals) == ExpenseType.Meals)
            {
                output.AppendLine("Expense includes: Meals");
            }
            else
            {
                output.AppendLine("Expense does not include: Meals");
            }
            output.AppendLine();

            // Remove Meals from the combined expense types
            expenses &= ~ExpenseType.Meals;
            output.AppendLine($"Current Expenses: {expenses}");
            output.AppendLine();

            // Try to parse a string into an ExpenseType enum
            if (Enum.TryParse("Meals | Software", out ExpenseType parsedExpense))
            {
                output.AppendLine($"Successfully Parsed: {parsedExpense}");
            }
            else
            {
                output.AppendLine("Enum conversion failed.");
            }
            output.AppendLine();

            // Display all ApprovalStage enum values and their numeric values
            foreach (ApprovalStage approval in Enum.GetValues<ApprovalStage>())
            {
                output.AppendLine($"Enum Name: {approval}, Enum Value: {(int)approval}");
            }
            output.AppendLine();

            // Try to parse a string into an ApprovalStage enum
            if (Enum.TryParse("Submitted", out ApprovalStage parsedStage))
            {
                output.AppendLine($"Successfully Parsed: {parsedStage}");
            }
            else
            {
                output.AppendLine("Enum conversion failed.");
            }
            output.AppendLine();

            // Validate an integer against the ApprovalStage enum
            int approvalValue = 4;
            if (Enum.IsDefined(typeof(ApprovalStage), approvalValue))
            {
                output.AppendLine($"The following value was found in ApprovalStage: {approvalValue}");
            }
            else
            {
                output.AppendLine("The value is not defined.");
            }
            output.AppendLine();

            // Set the current approval stage
            ApprovalStage currentStage = ApprovalStage.Draft;

            // Display message based on approval stage
            switch (currentStage)
            {
                case ApprovalStage.Draft:
                    output.AppendLine("The project is in a 'Draft' stage");
                    break;
                case ApprovalStage.Submitted:
                    output.AppendLine("The project is in a 'Submitted' stage");
                    break;
                case ApprovalStage.UnderReview:
                    output.AppendLine("The project is in an 'Under Review' stage");
                    break;
                case ApprovalStage.Approved:
                    output.AppendLine("The project is in an 'Approved' stage");
                    break;
                case ApprovalStage.Rejected:
                    output.AppendLine("The project is in a 'Rejected' stage");
                    break;
                default:
                    output.AppendLine("Unknown stage");
                    break;
            }
            output.AppendLine();

            // Combine valid expense types
            ExpenseType validExpense = ExpenseType.OfficeSupplies | ExpenseType.Software;

            // Check if a name exists in the ExpenseType enum
            if (Enum.IsDefined(typeof(ExpenseType), "Meals"))
            {
                output.AppendLine("'Meals' was found as a valid expense type");
            }
            else
            {
                output.AppendLine("'Meals' was not found as a valid expense type");
            }
            output.AppendLine();

            // Update approval stage and display final values
            currentStage = ApprovalStage.Approved;
            output.AppendLine($"Valid Expenses: {validExpense}");
            output.AppendLine($"Current Approval Stage: {currentStage}");

            // Print all accumulated output at once
            Console.WriteLine(output.ToString());
        }
    }
}