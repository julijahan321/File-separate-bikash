class Recharge
{
    int count = 1;
    int x=int.Parse(Console.ReadLine());

    
   public void RechergeMoney()
    {
        while (x == 3)
        {
            Console.WriteLine("bKas");
            Console.WriteLine(count++ + " Robi");
            Console.WriteLine(count++ + " Airtel");
            Console.WriteLine(count++ + " Banglalink");
            Console.WriteLine(count++ + " Grameenphone");
            Console.WriteLine(count++ + " Teletalk");
            Console.WriteLine(count++ + " Pay Bill");
            Console.WriteLine(count++ + " Get Up To 150 Tk Cashback to bKash Recharge");
            Console.WriteLine(0 + " Main Menu");

            count = 1;
            int press4 = int.Parse(Console.ReadLine());
            if (press4 == 0)
            {
                break;
            }
            if (press4 == 4)
            {
                Console.WriteLine("bKash");
                Console.WriteLine(count++ + " prepaid");
                Console.WriteLine(count++ + " postpaid");
                Console.WriteLine(count++ + " skitto");
                Console.WriteLine(count++ + " auto-recherge");
                Console.WriteLine(count++ + " best offers");
                Console.WriteLine(count++ + " internate pack");
                Console.WriteLine(count++ + " voice pack");
                Console.WriteLine(count++ + " Bundle packs");
                Console.WriteLine(0 + " Main Menu");
                count = 1;
                int press0or1 = int.Parse(Console.ReadLine());
                if (press0or1 == 0)
                {
                    break;
                }
                if (press0or1 == 1)
                {
                    Console.WriteLine("Enter Grameenphone Mobile No");
                    int ACCOUNTNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("6TkCashback+30Min-150Day on 197Tk\r\nRecharge\r\nEnter Recherge Amount");

                    int AMOUNT = int.Parse(Console.ReadLine());
                    Console.WriteLine("Mobile Reacherge\r\nTo:" + ACCOUNTNo + "\r\nAmount:" + AMOUNT + "\r\nTo Know the amount is " + AMOUNT + " for " + ACCOUNTNo + " recherge offer,contact mobile operator.\r\nEnter Menu PIN to confirm:");
                    Console.ReadLine();
                    Console.WriteLine("recherg successfully");
                }
            }
        }
    }
}