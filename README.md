# C-Sharp-Expense-Tracking

## Overview
This program demonstrates how to use enums in C#, including `[Flags]` enums and standard enums, within the context of an expense tracking and approval workflow. It showcases how to combine enum values, check for specific flags, safely parse enums from strings, validate enum values, and handle workflow states using a `switch` statement.

The application also emphasizes efficient console output by accumulating results using a `StringBuilder` before printing.

## Coding Techniques
- **Enums and Flags Enums**: Uses standard enums and `[Flags]` enums to represent expense categories and approval stages.
- **Bitwise Operations**: Combines, checks, and removes enum flags using bitwise operators (`|`, `&`, `~`).
- **Enum Reflection Utilities**: Demonstrates `Enum.GetNames`, `Enum.GetValues`, `Enum.TryParse`, and `Enum.IsDefined`.
- **Control Flow with Enums**: Uses a `switch` statement to handle different approval stages.

## Example Output
```
ExpenseType Enum Names:
None
Travel
Meals
OfficeSupplies
Software
Entertainment

Expense includes: Meals

Current Expenses: Travel

Enum conversion failed.

Enum Name: Draft, Enum Value: 1
Enum Name: Submitted, Enum Value: 2
Enum Name: UnderReview, Enum Value: 3
Enum Name: Approved, Enum Value: 4
Enum Name: Rejected, Enum Value: 5

Successfully Parsed: Submitted

The following value was found in ApprovalStage: 4

The project is in a 'Draft' stage

'Meals' was found as a valid expense type

Valid Expenses: OfficeSupplies, Software
Current Approval Stage: Approved
```
