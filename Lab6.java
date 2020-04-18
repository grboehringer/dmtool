import java.util.*;

public class Lab6{
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        double interestRate;
        double loanAmount;
        int years;
        double monthlyPayment;

        double lowLoan = Double.parseDouble(args[0]);
        double highLoan = Double.parseDouble(args[1]);

        interestRate = getInterest();
        loanAmount = getLoanAmount(lowLoan, highLoan);
        years = getYears();
        monthlyPayment = calcMonthlyPayment(years, loanAmount, interestRate);

        double totalPaid = monthlyPayment * years * 12;
        double interestPaid = totalPaid - loanAmount;

        displayOutput(monthlyPayment, totalPaid, interestPaid);
    }

    public static double getInterest(){
        Scanner s = new Scanner(System.in);

        double interestYear;
        double interestMonth;

        do{
            System.out.print("Enter yearly interest rate: ");
            interestYear = Double.parseDouble(s.nextLine());
            interestMonth = interestYear/12;
            if (interestYear < 3 || interestYear > 12)
                System.out.println("Invalid input.");
        }while(interestYear < 3 || interestYear > 12);

        return interestMonth;
    }

    public static int getYears(){
        Scanner s = new Scanner(System.in);
        int years;

        do{
            System.out.print("Enter number of years: ");
            years = Integer.parseInt(s.nextLine());
            if (years < 1 || years > 50)
                System.out.println("Invalid input.");
        }while(years < 1 || years > 50);
        
        return years;
    }

    public static double getLoanAmount(double lowLoan, double highLoan){
        Scanner s = new Scanner(System.in);
        double loan;

        do{
            System.out.print("Enter loan amount: ");
            loan = Double.parseDouble(s.nextLine());
            if (loan < 50000 || loan > 1000000)
                System.out.println("Invalid input.");
        } while(loan < lowLoan || loan > highLoan);
        return loan;
    }

    public static double calcMonthlyPayment(int years, double loanAmount, double interestRate){
        double m;
        double p = loanAmount;
        double i = interestRate / 100;
        int n = years * 12;

        m = p * ((i * Math.pow(i + 1, n))/(Math.pow(1 + i , n) - 1));
        return m;
    }

    public static void displayOutput(double monthlyPayment, double totalPaid, double interestPaid){
        System.out.printf("The monthly payment is $%.2f\n", monthlyPayment);
        System.out.printf("The total paid on loan is $%.2f\n", totalPaid);
        System.out.printf("The total interest paid on loan is $%.2f\n", interestPaid);
    }
}