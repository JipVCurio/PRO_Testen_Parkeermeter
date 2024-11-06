class ParkingMeter
{
    private decimal money = 0;
    private const int maxMinutes = 120;
    private const decimal pricePerMinute = 0.1M;

    //Returns nothing, just adds money (largest acceptable banknote is a '100')
    public void addMoney(int euros)
    {
        if (euros < 100)
        {
            money += euros;
        }
    }

    //Returns current paid-for time (decimal)
    public decimal getTime()
    {
        decimal time = money / pricePerMinute;
        if (time < maxMinutes)
        {
            return time;
        }
        else
        {
            return maxMinutes;
        }
    }

    //Returns leftover money (decimal)
    public decimal buySlip()
    {
        decimal moneySpent = getTime() * pricePerMinute;
        decimal moneyLeft = money - moneySpent;
        return moneyLeft;
    }

    //Returns maximum parking time (int)
    public int getMaxTime()
    {
        return maxMinutes;
    }

    //Return price per minute (decimal)
    public decimal getPricePerMinute()
    {
        return pricePerMinute;
    }

    //Returns current balance (decimal)
    public decimal getMoney()
    {
        return money;
    }
}


