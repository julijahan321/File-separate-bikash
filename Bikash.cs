 class Bikash
{
    int count = 1;
    public void BikashSystem()
    {
        Console.WriteLine("bKash System");
        if (Console.ReadLine() == "*247#" || int.Parse(Console.ReadLine())==0)
        {
                Console.WriteLine("bKash");
                Console.WriteLine(count++ + " Send Money");
                Console.WriteLine(count++ + " Send Money to Non-bKash User");
                Console.WriteLine(count++ + " Mobile Reacherge");
                Console.WriteLine(count++ + " Payment");
                Console.WriteLine(count++ + " Cash Out");
                Console.WriteLine(count++ + " Pay Bill");
                Console.WriteLine(count++ + " Microfinance");
                Console.WriteLine(count++ + " Download bKash App");
                Console.WriteLine(count++ + " My bKash");
                Console.WriteLine(count++ + " Reset PIN");
                count = 1;
                int press1 = int.Parse(Console.ReadLine());
                if (press1 == 1)
                {
                    Console.WriteLine("Enter Receiver bKash Account No:");
                    int ACCOUNTNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("FREE Send Money to 5 Priyo Numbers.\r\nDial *247# and select number finde\r\npriyo Numbers.\r\nEnter Amount:");

                    int AMOUNT = int.Parse(Console.ReadLine());
                    Console.WriteLine("FREE Send Money to 5 Priyo numbers up\r\nto 25,000 Tk. every month\r\nEnter Reference:");
                    int REFERENCE = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add up to Priyo Numbers to Send\r\nMoney for FREE.\r\nTo:" + ACCOUNTNo + "\r\nAmount:" + AMOUNT + "\r\nRefference:" + REFERENCE + "\r\nEnter Menu PIN to confirm");
                    count = 1;
                    Console.ReadLine();
                }
                else if (press1 == 2)
                {
                    Console.WriteLine("Enter Receiver Number:");
                    int ACCOUNTNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Amount:");

                    int AMOUNT = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Reference:");
                    int REFERENCE = int.Parse(Console.ReadLine());
                    Console.WriteLine("Send Monet to Non-bKash User\r\nTo:" + ACCOUNTNo + "\r\nAmount:" + AMOUNT + "\r\nRefference:" + REFERENCE + "\r\nEnter Menu PIN to confirm");
                    count = 1;
                    Console.ReadLine();
                }
                else if (press1 == 4)
                {
                    Console.WriteLine("Enter Merchant bKash Account No:");
                    int ACCOUNTNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Amount:");

                    int AMOUNT = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Reference:");
                    int REFERENCE = int.Parse(Console.ReadLine());
                    Console.WriteLine("Payment.\r\nTo:" + ACCOUNTNo + "\r\nAmount:Tk" + AMOUNT + "\r\nRefference:" + REFERENCE + "\r\nEnter Menu PIN to confirm");
                    count = 1;
                    Console.ReadLine();
                }
                else if (press1 == 5)
                {
                    Console.WriteLine("bKash");
                    Console.WriteLine(count++ + " From Agent");
                    Console.WriteLine(count++ + " From ATM");

                    Console.WriteLine(count++ + " Priyo Agent Number");
                    Console.WriteLine(count++ + " Set Priyo Number to Cash Out at 1.49%");
                    count = 3;

                    int pressforagent = int.Parse(Console.ReadLine());

                    if (pressforagent == 1)
                    {
                        Console.WriteLine("Cash Out at 1.49% byte adding 1 Priyo Agent Number.\r\nDial *247# select option 9 then select option 4 \r\nEnter Agent bKash Number No :");
                    }
                    if (pressforagent == 3)
                    {
                        Console.WriteLine("Priyo Agent Number");
                        Console.WriteLine(count++ + " Add Priyo Agent Number");
                        Console.WriteLine(count++ + " Remove Priyo Agent Number");
                        Console.WriteLine(count++ + " Check Priyo Agent Number");
                        Console.WriteLine(count++ + " Check Priyo Agent Number Trx limit");
                        count = 1;
                        Console.ReadLine();
                    }
                    count = 1;
                }
              
            }
        }
    }

