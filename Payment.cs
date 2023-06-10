using System;

public class Payment
{
    string NameOfMember;
    string SurnameOfMember;
    double SumToPay;
    double AlreadyPaid;
    public double RemainderPayment;
    bool IsCorrect;
    public bool PaidMore;

    public Payment(string nameOfMember, string surnameOfMember, double sumToPay, double alreadyPaid)
    {
        SetName(nameOfMember);
        SetSurname(surnameOfMember);
        SetSum(sumToPay);
        SetPaid(alreadyPaid);
    }

    public void SetName(string nameOfMember)
    {
        NameOfMember = nameOfMember;
    }

    public void SetSurname(string surnameOfMember)
    {
        SurnameOfMember = surnameOfMember;
    }

    public void SetSum(double sumToPay)
    {
        SumToPay = sumToPay;
    }

    public void SetPaid(double alreadyPaid)
    {
        AlreadyPaid = alreadyPaid;
    }

    public void SetRemainder(double sumToPAy, double alreadyPaid, double remainderPayment)
    {
        remainderPayment = SumToPay - AlreadyPaid;
        RemainderPayment = remainderPayment;
    }

    public bool Is_Correct(bool isCorrect)
    {
        if (SumToPay < 0 || AlreadyPaid < 0)
        {
            isCorrect = false;
        }
        else isCorrect = true;

        IsCorrect = isCorrect;
        return IsCorrect;
    }

    public bool Paid_More(bool paidMore)
    {
        if (RemainderPayment < 0)
        {
            paidMore = true;
        }
        else paidMore=false;
        PaidMore = paidMore;
        return PaidMore;
    }

    public override string ToString()
    {
        if (IsCorrect)
        {
            if (PaidMore)
            {
                return "\nMember`s name: " + NameOfMember + "\nMember`s surname: " + SurnameOfMember +
                    "\nSum to pay: " + SumToPay + "\nMember already paid: " +
                    AlreadyPaid + "\nYou paid " + Math.Abs(RemainderPayment) + " more than needed" + "\n--------------------------\n";
            }
            else
                return "\nMember`s name: " + NameOfMember + "\nMember`s surname: " + SurnameOfMember +
                    "\nSum to pay: " + SumToPay + "\nMember already paid: " +
                    AlreadyPaid + "\nRemainds to pay: " + RemainderPayment + "\n--------------------------\n";
        }
        else
            return "\nThe amount of money can not be negative\n";
    }
}
