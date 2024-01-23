class Conta
{
    public string PersonName { get; set; }
    public float Balance
    { get => Balance;
        set
        {
            if (value > 0)
            {
                Balance = value;
            }
        }
    }
    public Conta()
    {
        Balance=1000;
    }




}